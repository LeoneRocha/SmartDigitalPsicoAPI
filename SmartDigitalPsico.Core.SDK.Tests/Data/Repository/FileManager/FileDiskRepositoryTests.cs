using SmartDigitalPsico.Core.SDK.Data.Repository.FileManager;
using SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts;

namespace SmartDigitalPsico.Core.SDK.Tests.Data.Repository.FileManager;

[TestFixture]
public class FileDiskRepositoryTests
{
    private string _temporaryDirectory = null!;

    [SetUp]
    public void SetUp()
    {
        _temporaryDirectory = Path.Combine(Path.GetTempPath(), $"core-sdk-filedisk-{Guid.NewGuid():N}");
        Directory.CreateDirectory(_temporaryDirectory);
        FileDiskRepository.OpenReadForTests = null;
    }

    [TearDown]
    public void TearDown()
    {
        FileDiskRepository.OpenReadForTests = null;
        if (Directory.Exists(_temporaryDirectory))
            Directory.Delete(_temporaryDirectory, recursive: true);
    }

    [Test]
    public async Task PersistsReadsReplacesAndDeletesFiles()
    {
        var repository = new FileDiskRepository();
        var criteria = new FileData
        {
            FolderDestination = _temporaryDirectory,
            FilePath = _temporaryDirectory,
            FileName = "payload.bin",
            FileData = [1, 2, 3]
        };

        (await repository.Save(new FileData { FileData = null! })).Should().BeFalse();
        (await repository.Save(criteria)).Should().BeTrue();
        repository.Exists(criteria).Should().BeTrue();
        (await repository.Get(criteria)).Should().Equal(1, 2, 3);

        criteria.FileData = [4, 5];
        (await repository.Save(criteria)).Should().BeTrue();
        (await repository.Get(new FileData
        {
            FilePath = Path.Combine(_temporaryDirectory, criteria.FileName),
            FileName = "ignored"
        })).Should().Equal(4, 5);
        (await repository.Get(new FileData
        {
            FilePath = Path.Combine(_temporaryDirectory, "missing.bin"),
            FileName = "missing.bin"
        })).Should().BeEmpty();

        await repository.Delete(criteria);
        repository.Exists(criteria).Should().BeFalse();
        await repository.Delete(new FileData
        {
            FilePath = Path.Combine(_temporaryDirectory, "missing.bin"),
            FileName = "missing.bin"
        });
    }

    [Test]
    public async Task ExistsAndGetPathBranches_AreCovered()
    {
        var repository = new FileDiskRepository();
        var folder = Path.Combine(_temporaryDirectory, "exists");
        var filePath = Path.Combine(folder, "found.bin");
        Directory.CreateDirectory(folder);
        await File.WriteAllBytesAsync(filePath, [3, 4]);
        var byDirectPath = Path.Combine(_temporaryDirectory, "direct-only.bin");
        await File.WriteAllBytesAsync(byDirectPath, [5]);

        var exists = repository.Exists(new FileData { FilePath = folder, FileName = "found.bin" });
        var fromCombined = await repository.Get(new FileData { FilePath = folder, FileName = "found.bin" });
        var fromDirect = await repository.Get(new FileData { FilePath = byDirectPath, FileName = "ignored.bin" });
        await repository.Delete(new FileData { FilePath = folder, FileName = "found.bin" });

        using (Assert.EnterMultipleScope())
        {
            exists.Should().BeTrue();
            fromCombined.Should().Equal(3, 4);
            fromDirect.Should().Equal(5);
            repository.Exists(new FileData { FilePath = folder, FileName = "missing.bin" }).Should().BeFalse();
        }
    }

    [Test]
    public async Task IncompleteRead_ThrowsIoException()
    {
        var filePath = Path.Combine(_temporaryDirectory, "partial.bin");
        await File.WriteAllBytesAsync(filePath, [1, 2, 3, 4]);
        FileDiskRepository.OpenReadForTests = _ => new ShortReadStream([9, 8], reportedLength: 4);

        var repository = new FileDiskRepository();
        var act = async () => await repository.Get(new FileData
        {
            FilePath = filePath,
            FileName = "ignored"
        });

        await act.Should().ThrowAsync<IOException>();
    }

    [Test]
    public void Get_NullCriteria_Throws()
    {
        var repository = new FileDiskRepository();
        var act = () => repository.Get(null!);
        act.Should().ThrowAsync<ArgumentNullException>();
    }

    private sealed class ShortReadStream : MemoryStream
    {
        private readonly long _reportedLength;

        public ShortReadStream(byte[] buffer, long reportedLength) : base(buffer)
        {
            _reportedLength = reportedLength;
        }

        public override long Length => _reportedLength;
    }
}
