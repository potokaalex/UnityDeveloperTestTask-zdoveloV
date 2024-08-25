using DG.Tweening;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Client.Code.Common.UI.Elements.Buttons.Animations
{
    [RequireComponent(typeof(CustomButton))]
    public class ButtonAnimator : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IDragHandler, IPointerClickHandler
    {
        [SerializeField] private Sprite _defaultSprite;
        [SerializeField] private Sprite _pressedSprite;
        [SerializeField] private float _animationDuration = 0.1f;
        private CustomButton _button;
        private Image _image;
        private Tween _currenTween;

        private void Awake()
        {
            _button = GetComponent<CustomButton>();
            _image = _button.image;
        }

        private void OnEnable() => _button.interactable = false;

        private void OnDisable() => _button.interactable = true;

        public void OnPointerDown(PointerEventData eventData)
        {
            if (!_button.IsLocked)
                PlayDown();
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            if (!_button.IsLocked)
                PlayUp();
        }

        public void OnPointerClick(PointerEventData eventData)
        {
            if (!_button.IsLocked)
                PlayClick();
        }

        public void OnDrag(PointerEventData eventData)
        {
        }

        private void PlayClick()
        {
            _currenTween.Complete();
            _button.onClick.Invoke();
        }

        private void PlayDown()
        {
            _currenTween.Complete();
            _image.sprite = _pressedSprite;
            _currenTween = _image.transform.DOScale(new Vector3(0.95f, 0.95f, 1f), _animationDuration).SetEase(Ease.OutBack);
        }

        private void PlayUp()
        {
            _currenTween.Complete();
            _image.sprite = _defaultSprite;
            _currenTween = _image.transform.DOScale(Vector3.one, _animationDuration).SetEase(Ease.OutBack);
        }
    }
}