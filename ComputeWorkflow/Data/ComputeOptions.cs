using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Planet.Configuration
{
    [System.Serializable]
    public class ComputeOptions
    {
        [SerializeField]
        private ComputeShader _computeShader;
        [SerializeField]
        private string _kernelName;

        public ComputeShader ComputeShader => _computeShader;
        public string KernelName => _kernelName;
    }
}

