using ComputeWorkflow;
using GeometryWorkflow;

namespace Planet.View
{
    public class PlanetGeometry
    {
        GeometryModel _model;

        public void ConstructModel(KernelData kernelData, ThreadSize dispatchSize, 
            GeometryData geometryData, int resolution, float scale)
        {
            GeometryModelBuilder modelBuilder = new GeometryModelBuilder();

            ConstructKernelModel(modelBuilder, kernelData, dispatchSize);
            ConstructBufferModel(modelBuilder, geometryData);
            ConstructParametresModel(modelBuilder, resolution, scale);

            modelBuilder.ConstructGeometryModel(out _model);
        }

        private void ConstructParametresModel(GeometryModelBuilder modelBuilder, int resolution, float scale)
        {
            modelBuilder.ConstructParametresModel(resolution, scale);
        }

        private void ConstructKernelModel(GeometryModelBuilder modelBuilder, KernelData kernelData, ThreadSize dispatchSize)
        {
            modelBuilder.ConstructKernelModel(kernelData, dispatchSize);
        }

        private void ConstructBufferModel(GeometryModelBuilder modelBuilder, GeometryData geometryData)
        {
            GeometryBufferCreator.CreateVertexBuffer(geometryData.Vertices.Length, out BufferData vertexBuffer);
            GeometryBufferCreator.CreateTriangleBuffer(geometryData.Triangles.Length, out BufferData triangleBuffer);
            GeometryBufferCreator.CreateUVBuffer(geometryData.UVs.Length, out BufferData uVBuffer);

            modelBuilder.ConstructBufferModel(vertexBuffer, triangleBuffer, uVBuffer);
        }
    }
}