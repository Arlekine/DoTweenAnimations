using DG.Tweening;
using DoTweenAnimations.Data;
using UnityEngine;

namespace DoTweenAnimations.OpeningAnimations
{
    public class FadeOpeningAnimation : OpeningAnimation
    {
        [SerializeField] private CanvasGroup _canvasGroup;

        private Tween _tween;

        protected override void SetOpenState()
        {
            FadeCanvasGroup(1);
        }

        protected override void SetCloseState()
        {
            FadeCanvasGroup(0);
        }

        private void FadeCanvasGroup(float fadeValue)
        {
            _tween?.Kill();
            _tween = _canvasGroup.DOFade(fadeValue, _tweenData.Time).SetEase(_tweenData.Ease);
        }
    }
}