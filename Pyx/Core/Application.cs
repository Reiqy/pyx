namespace Pyx.Core;

public class Application
{
    private readonly ApplicationSettings settings;

    private readonly Window window;

    public Application(ApplicationSettings settings)
    {
        this.settings = settings;

        this.window = new Window();
    }

    public void Run()
    {
        this.window.Run();
    }
}
