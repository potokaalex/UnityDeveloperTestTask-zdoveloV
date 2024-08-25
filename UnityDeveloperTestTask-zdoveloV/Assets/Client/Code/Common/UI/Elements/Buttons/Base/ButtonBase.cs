using UnityEngine;

namespace Client.Code.Common.UI.Elements.Buttons.Base
{
    [RequireComponent(typeof(CustomButton))]
    public abstract class ButtonBase : MonoBehaviour
    {
        private CustomButton _baseButton;

        protected CustomButton BaseButton
        {
            get
            {
                if (!_baseButton)
                    _baseButton = gameObject.GetComponent<CustomButton>();
                return _baseButton;
            }
        }

        private void Awake() => BaseButton.onClick.AddListener(OnClick);

        private void OnDestroy() => BaseButton.onClick.RemoveListener(OnClick);

        protected abstract void OnClick();
    }
}