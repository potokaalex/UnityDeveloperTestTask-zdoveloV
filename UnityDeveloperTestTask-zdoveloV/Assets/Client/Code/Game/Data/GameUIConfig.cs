using Client.Code.Game.UI;
using UnityEngine;

namespace Client.Code.Game.Data
{
    [CreateAssetMenu(menuName = "Configs/Game/UI", fileName = "GameUIConfig", order = 0)]
    public class GameUIConfig : ScriptableObject
    {
        public GameCanvas CanvasPrefab;
    }
}