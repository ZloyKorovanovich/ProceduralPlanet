using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProceduralPlanet.Parametres.Visualisation
{
    [System.Serializable]
    public class Detalisation
    {
        [SerializeField]
        private float _maxDistance = 1.0f;
        [SerializeField]
        private float _detalisationLevel = 1.0f;
        [SerializeField]
        private AnimationCurve _densityFunction;

        public float MaxDistance => _maxDistance;

        public float MaxDistanceMagnitude => _maxDistance * _maxDistance;
        public float DetalisationLevel => _detalisationLevel;
        public AnimationCurve DensityFunction => _densityFunction;
    }
}