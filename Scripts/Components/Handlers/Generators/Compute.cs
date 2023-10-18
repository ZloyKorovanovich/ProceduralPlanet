using ProceduralPlanet.Generators.InternalData;
using UnityEngine;

namespace ProceduralPlanet.Generators
{
    public class Compute
    {
        protected ComputeShader _compute;
        protected KernelData _kernelData;

        public ComputeShader Shader => _compute;
        public KernelData KernelData => _kernelData;

        public Compute(ComputeShader compute, int kernelId)
        {
            _compute = compute;
            KernelProcessor.ReadKernelData(kernelId, _compute, out _kernelData);
        }
        public Compute(ComputeShader compute, string kernelName)
        {
            _compute = compute;
            KernelProcessor.ReadKernelData(kernelName, _compute, out _kernelData);
        }
        public Compute(ComputeShader compute, KernelData kernelData)
        {
            _compute = compute;
            _kernelData = kernelData;
        }

        public void Dispatch(int resolutionX, int resolutionY, int resolutionZ)
        {
            _compute.Dispatch(_kernelData.KernelIndex, resolutionX / _kernelData.ThreadScale.X, resolutionY / _kernelData.ThreadScale.Y, resolutionZ / _kernelData.ThreadScale.Z);
        }
    }
}
