using UnityEngine;

namespace Planet.Model
{
    [CreateAssetMenu(fileName = "NewPlanet", menuName = "Modules/PlanetData")]
    public class PlanetData : ScriptableObject
    {
        [SerializeField]
        private General _general;
    }
}