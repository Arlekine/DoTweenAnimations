using DG.Tweening;
using UnityEngine;

namespace DoTweenAnimations.Data
{
    public class Vector3TweenData : TweenData
    {
        [SerializeField] private Vector3 _vector;

        public Vector3 Vector => _vector;

        #region Constructors

        public Vector3TweenData() : base()
        {
            _vector = Vector3.zero;
        }

        public Vector3TweenData(float time, Ease ease, Vector3 vector) : base(time, ease)
        {
            _vector = vector;
        }

        public Vector3TweenData(TweenData data, Vector3 vector) : base(data)
        {
            _vector = vector;
        }

        #endregion
    }
}