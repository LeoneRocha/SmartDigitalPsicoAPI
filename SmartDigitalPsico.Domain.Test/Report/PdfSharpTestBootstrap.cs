using PdfSharp.Fonts;

namespace SmartDigitalPsico.Domain.Test.Report;

internal static class PdfSharpTestBootstrap
{
    private static readonly Lock Sync = new();
    private static bool _configured;

    internal static void EnsureWindowsFonts()
    {
        lock (Sync)
        {
            if (_configured)
                return;

            GlobalFontSettings.UseWindowsFontsUnderWindows = true;
            _configured = true;
        }
    }
}
