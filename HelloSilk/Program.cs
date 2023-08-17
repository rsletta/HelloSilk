using Silk.NET.Input;
using Silk.NET.Maths;
using Silk.NET.Windowing;

namespace HelloSilk
{
    public static class Program
    {
        public static void Main(params string[] args)
        {
            WindowOptions options = WindowOptions.Default;
            options.Title = "Hello Silk!";
            options.Size = new Vector2D<int>(1280, 720);
            IWindow window = Window.Create(options);

            window.Load += () => { };
            window.Update += (double d) => { };
            window.Render += OnWindowOnRender;

            window.Run();
        }

        private static void OnWindowOnRender(double d)
        {
            
        }
    }
}