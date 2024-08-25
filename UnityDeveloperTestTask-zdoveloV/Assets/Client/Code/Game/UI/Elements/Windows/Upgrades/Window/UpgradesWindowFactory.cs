using System.Collections.Generic;
using Client.Code.Common.Data.Items;
using Client.Code.Common.UI.Elements.Windows;
using Client.Code.Game.UI.Elements.Windows.Upgrades.Item;
using UniRx;
using UnityEngine;
using Zenject;

namespace Client.Code.Game.UI.Elements.Windows.Upgrades.Window
{
    public class UpgradesWindowFactory : IWindowFactory
    {
        private readonly IUpgradesWindowModel _model;
        private readonly IInstantiator _instantiator;
        private readonly IUpgradesUIProvider _provider;
        private readonly Dictionary<ItemType, UpgradeItemView> _items = new();
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

            foreach (var itemData in _model.Items)
                CreateItem(itemData);

            _model.Items.ObserveAdd().Subscribe(d => CreateItem(d.Value));
            _model.Items.ObserveRemove().Subscribe(d => DestroyItem(d.Value));
        }

        public void Destroy() => _window.Close();

        private void CreateItem(ItemData data)
        {
            var viewData = _provider.Items[data.Type];
            var item = _instantiator.InstantiatePrefabForComponent<UpgradeItemView>(viewData.Prefab, _window.ItemsRoot);

            item.Initialize(viewData);
            _items.Add(data.Type, item);

            item.PurchaseButton.Initialize(data.Type);
            data.IsAvailable.Subscribe(isAvailable => item.PurchaseButton.Lock(!isAvailable));
        }

        private void DestroyItem(ItemData data)
        {
            var item = _items[data.Type];
            _items.Remove(data.Type);
            Object.Destroy(item.gameObject);
        }
    }
}