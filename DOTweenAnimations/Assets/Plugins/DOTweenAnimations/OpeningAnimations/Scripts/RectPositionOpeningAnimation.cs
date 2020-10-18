using DG.Tweening;
using DoTweenAnimations.Data;
using DoTweenAnimations.RectAnimations;
using UnityEngine;

namespace DoTweenAnimations.OpeningAnimations
{
    public class RectPositionOpeningAnimation : OpeningAnimation
    {
        [SerializeField] private RectTransform _rectTransform;

        [Header("Data")] 
        [SerializeField] private Vector2 _openState;
        [SerializeField] private Vector2 _closeState;

        protected override void SetOpenState()
        {
            MoveRectToPosition(_openState);
        }

        protected override void SetCloseState()
        {
            MoveRectToPosition(_closeState);
        }

        public void MoveRectToPosition(Vector3 position)
        {
            _tween?.Kill();
            _tween = _rectTransform.DOAnchorPos(position, _tweenData.Time).SetEase(_tweenData.Ease);
        }
    }
}