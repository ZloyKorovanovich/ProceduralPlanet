using UnityEngine;

namespace ProceduralPlanet.Parametres.Visualisation
{
    [System.Serializable]
    public class MaterialParametres
    {
        [SerializeField]
        private string _radiusName = "Radius";
        [SerializeField]
        private string _heightName = "Height";
        [SerializeField]
        private string _heightMapName = "HeightMap";

        [SerializeField]
        private Shader _shaderReference;

        public string NameRadius => _radiusName;
        public string NameHeight => _heightName;
        public string NameHeightMap => _heightMapName;

        public Shader ShaderReference => _shaderReference;
    }
}
