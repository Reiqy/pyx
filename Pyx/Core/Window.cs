namespace Pyx.Core;

using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;

public class Window : GameWindow
{
    public Window() : base(GameWindowSettings.Default, NativeWindowSettings.Default)
    {
    }

    protected override void OnUpdateFrame(FrameEventArgs args)
    {
    }
}
