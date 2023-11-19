using UnityEngine;

namespace ComputeWorkflow.Kernel
{
    public static class KernelInfo
    {
        public static void ReadKernelData(ComputeShader compute, string kernelName, out KernelData kernelData)
        {
            int kernelId = compute.FindKernel(kernelName);
            compute.GetKernelThreadGroupSizes(kernelId, out uint x, out uint y, out uint z);
            kernelData = new KernelData(kernelId, (int)x, (int)y, (int)z);
        }
    }
}