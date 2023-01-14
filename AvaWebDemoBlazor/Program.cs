using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Runtime.Versioning;

using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;

[assembly:SupportedOSPlatform("browser")]

public class Program
{
    public static async Task  Main(string[] args)
    {
        await CreateHostBuilder(args).Build().RunAsync();
    }

    public static WebAssemblyHostBuilder CreateHostBuilder(string[] args)
    {
        var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<AvaWebDemoBlazor.App>("app");

        return builder;
    }
}