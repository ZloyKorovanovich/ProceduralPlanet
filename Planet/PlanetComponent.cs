using UnityEngine;

namespace Planet
{
    public abstract class PlanetComponent : MonoBehaviour
    {
        [SerializeField]
        protected PlanetData _reference;

        public void Init(PlanetData reference)
        {
            _reference = reference;
        }
    }
}