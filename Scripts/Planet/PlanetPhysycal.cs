using UnityEngine;

namespace Planet
{
    [DisallowMultipleComponent]
    public class PlanetPhysycal : MonoBehaviour
    {
        [SerializeField]
        private PlanetData _reference;

        public void Init(PlanetData reference)
        {
            _reference = reference;
        }
    }
}