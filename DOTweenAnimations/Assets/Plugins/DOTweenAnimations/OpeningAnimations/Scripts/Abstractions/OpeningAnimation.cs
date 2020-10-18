using System.Collections;
using System.Collections.Generic;
using ConditionalHideAttribute;
using DG.Tweening;
using DoTweenAnimations.Data;
using UnityEngine;

namespace DoTweenAnimations.OpeningAnimations
{
    public abstract class OpeningAnimation : MonoBehaviour
    {
        [SerializeField] private bool _isClosedByStandart = true;
        [SerializeField] private bool _isDataInternal = true;
        [ConditionalHideAttribute.ConditionalHide("_isDataInternal", true)][Space]
        [SerializeField] protected TweenData _tweenData;

        protected Tween _tween;
        private bool _isClosed;

        protected virtual void Awake()
        {
            _isClosed = !_isClosedByStandart;
            SwitchState();
        }

        public void Open()
        {
            _isClosed = false;
            SetOpenState();
        }

        public  void Close()
        {
            _isClosed = true;
            SetCloseState();
        }

        public void SwitchState()
        {
            if (_isClosed)
            {
                Open();
            }
            else
            {
                Close();
            }
        }

        protected abstract void SetOpenState();
        protected abstract void SetCloseState();

        public virtual void SetTweenData(TweenData tweenData)
        {
            _tweenData = tweenData;
        }

        protected virtual void OnDestroy()
        {
            _tween?.Kill();
        }
    }
}

