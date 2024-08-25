using System.Collections.Generic;
using Client.Code.Common.Data.Items;
using Client.Code.Game.Services;
using Client.Code.Game.Services.Assets;
using Client.Code.Game.UI.Elements.Windows.Upgrades;
using Client.Code.Game.UI.Elements.Windows.Upgrades.Item;
using Client.Code.Game.UI.Elements.Windows.Upgrades.Window;
using UnityEngine;

namespace Client.Code.Game.UI
{
    public class GameUIProvider : IUpgradesUIProvider
    {
        private readonly GameAssetsProvider _assetsProvider;
        private readonly UpgradeItemDataFactory _upgradeItemDataFactory;

        public GameUIProvider(GameAssetsProvider assetsProvider, UpgradeItemDataFactory upgradeItemDataFactory)
        {
            _assetsProvider = assetsProvider;
            _upgradeItemDataFactory = upgradeItemDataFactory;
        }

        public Transform WindowRoot { get; private set; }

        public UpgradesWindow WindowPrefab => _assetsProvider.UI.UpgradesWindowPrefab;

        public Dictionary<ItemType, UpgradeItemViewData> Items { get; private set; }

        public void Initialize(Transform windowRoot)
        {
            WindowRoot = windowRoot;
            Items = _upgradeItemDataFactory.CreateViewData();
        }
    }
}