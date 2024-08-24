using System.Collections.Generic;
using Client.Code.Common.UI.Base.Window;
using Client.Code.Common.UI.Base.Window.Factory;
using Client.Code.Common.UI.WindowControlButton;

namespace Client.Code.Game.UI
{
    public class GamePresenter : IWindowControlButtonHandler
    {
        private readonly Dictionary<WindowType, IWindowFactory> _windowFactories = new();

        public GamePresenter(List<IWindowFactory> windowsFactories)
        {
            foreach (var factory in windowsFactories)
                _windowFactories.Add(factory.Type, factory);
        }
        
        public void Handle(WindowControlButton button)
        {
            if (button.ControlType == WindowControlButtonType.Open)
                _windowFactories[button.WindowType].Create();
            else if (button.ControlType == WindowControlButtonType.Close)
                _windowFactories[button.WindowType].Destroy();
        }
    }
}