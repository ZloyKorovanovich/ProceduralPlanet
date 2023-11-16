using System.Collections.Generic;
using UnityEngine;

namespace ProceduralPlanet.Parametres.Generation
{
    [System.Serializable]
    public class Landscape
    {
        [SerializeField]
        private float _seed = 0.0f;

        public float Seed => _seed;
    }
}
