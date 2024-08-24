using Client.Code.Game.UI.Elements.Upgrades.Item;
using Client.Code.Game.UI.Elements.Upgrades.Window;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Client.Code.Game.Data
{
    [CreateAssetMenu(menuName = "Configs/Game/Upgrades", fileName = "UpgradesConfig", order = 0)]
    public class UpgradesConfig : SerializedScriptableObject
    {
        public UpgradesWindow Prefab;
        public UpgradeItemView ItemPrefab;
    }
}