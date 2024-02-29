namespace Playground;

using Pyx.Core;

internal class Program
{
    static void Main(string[] args)
    {
        var application = new Application(ApplicationSettings.Default);
        application.Run();
    }
}
