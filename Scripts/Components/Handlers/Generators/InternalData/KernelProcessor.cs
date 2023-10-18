using UnityEngine;

namespace ProceduralPlanet.Generators.InternalData
{
    public static class KernelProcessor
    {
        public static void ReadKernelData(int kernelIndex, ComputeShader compute, out KernelData kernelData)
        {
            uint x, y, z;
            compute.GetKernelThreadGroupSizes(kernelIndex, out x, out y, out z);
            kernelData = new KernelData(kernelIndex, x, y, z);
        }

        public static void ReadKernelData(string kernelName, ComputeShader compute, out KernelData kernelData)
        {
            int kernelIndex = compute.FindKernel(kernelName);
            uint x, y, z;
            compute.GetKernelThreadGroupSizes(kernelIndex, out x, out y, out z);
            kernelData = new KernelData(kernelIndex, x, y, z);
        }
    }
}
