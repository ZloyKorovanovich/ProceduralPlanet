using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Planet.Configuration
{
    [System.Serializable]
    public class General
    {
        [SerializeField]
        private float _radius = 100.0f;
        [SerializeField]
        private float _height = 50.0f;

        public float Radius => _radius;
        public float Height => _height;
    }
}