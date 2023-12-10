using ComputeWorkflow;
using Planet.Configuration;

namespace GeneratorWorkflow
{
    public abstract class ComputeGenerator : Generator
    {
        protected ComputeOptions _computeOptions;

        public ComputeGenerator(ComputeOptions computeOptions)
        {
            _computeOptions = computeOptions;
        }

        protected void ConfigureThreadSize(int resolution, out ThreadSize threadSize)
        {
            threadSize = new ThreadSize(resolution, resolution, 1);
        }

        protected void ConfigureKernelData(ComputeOptions parametres, out KernelData kernelData)
        {
            KernelInfo.ConfigureDataFromCompute(parametres.ComputeShader, parametres.KernelName, out kernelData);
        }
    }
}