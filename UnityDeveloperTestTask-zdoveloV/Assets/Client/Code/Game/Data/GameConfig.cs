using Client.Code.Common.Services.Assets.Base;
using UnityEngine;

namespace Client.Code.Game.Data
{
    [CreateAssetMenu(menuName = "Configs/Game/Main", fileName = "GameConfig", order = 0)]
    public class GameConfig : ScriptableObject, ILoadableAsset
    {
        public GameUIConfig UI;
    }
}