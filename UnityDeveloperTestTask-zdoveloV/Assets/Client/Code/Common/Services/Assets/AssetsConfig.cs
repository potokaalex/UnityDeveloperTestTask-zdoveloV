using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Client.Code.Common.Services.Assets
{
    [CreateAssetMenu(menuName = "Configs/Project/Assets", fileName = "AssetsConfig", order = 0)]
    public class AssetsConfig : SerializedScriptableObject
    {
        public Dictionary<AssetKey, IAsset> Assets;
    }
}