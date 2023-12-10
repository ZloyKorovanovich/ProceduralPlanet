using Planet.Configuration;
using UnityEngine;

namespace Planet
{
    [CreateAssetMenu(fileName = "new Planet", menuName = "Modules/Planet")]
    public class PlanetData : ScriptableObject
    {
        [SerializeField]
        private GeneralOptions _general;
        [SerializeField]
        private GeometryOptions _geometry;

        public GeneralOptions General => _general;
        public GeometryOptions Geometry => _geometry;
    }
}