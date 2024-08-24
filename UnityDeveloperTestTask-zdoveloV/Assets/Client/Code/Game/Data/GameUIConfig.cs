using System.Collections.Generic;
using Client.Code.Common.UI.Base.Window;
using Client.Code.Game.UI;
using Client.Code.Game.UI.Elements;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Client.Code.Game.Data
{
    [CreateAssetMenu(menuName = "Configs/Game/UI", fileName = "GameUIConfig", order = 0)]
    public class GameUIConfig : SerializedScriptableObject
    {
        public GameCanvas CanvasPrefab;
        public Dictionary<WindowType, WindowBase> WindowsPrefabs;
    }
}