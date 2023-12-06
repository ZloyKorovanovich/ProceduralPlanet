using UnityEngine;

namespace Planet.Model
{
    [System.Serializable]
    public class General
    {
        [SerializeField]
        private float _radius;
        [SerializeField]
        private float _height;

        public float Radius => _radius;
        public float Height => _height;
    }
}