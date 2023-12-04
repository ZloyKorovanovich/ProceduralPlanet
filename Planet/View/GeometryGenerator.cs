using GeneratorWorkflow;
using System;

namespace Planet.View
{
    public class GeometryGenerator : Generator
    {
        private ComputeGenerator _generator;

        public GeometryGenerator(GeometryConfigurator configurator)
        {
            _generator = new ComputeGenerator(configurator);
        }

        public override void Generate()
        {
            _generator.Generate();
            base.Generate();
        }
    }
}