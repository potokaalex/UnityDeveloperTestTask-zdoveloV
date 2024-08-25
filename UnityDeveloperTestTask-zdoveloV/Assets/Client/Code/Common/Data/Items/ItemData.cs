using UniRx;

namespace Client.Code.Common.Data.Items
{
    public class ItemData
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