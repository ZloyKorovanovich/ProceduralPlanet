using UnityEngine;

namespace ComputeWorkflow
{
    public static class KernelInfo
    {
        public static void ConfigureDataFromCompute(ComputeShader compute, string kernelName, out KernelData kernelData)
        {
            int id = compute.FindKernel(kernelName);
            compute.GetKernelThreadGroupSizes(id, out uint x, out uint y, out uint z);

            kernelData = new KernelData(compute, id, new ThreadSize((int)x, (int)y, (int)z));
        }
    }
}