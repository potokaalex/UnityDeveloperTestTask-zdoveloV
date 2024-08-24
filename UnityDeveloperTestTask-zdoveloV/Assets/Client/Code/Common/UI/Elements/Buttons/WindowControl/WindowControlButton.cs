using Client.Code.Common.UI.Elements.Windows;
using Zenject;

namespace Client.Code.Common.UI.Elements.Buttons.WindowControl
{
    public class WindowControlButton : ButtonBase
    {
        public WindowControlButtonType ControlType;
        public WindowType WindowType;
        
        private IWindowControlButtonHandler _handler;

        [Inject]
        public void Construct(IWindowControlButtonHandler handler) => _handler = handler;

        protected override void OnClick() => _handler.Handle(this);
    }
}