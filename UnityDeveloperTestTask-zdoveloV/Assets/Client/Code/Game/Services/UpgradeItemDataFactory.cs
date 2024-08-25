using System.Collections.Generic;
using Client.Code.Common.Data.Items;
using Client.Code.Common.Services;
using Client.Code.Common.Services.Assets;
using Client.Code.Game.Services.Assets;
using Client.Code.Game.UI.Elements.Windows.Upgrades.Item;

namespace Client.Code.Game.Services
{
    public class UpgradeItemDataFactory
    {
        private readonly ProjectAssetsProvider _projectAssetsProvider;
        private readonly GameAssetsProvider _gameAssetsProvider;
        private readonly CurrencyDataFactory _currencyDataFactory;

        public UpgradeItemDataFactory(ProjectAssetsProvider projectAssetsProvider, GameAssetsProvider gameAssetsProvider,
            CurrencyDataFactory currencyDataFactory)
        {
            _projectAssetsProvider = projectAssetsProvider;
            _gameAssetsProvider = gameAssetsProvider;
            _currencyDataFactory = currencyDataFactory;
        }

        public Dictionary<ItemType, UpgradeItemViewData> CreateViewData()
        {
            var items = _projectAssetsProvider.Config.Items.Upgrade;
            var result = new Dictionary<ItemType, UpgradeItemViewData>(items.Count);

            foreach (var item in items)
                result.Add(item.Key, ToView(item.Value));

            return result;
        }

        private UpgradeItemViewData ToView(ItemConfig item)
        {
            var config = _gameAssetsProvider.UI;

            return new UpgradeItemViewData
            {
                Prefab = config.UpgradesItemPrefab,
                Header = item.Header,
                Description = item.Description,
                Icon = item.Icon,
                Price = _currencyDataFactory.CreateView(item.Price)
            };
        }
    }
}