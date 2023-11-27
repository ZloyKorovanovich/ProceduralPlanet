using UnityEngine;

namespace ComputeWorkflow
{
    public struct KernelData
    {
        public ComputeShader Compute;
        public int ID;
        public ThreadSize ThreadSize;
    }
}