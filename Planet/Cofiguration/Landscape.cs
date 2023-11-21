using UnityEngine;

namespace Planet.Configuration
{
    [System.Serializable]
    public class Landscape
    {
        [SerializeField]
        private int _octaves;
        [SerializeField]
        private float _scale;
        [SerializeField]
        private float _lacunarity;
        [SerializeField]
        private float _persistance;
        [SerializeField]
        private float _seed;


        public int Octaves => _octaves;
        public float Scale => _scale;
        public float Lacunarity => _lacunarity;
        public float Prsistance => _persistance;
        public float Seed => _seed;
    }
}