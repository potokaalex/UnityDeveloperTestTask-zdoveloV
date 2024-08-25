using Client.Code.Common.Data.Currency;
using Client.Code.Game.UI.Elements.Windows.Upgrades.Item;
using Client.Code.Game.UI.Elements.Windows.Upgrades.Window;
using UniRx;

namespace Client.Code.Game.UI
{
    public class GameModel : IUpgradesWindowModel
    {
        private readonly StoreService _storeService;
        private readonly PlayerProvider _playerProvider;

        public ReactiveProperty<CurrencyData> GoldCurrency { get; private set; }

        public ReactiveCollection<ItemData> Items { get; private set; }

        public GameModel(StoreService storeService, PlayerProvider playerProvider)
        {
            _storeService = storeService;
            _playerProvider = playerProvider;
        }

        public void Initialize()
        {
            Items = _storeService.UpgradeItems;
            GoldCurrency = _playerProvider.Account.GoldCurrency;
        }
    }
}