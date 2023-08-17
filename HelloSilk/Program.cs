using Silk.NET.Input;
using Silk.NET.Maths;
using Silk.NET.Windowing;

namespace HelloSilk
{
    public static class Program
    {
        private static IWindow _window;
        private static IInputContext _input;

        public static void Main(params string[] args)
        {
            WindowOptions options = WindowOptions.Default;
            options.Title = "Hello Silk!";
            options.Size = new Vector2D<int>(1280, 720);
            _window = Window.Create(options);

            _window.Load += OnWindowLoad;
            _window.Update += OnUpdate;
            _window.Render += OnWindowOnRender;

            _window.Run();
        }

        private static void OnWindowLoad()
        {
            _input = _window.CreateInput();

            for (int i = 0; i < _input.Keyboards.Count; i++)
                _input.Keyboards[i].KeyDown += KeyDown;
        }

        private static void OnUpdate(double deltaTime) { }

        private static void OnWindowOnRender(double deltaTime)
        {
            
        }

        private static void KeyDown(IKeyboard keyboard, Key key, int keyCode) {
            if (key == Key.Escape)
            {
                _window.Close();
            } else
            {
                Console.WriteLine($"{key}");
            }
                
        }
    }
}