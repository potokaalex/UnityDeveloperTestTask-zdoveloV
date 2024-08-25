using Client.Code.Common.UI.Elements.Currency;
using Client.Code.Game.UI.Elements.Buttons.Purchase;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Client.Code.Game.UI.Elements.Windows.Upgrades.Item
{
    public class UpgradeItemView : MonoBehaviour
    {
        public ItemPurchaseButton PurchaseButton;

        [SerializeField] private TextMeshProUGUI _headerText;
        [SerializeField] private TextMeshProUGUI _descriptionText;
        [SerializeField] private Image _icon;
        [SerializeField] private CurrencyView _price;

        public void Initialize(UpgradeItemViewData data)
        {
            _headerText.SetText(data.Header);
            _descriptionText.SetText(data.Description);
            _icon.sprite = data.Icon;
            _price.Set(data.Price);
        }
    }
}