using UnityEngine;

namespace ProceduralPlanet.Components.Handlers
{
    public class MaterialHandler
    { 
        private Parametres.Visualisation.MaterialParametres _materialParametres;
        private Parametres.Generation.General _generalParametres;
        private Material _material;

        public MaterialHandler(Parametres.Visualisation.MaterialParametres materialParametres)
        {
            _materialParametres = materialParametres;
            _material = new Material(_materialParametres.ShaderReference);
            SetStaticShaderParametres();
        }

        private void SetStaticShaderParametres()
        {
            float height = Mathf.Clamp(_generalParametres.Height / _generalParametres.Radius, 0.0f, 1.0f);
            _material.SetFloat(_materialParametres.NameRadius, 1.0f - height);
            _material.SetFloat(_materialParametres.NameHeight, height);
        }

        public void SetDynamicShaderParametres(RenderTexture heightMap, float density)
        {
            _material.SetTexture(_materialParametres.NameHeightMap, heightMap);
            _material.SetFloat(_materialParametres.NameDensity, density);
        }

        public void ApplyMaterial(ref MeshRenderer meshRenderer)
        {
            meshRenderer.material = _material;
        }
    }
}