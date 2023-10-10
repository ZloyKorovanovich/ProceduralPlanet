using UnityEngine;

namespace ProceduralPlanet.Parametres.Generation
{
    [System.Serializable]
    public class General
    {
        [SerializeField]
        private float _radius = 30.0f;
        [SerializeField]
        private float _height = 10.0f;
        [SerializeField]
        private string _meshName = "Mesh";

        public float Radius => _radius;
        public float Height => _height;
        public string MeshName => _meshName;
    }
}
