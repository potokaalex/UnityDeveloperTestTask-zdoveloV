using Client.Code.Common.UI.Base.Window;
using Client.Code.Common.UI.Base.Window.Factory;
using Client.Code.Game.Data;
using Zenject;

namespace Client.Code.Game.UI.Elements.Upgrades.Window
{
    public class UpgradesWindowFactory : IWindowFactory
    {
        private readonly IUpgradesWindowModel _model;
        private readonly IInstantiator _instantiator;
        private readonly IUpgradesUIProvider _provider;
        private WindowBase _window;

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
                _window = _instantiator.InstantiatePrefabForComponent<WindowBase>(_provider.WindowPrefab, _provider.WindowRoot);
                _window.ForceClose();
            }

            //TODO: setup window (connect it with model!)

            foreach (var itemType in _model.AvailableItems)
                CreateItem(itemType);

            _window.Open();
        }

        public void Destroy() => _window.Close();

        private void CreateItem(UpgradeItemType type)
        {
            //var data = _provider.GetItemData(type);
            //var item = _instantiator.InstantiatePrefabForComponent<UpgradeItemUI>(data.Prefab);
            //item.Initialize(data);
        }
    }
}