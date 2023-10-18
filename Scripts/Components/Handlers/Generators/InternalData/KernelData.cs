namespace ProceduralPlanet.Generators.InternalData
{
    public struct KernelData
    {
        public int KernelIndex;
        public ThreadSize ThreadScale;

        public KernelData(int kernelIndex, ThreadSize size)
        {
            KernelIndex = kernelIndex;
            ThreadScale = size;
        }
        public KernelData(int kernelIndex, int sizeX, int sizeY, int sizeZ)
        {
            KernelIndex = kernelIndex;
            ThreadScale = new ThreadSize(sizeX, sizeY, sizeZ);
        }

        public KernelData(int kernelIndex, uint sizeX, uint sizeY, uint sizeZ)
        {
            KernelIndex = kernelIndex;
            ThreadScale = new ThreadSize((int)sizeX, (int)sizeY, (int)sizeZ);
        }
    }
}
