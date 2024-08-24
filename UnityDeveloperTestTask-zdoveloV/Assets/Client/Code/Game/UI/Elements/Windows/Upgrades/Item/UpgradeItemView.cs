using Client.Code.Common.UI.Elements.Currency;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Client.Code.Game.UI.Elements.Windows.Upgrades.Item
{
    public class UpgradeItemView : MonoBehaviour
    {
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