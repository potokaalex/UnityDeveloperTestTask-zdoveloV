using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace Client.Code.Game.UI.Elements.Upgrades.Item
{
    public class UpgradeItemView : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI _headerText;
        [SerializeField] private TextMeshProUGUI _descriptionText;
        [SerializeField] private Image _icon;

        public void Initialize(UpgradeItemData data)
        {
            _headerText.SetText(data.Header);
            _descriptionText.SetText(data.Description);
            _icon.sprite = data.Icon;
        }
    }
}