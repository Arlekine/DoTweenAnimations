using DG.Tweening;
using UnityEngine;

namespace DoTweenAnimations.Data
{
    public class Vector2TweenData : TweenData
    {
        [SerializeField] private Vector2 _vector;

        public Vector2 Vector => _vector;

        #region Constructors

        public Vector2TweenData() : base()
        {
            _vector = Vector2.zero;
        }

        public Vector2TweenData(float time, Ease ease, Vector2 vector) : base(time, ease)
        {
            _vector = vector;
        }

        public Vector2TweenData(TweenData data, Vector2 vector) : base(data)
        {
            _vector = vector;
        }

        #endregion
    }
}