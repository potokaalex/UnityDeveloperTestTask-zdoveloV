using Client.Code.Common.Data.Items;
using Client.Code.Common.UI.Elements.Buttons;
using Sirenix.OdinInspector;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace Client.Code.Game.UI.Elements.Buttons.Purchase
{
    public class ItemPurchaseButton : ButtonBase
    {
        [Title("Image")] [SerializeField] private Image _image;
        [SerializeField] private Sprite _defaultImageSprite;
        [SerializeField] private Sprite _lockedImageSprite;

        [Title("Text")] [SerializeField] private TextMeshProUGUI _text;
        [SerializeField] private Material _defaultTextMaterial;
        [SerializeField] private Material _lockedTextMaterial;

        private IItemPurchaseButtonHandler _handler;
        private ItemType _itemType;

        [Inject]
        public void Construct(IItemPurchaseButtonHandler handler) => _handler = handler;

        public void Initialize(ItemType itemType) => _itemType = itemType;

        public void Lock(bool isLocked)
        {
            BaseButton.IsLocked = isLocked;
            
            if (isLocked)
            {
                _image.sprite = _lockedImageSprite;
                _text.fontMaterial = _lockedTextMaterial;
            }
            else
            {
                _image.sprite = _defaultImageSprite;
                _text.fontMaterial = _defaultTextMaterial;
            }
        }

        protected override void OnClick() => _handler.Handle(_itemType);
    }
}