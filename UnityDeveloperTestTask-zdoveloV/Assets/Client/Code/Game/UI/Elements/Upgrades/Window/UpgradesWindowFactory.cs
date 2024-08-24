using Client.Code.Common.UI.Base.Window;
using Client.Code.Game.Data;
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
            {
                _window = _instantiator.InstantiatePrefabForComponent<UpgradesWindow>(_provider.WindowPrefab, _provider.WindowRoot);
                _window.ForceClose();
            }
   
            foreach (var itemType in _model.AvailableItems)
                CreateItem(itemType);

            _window.Open();
        }

        public void Destroy() => _window.Close();

        private void CreateItem(UpgradeItemType type)
        {
            var prefab = _provider.ItemPrefab;
            var item = _instantiator.InstantiatePrefabForComponent<UpgradeItemView>(prefab, _window.ItemsRoot);
            //item.Initialize(data);
        }
    }
}