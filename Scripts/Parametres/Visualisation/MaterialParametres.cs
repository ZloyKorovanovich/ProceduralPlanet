using UnityEngine;

namespace ProceduralPlanet.Parametres.Visualisation
{
    [System.Serializable]
    public class MaterialParametres
    {
        [SerializeField]
        private string _radiusName = "_Radius";
        [SerializeField]
        private string _heightName = "_Height";
        [SerializeField]
        private string _heightMapName = "_HeightMap";
        [SerializeField]
        private string _densityName = "_Density";
        [SerializeField]
        private Shader _shaderReference;

        public string NameRadius => _radiusName;
        public string NameHeight => _heightName;
        public string NameHeightMap => _heightMapName;
        public string NameDensity => _densityName;

        public Shader ShaderReference => _shaderReference;
    }
}
