using Client.Code.Common.Data.Items;
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
            var prefab = _provider.WindowPrefab;
            _window = _instantiator.InstantiatePrefabForComponent<UpgradesWindow>(prefab, _provider.WindowRoot);
            _window.ForceClose();

            foreach (var itemType in _model.AvailableItems)
                CreateItem(itemType);
        }

        public void Destroy() => _window.Close();

        private void CreateItem(ItemType type)
        {
            var data = _provider.Items[type];
            var item = _instantiator.InstantiatePrefabForComponent<UpgradeItemView>(data.Prefab, _window.ItemsRoot);
            item.Initialize(data);
        }
    }
}