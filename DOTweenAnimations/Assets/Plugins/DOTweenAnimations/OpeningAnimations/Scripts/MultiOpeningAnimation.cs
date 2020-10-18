using System.Collections;
using System.Collections.Generic;
using DoTweenAnimations.Data;
using DoTweenAnimations.OpeningAnimations;
using UnityEngine;

namespace DoTweenAnimations.OpeningAnimations
{
    public class MultiOpeningAnimation : OpeningAnimation
    {
        [SerializeField] private bool _isComplexData;
        [SerializeField] private List<OpeningAnimation> _openingAnimations = new List<OpeningAnimation>();


        protected override void Awake()
        {
            base.Awake();

            foreach (var openingAnimation in _openingAnimations)
            {
                openingAnimation.SetTweenData(_tweenData);
            }
        }

        protected override void SetOpenState()
        {
            foreach (var openingAnimation in _openingAnimations)
            {
                openingAnimation.Open();
            }
        }

        protected override void SetCloseState()
        {
            foreach (var openingAnimation in _openingAnimations)
            {
                openingAnimation.Close();
            }
        }
    }
}
