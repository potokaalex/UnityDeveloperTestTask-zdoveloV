using Client.Code.Common.UI.Base.Window;
using Client.Code.Game.UI.Elements.Upgrades.Item;
using Zenject;

namespace Client.Code.Game.UI.Elements.Upgrades.Window
{
    public class UpgradesWindowFactory : IWindowFactory
    {
        private readonly IUpgradesWindowModel _model;
        private readonly IInstantiator _instantiator;
        private readonly IUpgradesUIProvider _provider;
        private UpgradesWindow _window;

        public UpgradesWindowFactory(IUpgradesWindowModel model, IInstantiator instantiator, IUpgradesUIProvider provider)
        {
            _model = model;
            _instantiator = instantiator;
            _provider = provider;
        }

        public WindowType Type => WindowType.Upgrades;

        public void Create()
        {
            if (!_window)
                CreateNewWindow();

            _window.Open();
        }

        private void CreateNewWindow()
        {
            var prefab = _provider.Config.Prefab;
            _window = _instantiator.InstantiatePrefabForComponent<UpgradesWindow>(prefab, _provider.WindowRoot);
            _window.ForceClose();

            foreach (var itemType in _model.AvailableItems)
                CreateItem(itemType);
        }

        public void Destroy() => _window.Close();

        private void CreateItem(UpgradeItemType type)
        {
            var data = _provider.Config.ItemsData[type];
            var prefab = _provider.Config.ItemPrefab;
            var item = _instantiator.InstantiatePrefabForComponent<UpgradeItemView>(prefab, _window.ItemsRoot);
            item.Initialize(data);
        }
    }
}