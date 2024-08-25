using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Client.Code.Common.Data.Items
{
    [CreateAssetMenu(menuName = "Configs/Project/Items", fileName = "ItemsConfig", order = 0)]
    public class ItemsConfig : SerializedScriptableObject
    {
        public Dictionary<ItemType, ItemConfig> Upgrade;
    }
}