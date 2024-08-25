using System.Linq;
using Client.Code.Common.Data.Items;
using Client.Code.Common.Services.Assets;
using Client.Code.Game.UI.Elements.Windows.Upgrades.Item;
using UniRx;

namespace Client.Code.Game.UI
{
    public class StoreService
    {
        private readonly PlayerProvider _playerProvider;
        private readonly ProjectAssetsProvider _projectAssetsProvider;
        private readonly ReactiveCollection<ItemData> _upgradeItems = new();

        public StoreService(PlayerProvider playerProvider, ProjectAssetsProvider projectAssetsProvider)
        {
            _playerProvider = playerProvider;
            _projectAssetsProvider = projectAssetsProvider;
        }

        public ReactiveCollection<ItemData> UpgradeItems => _upgradeItems;

        public void Initialize()
        {
            var catalog = _projectAssetsProvider.Config.Items;
            foreach (var item in catalog.Upgrade)
                _upgradeItems.Add(new ItemData(item.Key, IsCanBePurchased(item.Key)));
        }

        public bool IsCanBePurchased(ItemType itemType)
        {
            var account = _playerProvider.Account;
            var catalog = _projectAssetsProvider.Config.Items;
            var item = catalog.Upgrade[itemType];
            return item.Price <= account.GoldCurrency.Value;
        }

        public void Purchase(ItemType itemType)
        {
            var account = _playerProvider.Account;
            var catalog = _projectAssetsProvider.Config.Items;
            var catalogItem = catalog.Upgrade[itemType];
            var itemToRemove = _upgradeItems.FirstOrDefault(item => item.Type == itemType);

            _upgradeItems.Remove(itemToRemove);
            account.GoldCurrency.Value -= catalogItem.Price;
            UpdateItems();
        }

        private void UpdateItems()
        {
            foreach (var item in _upgradeItems) 
                item.IsAvailable.Value = IsCanBePurchased(item.Type);
        }
    }
}