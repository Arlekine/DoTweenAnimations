using System;
using System.Collections;
using System.Collections.Generic;
using DoTweenAnimations.Data;
using DoTweenAnimations.OpeningAnimations;
using DoTweenAnimations.RectAnimations;
using UnityEngine;

namespace DoTweenAnimations.OpeningAnimations
{
    public class FullRectOpeningAnimation : OpeningAnimation
    {
        #region AuxilaryClasses

        [Serializable]
        private class FullRectMoveData
        {
            #region Fields

            [SerializeField] private bool _changeLeft;
            [ConditionalHideAttribute.ConditionalHide("_changeLeft", true)]
            [SerializeField] private float _leftValue;

            [Space]
            [SerializeField] private bool _changeRight;
            [ConditionalHideAttribute.ConditionalHide("_changeRight", true)] 
            [SerializeField] private float _rightValue;
            
            [Space]
            [SerializeField] private bool _changeTop;
            [ConditionalHideAttribute.ConditionalHide("_changeTop", true)] 
            [SerializeField] private float _topValue;
            
            [Space]
            [SerializeField] private bool _changeBottom;
            [ConditionalHideAttribute.ConditionalHide("_changeBottom", true)] 
            [SerializeField] private float _bottomValue;

            #endregion

            #region Properties
            public bool ChangeLeft => _changeLeft;

            public float LeftValue => _leftValue;

            public bool ChangeRight => _changeRight;

            public float RightValue => _rightValue;

            public bool ChangeTop => _changeTop;

            public float TopValue => _topValue;

            public bool ChangeBottom => _changeBottom;

            public float BottomValue => _bottomValue;

            #endregion
            
        }

        #endregion

        [SerializeField] private FullRectAnimation _fullRectAnimation;
        [SerializeField] private bool _isThisTweenDataUsage;

        [Header("Data")] 
        [SerializeField] private FullRectMoveData _openMoveData;
        [SerializeField] private FullRectMoveData _closeMoveData;

        protected override void Awake()
        {
            base.Awake();

            if (_isThisTweenDataUsage)
            {
                _fullRectAnimation.SetData(_tweenData);
            }
        }

        protected override void SetOpenState()
        {
            AnimationFullRect(_openMoveData);
        }

        protected override void SetCloseState()
        {
            AnimationFullRect(_closeMoveData);
        }

        private void AnimationFullRect(FullRectMoveData data)
        {
            if (data.ChangeLeft)
                _fullRectAnimation.SetLeft(data.LeftValue);
            
            if (data.ChangeRight)
                _fullRectAnimation.SetRight(data.RightValue);
            
            if (data.ChangeTop)
                _fullRectAnimation.SetTop(data.TopValue);
            
            if (data.ChangeBottom)
                _fullRectAnimation.SetBottom(data.BottomValue);
        }

        public override void SetTweenData(TweenData tweenData)
        {
            base.SetTweenData(tweenData);

            if (_isThisTweenDataUsage)
            {
                _fullRectAnimation.SetData(_tweenData);
            }
        }
    }
}


