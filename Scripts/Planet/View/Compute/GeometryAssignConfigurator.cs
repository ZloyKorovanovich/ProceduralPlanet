using ComputeWorkflow;
using ComputeWorkflow.Stage;
using ConvoyWorkflow;
using System.Collections.Generic;

namespace Planet.View
{
    public class GeometryAssignConfigurator : IStageConfigurator
    {
        private KernelData _kernelData;
        private GeometryBuffer _buffer;
        private GeometryParametres _parametres;

        public GeometryAssignConfigurator(GeometryBuffer buffer, KernelData kernelData)
        {
            _buffer = buffer;
            _kernelData = kernelData;
        }

        public void Configure(ref Stack<IStage> stages)
        {
            stages.Push(new AssignBuffer(_buffer.VertexBuffer, _kernelData));
            stages.Push(new AssignBuffer(_buffer.TriangleBuffer, _kernelData));
            stages.Push(new AssignBuffer(_buffer.UVBuffer, _kernelData));

            stages.Push(new AssignParametres(_parametres, _kernelData));
        }
    }
}