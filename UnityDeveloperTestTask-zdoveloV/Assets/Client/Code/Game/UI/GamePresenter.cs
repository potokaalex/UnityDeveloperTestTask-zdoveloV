using Client.Code.Common.UI.WindowControlButton;
using Client.Code.Game.UI.Factory;

namespace Client.Code.Game.UI
{
    public class GamePresenter : IWindowControlButtonHandler
    {
        private readonly GameWindowsFactory _windowsFactory;

        public GamePresenter(GameWindowsFactory windowsFactory) => _windowsFactory = windowsFactory;

        public void Handle(WindowControlButton button)
        {
            if (button.ControlType == WindowControlButtonType.Open)
                _windowsFactory.Create(button.WindowType);
            else if (button.ControlType == WindowControlButtonType.Close)
                _windowsFactory.Destroy(button.WindowType);
        }
    }
}