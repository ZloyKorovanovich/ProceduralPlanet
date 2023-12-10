using ComputeWorkflow;
using ComputeWorkflow.Stage;
using ConvoyWorkflow;
using GeometryWorkflow;
using System.Collections.Generic;

namespace Planet.Geometry
{
    public class GeometryStageConfigurator : KernelConfigurator
    {
        private GeometryData _geometryData;
        private GeometryBuffers _buffers;
        private GeometryParametres _parametres;

        public GeometryStageConfigurator(KernelData kernelData, ThreadSize threadSize, GeometryBuffers buffers,
            GeometryParametres parametres, ref GeometryData geometryData) : base(kernelData, threadSize)
        {
            _geometryData = geometryData;
            _buffers = buffers;
            _parametres = parametres;
        }

        public override void Configure(ref Stack<IStage> stages)
        {
            stages.Push(new Dispose(_buffers));
            stages.Push(new GetData(ref _geometryData, _buffers));

            base.Configure(ref stages);

            stages.Push(new Assign(_buffers, _kernelData));
            stages.Push(new Assign(_parametres, _kernelData));

            stages.Push(new SetData(ref _geometryData, _buffers));
        }
    }
}