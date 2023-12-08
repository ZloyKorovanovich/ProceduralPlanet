using UnityEngine;

namespace ComputeWorkflow
{
    public struct KernelData
    {
        public ComputeShader Compute;
        public int ID;
        public ThreadSize ThreadSize;

        public KernelData(ComputeShader compute, int id, ThreadSize threadSize)
        {
            Compute = compute;
            ID = id;
            ThreadSize = threadSize;
        }
    }
}