using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using DG.Tweening;

namespace DoTweenAnimations.Data
{
    [Serializable]
    public class TweenData
    {
        [SerializeField] private float _time;
        [SerializeField] private Ease _ease;

        public float Time => _time;
        public Ease Ease => _ease;

        #region Constructors
        
        public TweenData()
        {
            _time = 0f;
            _ease = Ease.Linear;
        }

        public TweenData(float time, Ease ease)
        {
            _time = time;
            _ease = ease;
        }

        public TweenData(TweenData data)
        {
            _time = data.Time;
            _ease = data.Ease;
        }

        #endregion
    }
}

