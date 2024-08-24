using System.Collections.Generic;
using Client.Code.Common.Data.Items;
using Client.Code.Game.UI.Elements.Upgrades;
using Client.Code.Game.UI.Elements.Upgrades.Item;

namespace Client.Code.Game.Services.Extensions
{
    public static class ItemDataExtensions
    {
        public static Dictionary<ItemType, UpgradeItemViewData> ToView(this Dictionary<ItemType, ItemConfig> items, UpgradeItemView prefab)
        {
            var data = new Dictionary<ItemType, UpgradeItemViewData>(items.Count);

            foreach (var item in items)
                data.Add(item.Key, item.Value.ToView(prefab));

            return data;
        }

        private static UpgradeItemViewData ToView(this ItemConfig items, UpgradeItemView prefab)
        {
            return new UpgradeItemViewData
            {
                Prefab = prefab
            };
        }
    }
}