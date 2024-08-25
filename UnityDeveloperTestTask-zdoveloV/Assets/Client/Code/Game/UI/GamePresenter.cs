using Client.Code.Common.Data.Items;
using Client.Code.Common.UI.Elements.Buttons.WindowControl;
using Client.Code.Game.UI.Elements.Buttons.Purchase;
using Client.Code.Game.UI.Factories;

namespace Client.Code.Game.UI
{
    public class GamePresenter : IWindowControlButtonHandler, IItemPurchaseButtonHandler
    {
        private readonly GameWindowsFactory _windowsFactory;
        private readonly StoreService _storeService;

        public GamePresenter(GameWindowsFactory windowsFactory, StoreService storeService)
        {
            _windowsFactory = windowsFactory;
            _storeService = storeService;
        }

        public void Handle(WindowControlButton button)
        {
            if (button.ControlType == WindowControlButtonType.Open)
                _windowsFactory.Create(button.WindowType);
            else if (button.ControlType == WindowControlButtonType.Close)
                _windowsFactory.Destroy(button.WindowType);
        }

        public void Handle(ItemType itemType)
        {
            if (_storeService.IsCanBePurchased(itemType))
                _storeService.Purchase(itemType);
        }
    }
}