using System.Collections.Generic;
using Client.Code.Common.Services.Assets.Base;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Client.Code.Common.Data
{
    [CreateAssetMenu(menuName = "Configs/Project/Assets", fileName = "AssetsConfig", order = 0)]
    public class AssetsConfig : SerializedScriptableObject
    {
        public Dictionary<AssetKey, ILoadableAsset> Assets;
    }
}