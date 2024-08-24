using Client.Code.Common.Data.Currency;
using UnityEngine;

namespace Client.Code.Common.Data.Items
{
    [CreateAssetMenu(menuName = "Configs/Project/Item", fileName = "ItemConfig", order = 0)]
    public class ItemConfig : ScriptableObject
    {
        public Sprite Icon;
        public string Header;
        public string Description;
        public CurrencyData Price;
    }
}