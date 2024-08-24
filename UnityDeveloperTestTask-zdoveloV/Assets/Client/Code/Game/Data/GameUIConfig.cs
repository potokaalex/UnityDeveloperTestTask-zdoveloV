using Client.Code.Game.UI.Elements;
using Client.Code.Game.UI.Elements.Windows.Upgrades.Item;
using Client.Code.Game.UI.Elements.Windows.Upgrades.Window;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Client.Code.Game.Data
{
    [CreateAssetMenu(menuName = "Configs/Game/UI", fileName = "GameUIConfig", order = 0)]
    public class GameUIConfig : SerializedScriptableObject
    {
        public GameCanvas CanvasPrefab;
        public UpgradesWindow UpgradesWindowPrefab;
        public UpgradeItemView UpgradesItemPrefab;
    }
}