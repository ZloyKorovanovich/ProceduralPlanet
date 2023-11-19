using ComputeWorkflow;
using ComputeWorkflow.Handler;
using ComputeWorkflow.Report;
using GeometryWorkflow;
using UnityEngine;

namespace Planet.ComputeTool
{
    public class GeometryConvoy : ReportableConvoy
    {
        private const string _NAME_VERTEX_BUFFER = "Vertices";
        private const string _NAME_TRIANGLE_BUFFER = "Triangles";
        private const string _NAME_UV_BUFFER = "UVs";

        private VertexBuffer _vertexBuffer;
        private TriangleBuffer _triangleBuffer;
        private UVBuffer _uVBuffer;

        private GeometryParametres _parametres;
        private GeometryData _geometryData;

        public GeometryConvoy(ComputeShader compute, string kernelName, GeometryData geometryData, GeometryParametres parametres, IConvoyReport report)
            : base(compute, kernelName, report)
        {
            _geometryData = geometryData;
            _parametres = parametres;
        }

        private void DisposeBuffer(ShaderBuffer buffer)
        {
            if(buffer != null)
                buffer.Dispose();
        }

        public void ReadData()
        {
            _vertexBuffer.ReadData();
            _triangleBuffer.ReadData();
            _uVBuffer.ReadData();
        }

        public override void End()
        {
            base.End();
            DisposeBuffer(_vertexBuffer);
            DisposeBuffer(_triangleBuffer);
            DisposeBuffer(_uVBuffer);
        }

        protected override void InitDispatcher()
        {
            _dispatcher = new DisposableDispatcher(this, _kernelData);
        }

        protected override void BuffersToCompute()
        {
            _vertexBuffer.ToCompute();
            _triangleBuffer.ToCompute();
            _uVBuffer.ToCompute();
        }

        protected override void InitBuffers()
        {
            _vertexBuffer = new VertexBuffer(this, _NAME_VERTEX_BUFFER, _geometryData.Vertices);
            _triangleBuffer = new TriangleBuffer(this, _NAME_TRIANGLE_BUFFER, _geometryData.Triangles);
            _uVBuffer = new UVBuffer(this, _NAME_UV_BUFFER, _geometryData.UVs);
        }

        protected override void ParametresToCompute()
        {
            _parametres.ToCompute();
        }
    }
}