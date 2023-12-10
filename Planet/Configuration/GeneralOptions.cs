using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Planet.Configuration
{
    [System.Serializable]
    public class GeneralOptions
    {
        [SerializeField]
        private float _radius;
        [SerializeField]
        private float _height;

        public float Radius => _radius;
        public float Height => _height;
        public float Scale => _radius + _height;
    }
}