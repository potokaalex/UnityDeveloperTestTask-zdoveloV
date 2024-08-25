using Cysharp.Threading.Tasks;
using DG.Tweening;
using UnityEngine;

namespace Client.Code.Common.UI.Elements.Windows.Base
{
    [RequireComponent(typeof(WindowBase))]
    public class WindowAnimator : MonoBehaviour
    {
        [SerializeField] private float _animationDuration = 0.2f;
        [SerializeField] private float _minScale = 0.8f;
        [SerializeField] private RectTransform _transform;
        private Tween _currentTween;

        public void PlayOpen()
        {
            _currentTween.Complete();
            _transform.localScale = Vector2.one * _minScale;
            gameObject.SetActive(true);

            _currentTween = _transform.DOScale(Vector2.one, _animationDuration).SetEase(Ease.OutBack);
        }

        public void PlayClose()
        {
            _currentTween.Complete();
            _currentTween = _transform.DOScale(Vector2.one * _minScale, _animationDuration).SetEase(Ease.InBack).OnComplete(() =>
            {
                gameObject.SetActive(false);
                _transform.localScale = Vector2.one;
            });
        }
    }
}