using Client.Code.Game.UI.Elements.Currency;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Client.Code.Game.UI.Elements.Upgrades.Item
{
    public class UpgradeItemUI : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _descriptionText;
        [SerializeField] private TextMeshProUGUI _subDescriptionText;
        [SerializeField] private Image _icon;
        [SerializeField] private CurrencyView _price;

        public void Initialize(UpgradeItemViewData data)
        {
            _descriptionText.SetText(data.Description);
            _subDescriptionText.SetText(data.SubDescription);
            _icon.sprite = data.Icon;
            _price.Initialize(data.Price);
        }
    }
}