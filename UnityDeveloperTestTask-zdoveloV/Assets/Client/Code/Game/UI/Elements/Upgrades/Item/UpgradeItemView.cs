using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Client.Code.Game.UI.Elements.Upgrades.Item
{
    public class UpgradeItemView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _descriptionText;
        [SerializeField] private TextMeshProUGUI _subDescriptionText;
        [SerializeField] private Image _icon;

        public void Initialize(UpgradeItemViewData data)
        {
            _descriptionText.SetText(data.Description);
            _subDescriptionText.SetText(data.SubDescription);
            _icon.sprite = data.Icon;
        }
    }
}