using UnityEngine;

namespace ProceduralPlanet.Components
{
    [CreateAssetMenu(fileName = "New Planet", menuName = "Planet")]
    public class Planet : ScriptableObject
    {
        [SerializeField]
        private Parametres.PlanetConfiguration _configuartion;

        public Parametres.PlanetConfiguration Configuration => _configuartion;
    }
}