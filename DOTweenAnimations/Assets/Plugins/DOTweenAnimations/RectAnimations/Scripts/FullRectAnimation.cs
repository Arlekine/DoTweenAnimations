using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using DG.Tweening.Core;
using DoTweenAnimations.Data;
using UnityEngine;

namespace DoTweenAnimations.RectAnimations
{
    public class FullRectAnimation : MonoBehaviour
    {
        [SerializeField] private RectTransform _animatableRect;
        [SerializeField] private TweenData _tweenData;

        private Tween _leftTween;
        private Tween _rightTween;
        private Tween _topTween;
        private Tween _bottomTween;

        public void SetData(TweenData tweenData)
        {
            _tweenData = tweenData;
        }

        public void SetLeft(float left)
        {
            Animate(ref _leftTween, x => _animatableRect.offsetMin = new Vector2(x, _animatableRect.offsetMin.y),
                _animatableRect.offsetMin.x, left);
        }

        public void SetRight(float right)
        {
            Animate(ref _rightTween, x => _animatableRect.offsetMax = new Vector2(-x, _animatableRect.offsetMax.y),
                -_animatableRect.offsetMax.x, right);
        }

        public void SetTop(float top)
        {
            Animate(ref _topTween, x => _animatableRect.offsetMax = new Vector2(_animatableRect.offsetMax.x, -x),
                -_animatableRect.offsetMax.y, top);
        }

        public void SetBottom(float bottom)
        {
            Animate(ref _bottomTween, x => _animatableRect.offsetMin = new Vector2(_animatableRect.offsetMin.x, x), _animatableRect.offsetMin.y, bottom);
        }

        private Tween Animate(ref Tween tween, DOSetter<float> setter, float startValue, float endValue)
        {
            tween?.Kill();
            tween =  DOTween.To(setter, startValue, endValue,
                _tweenData.Time).SetEase(_tweenData.Ease);

            return tween;
        }

        private void OnDestroy()
        {
            _leftTween?.Kill();
            _rightTween?.Kill();
            _topTween?.Kill();
            _bottomTween?.Kill();
        }
    }
}

