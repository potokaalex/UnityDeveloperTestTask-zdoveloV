using Client.Code.Common.Data.Items;
using UniRx;

namespace Client.Code.Game.UI.Elements.Windows.Upgrades.Item
{
    public struct ItemData
    {
        public readonly ItemType Type;
        public readonly ReactiveProperty<bool> IsAvailable;

        public ItemData(ItemType type, bool isAvailable)
        {
            Type = type;
            IsAvailable = new ReactiveProperty<bool>(isAvailable);
        }
    }
}