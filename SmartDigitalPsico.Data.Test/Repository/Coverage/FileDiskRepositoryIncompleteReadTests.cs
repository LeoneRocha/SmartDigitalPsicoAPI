using SmartDigitalPsico.Core.SDK.Domain.EntityModels.Contracts;

namespace SmartDigitalPsico.Data.Test.Repository.Coverage;

[TestFixture]
public class FileDiskRepositoryIncompleteReadTests
{
    [TearDown]
    public void TearDown()
    {
        SmartDigitalPsico.Core.SDK.Data.Repository.FileManager.FileDiskRepository.OpenReadForTests = null;
    }

    // Cenário: a leitura do arquivo retorna menos bytes que o tamanho declarado.
    // Objetivo: garantir que o repositório sinaliza IOException de leitura incompleta.
    [Test]
    public async Task Get_IncompleteStreamRead_ThrowsIoException()
    {
        // Arrange
        var directory = Path.Combine(Path.GetTempPath(), "sdp-incomplete-" + Guid.NewGuid().ToString("N"));
        Directory.CreateDirectory(directory);
        var path = Path.Combine(directory, "partial.bin");
        await File.WriteAllBytesAsync(path, [1, 2, 3, 4, 5, 6, 7, 8]);
        var repository = new SmartDigitalPsico.Core.SDK.Data.Repository.FileManager.FileDiskRepository();
        SmartDigitalPsico.Core.SDK.Data.Repository.FileManager.FileDiskRepository.OpenReadForTests = _ => new IncompleteReadStream(expectedLength: 8, bytesToReturn: 3);

        try
        {
            // Act
            var act = async () => await repository.Get(new FileData
            {
                FilePath = directory,
                FileName = "partial.bin"
            });

            // Assert
            await act.Should().ThrowAsync<IOException>()
                .WithMessage("Could not read the entire file.");
        }
        finally
        {
            SmartDigitalPsico.Core.SDK.Data.Repository.FileManager.FileDiskRepository.OpenReadForTests = null;
            if (Directory.Exists(directory))
            {
                Directory.Delete(directory, true);
            }
        }
    }

    private sealed class IncompleteReadStream : Stream
    {
        private readonly int _bytesToReturn;
        private int _position;

        public IncompleteReadStream(long expectedLength, int bytesToReturn)
        {
            Length = expectedLength;
            _bytesToReturn = bytesToReturn;
        }

        public override bool CanRead => true;
        public override bool CanSeek => false;
        public override bool CanWrite => false;
        public override long Length { get; }
        public override long Position
        {
            get => _position;
            set => throw new NotSupportedException();
        }

        public override void Flush() { }

        public override int Read(byte[] buffer, int offset, int count)
        {
            if (_position >= _bytesToReturn)
            {
                return 0;
            }

            var toCopy = Math.Min(count, _bytesToReturn - _position);
            Array.Clear(buffer, offset, toCopy);
            _position += toCopy;
            return toCopy;
        }

        public override long Seek(long offset, SeekOrigin origin) => throw new NotSupportedException();
        public override void SetLength(long value) => throw new NotSupportedException();
        public override void Write(byte[] buffer, int offset, int count) => throw new NotSupportedException();
    }
}
