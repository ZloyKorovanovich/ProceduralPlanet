using UnityEngine;

namespace ProceduralPlanet.Parametres.Generation
{
    [System.Serializable]
    public class Biom
    {
        [SerializeField]
        protected float _scale = 4.0f;

        [Header("Octaves")]
        [SerializeField, Range(1, 32)]
        protected int _octaves = 10;
        [SerializeField, Range(1.0f, 2.0f)]
        protected float _lacunarity = 1.3f;
        [SerializeField, Range(0.0f, 1.0f)]
        protected float _persistance = 0.3f;

        public float Scale => _scale;
        public int Octaves => _octaves;
        public float Lacunarity => _lacunarity;
        public float Persistance => _persistance;
    }
}
