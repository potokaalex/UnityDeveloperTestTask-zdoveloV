using Client.Code.Game.UI.Elements;
using Client.Code.Game.UI.Elements.Upgrades;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Client.Code.Game.UI
{
    [CreateAssetMenu(menuName = "Configs/Game/UI", fileName = "GameUIConfig", order = 0)]
    public class GameUIConfig : SerializedScriptableObject
    {
        public UpgradesConfig Upgrades;
        public GameCanvas CanvasPrefab;
    }
}