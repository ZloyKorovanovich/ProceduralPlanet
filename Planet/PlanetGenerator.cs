using GeneratorWorkflow;
using Planet.Configuration;

namespace Planet
{
    public abstract class PlanetGenerator : ComputeGenerator
    {
        protected GeneralOptions _generalOptions;

        public PlanetGenerator(ComputeOptions computeOptions, GeneralOptions generalOptions) : base(computeOptions)
        {
            _generalOptions = generalOptions;
        }
    }
}