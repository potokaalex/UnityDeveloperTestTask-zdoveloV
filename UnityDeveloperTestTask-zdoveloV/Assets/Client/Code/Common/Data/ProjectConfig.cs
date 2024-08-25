using Client.Code.Common.Data.Currency;
using Client.Code.Common.Data.Items;
using Client.Code.Common.Services.Assets.Base;
using Client.Code.Common.Services.Input;
using UnityEngine;

namespace Client.Code.Common.Data
{
    [CreateAssetMenu(menuName = "Configs/Project/Main", fileName = "ProjectConfig", order = 0)]
    public class ProjectConfig : ScriptableObject, ILoadableAsset
    {
        public ItemsConfig Items;
        public CurrencyConfig Currency;
        public InputObject InputPrefab;
    }
}