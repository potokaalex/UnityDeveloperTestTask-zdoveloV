using System.Collections.Generic;
using Client.Code.Common.Data.Items;
using Client.Code.Common.Services.Assets;
using Client.Code.Game.Services.Assets;
using Client.Code.Game.Services.Extensions;
using Client.Code.Game.UI.Elements.Upgrades;
using Client.Code.Game.UI.Elements.Upgrades.Item;
using Client.Code.Game.UI.Elements.Upgrades.Window;
using UnityEngine;

namespace Client.Code.Game.UI
{
    public class GameUIProvider : IUpgradesUIProvider
    {
        private readonly GameAssetsProvider _assetsProvider;
        private readonly ProjectAssetsProvider _projectAssetsProvider;
        private Dictionary<ItemType, UpgradeItemViewData> _upgradeItemsViewData;

        public GameUIProvider(GameAssetsProvider assetsProvider, ProjectAssetsProvider projectAssetsProvider)
        {
            _assetsProvider = assetsProvider;
            _projectAssetsProvider = projectAssetsProvider;
        }

        public Transform WindowRoot { get; private set; }

        public UpgradesWindow WindowPrefab => _assetsProvider.UI.UpgradesWindowPrefab;

        public Dictionary<ItemType, UpgradeItemViewData> Items => _upgradeItemsViewData;

        public void Initialize(Transform windowRoot)
        {
            WindowRoot = windowRoot;
            _upgradeItemsViewData = _projectAssetsProvider.Config.Items.Upgrade.ToView(_assetsProvider.UI.UpgradesItemPrefab);
        }
    }
}