using ComputeWorkflow;
using ComputeWorkflow.Stage;
using ConvoyWorkflow;
using System.Collections.Generic;

namespace Planet.View
{
    public class GeometryAssignConfigurator : IStageConfigurator
    {
        private KernelModel _kernelModel;
        private GeometryBuffer _buffer;
        private GeometryParametres _parametres;

        public GeometryAssignConfigurator(GeometryBuffer buffer, GeometryParametres parametres, KernelModel kernelModel)
        {
            _kernelModel = kernelModel;
            _buffer = buffer;
            _parametres = parametres;
        }

        public void Configure(ref Stack<IStage> stages)
        {
            stages.Push(new AssignBuffer(_buffer.VertexBuffer, _kernelModel.KernelData));
            stages.Push(new AssignBuffer(_buffer.TriangleBuffer, _kernelModel.KernelData));
            stages.Push(new AssignBuffer(_buffer.UVBuffer, _kernelModel.KernelData));

            stages.Push(new AssignParametres(_parametres, _kernelModel.KernelData));
        }
    }
}