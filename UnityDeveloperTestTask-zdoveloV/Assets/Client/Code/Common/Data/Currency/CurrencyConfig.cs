using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace Client.Code.Common.Data.Currency
{
    [CreateAssetMenu(menuName = "Configs/Project/Currency", fileName = "CurrencyConfig", order = 0)]
    public class CurrencyConfig : SerializedScriptableObject
    {
        public Dictionary<CurrencyType, Sprite> Icons;
        public Dictionary<CurrencyModifierType, string> Suffixes;
    }
}