using DG.Tweening;
using DoTweenAnimations.Data;
using UnityEngine;

namespace DoTweenAnimations.OpeningAnimations
{
    public class ScaleOpeningAnimation : OpeningAnimation
    {
        [SerializeField] private Transform _transform;

        protected override void SetOpenState()
        {
            ScaleTransform(1);
        }

        protected override void SetCloseState()
        {
            ScaleTransform(0);
        }

        private void ScaleTransform(float scaleValue)
        {
            _tween?.Kill();
            _tween = _transform.DOScale(scaleValue, _tweenData.Time).SetEase(_tweenData.Ease);
        }
    }
}