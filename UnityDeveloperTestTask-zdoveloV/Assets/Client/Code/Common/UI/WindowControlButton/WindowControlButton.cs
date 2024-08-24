using Client.Code.Common.UI.Base;
using Client.Code.Common.UI.Base.Window;
using Zenject;

namespace Client.Code.Common.UI.WindowControlButton
{
    public class WindowControlButton : ButtonBase
    {
        public WindowControlButtonType ControlType;
        public WindowType WindowType;
        
        private IWindowControlButtonHandler _handler;

        [Inject]
        public void Construct(IWindowControlButtonHandler handler) => _handler = handler;

        private protected override void OnClick() => _handler.Handle(this);
    }
}