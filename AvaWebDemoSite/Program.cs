using System;
using System.Runtime.Versioning;

using Avalonia;
using Avalonia.Web;

[assembly:SupportedOSPlatform("browser")]

internal partial class Program
{
    private static void Main(string[] args)
    {
        AppBuilder  .Configure<AvaWebDemoApp.App>()
                    .SetupBrowserApp("out");
    }
}
