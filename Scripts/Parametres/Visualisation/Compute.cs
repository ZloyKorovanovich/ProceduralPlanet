using UnityEngine;

namespace ProceduralPlanet.Parametres
{
    namespace CalculatingComponents
    {
        [System.Serializable]
        public class Compute
        {
            [SerializeField]
            private ComputeShader _compute;
            [SerializeField]
            private string _kernelName;

            public ComputeShader ComputeShader => _compute;
            public string KernelName => _kernelName;
        }
    }
}
