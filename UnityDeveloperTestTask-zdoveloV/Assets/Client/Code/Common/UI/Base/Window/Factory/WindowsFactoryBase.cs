using System.Collections.Generic;

namespace Client.Code.Common.UI.Base.Window.Factory
{
    public abstract class WindowsFactoryBase : IWindowsFactory
    {
        private readonly List<WindowBase> _windows = new();

        public WindowBase Create(WindowType type)
        {
            if (!TryGetWindow(type, out var window))
            {
                window = CreateNewWindow(type);
                _windows.Add(window);
            }

            window.ForceClose();
            return window;
        }

        public void Destroy(WindowType type)
        {
            if (TryGetWindow(type, out var window))
                window.Close();
        }

        private bool TryGetWindow(WindowType type, out WindowBase resultWindow)
        {
            foreach (var window in _windows)
            {
                if (window.BaseType == type)
                {
                    resultWindow = window;
                    return true;
                }
            }

            resultWindow = null;
            return false;
        }

        protected abstract WindowBase CreateNewWindow(WindowType type);
    }
}