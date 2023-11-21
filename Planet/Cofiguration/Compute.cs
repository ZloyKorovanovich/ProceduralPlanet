using UnityEngine;

namespace Planet.Configuration
{
    [System.Serializable]
    public class Compute
    {
        [SerializeField]
        private ComputeShader _shader;
        [SerializeField]
        private string _kernelName;

        public ComputeShader Shader => _shader;
        public string KernelName => _kernelName;
    }
}