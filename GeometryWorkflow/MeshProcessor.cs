using UnityEngine;

namespace GeometryWorkflow
{
    public static class GeometryProcessor
    {
        public static void CreateMesh(GeometryData data, out Mesh mesh)
        {
            mesh = new Mesh();

            mesh.SetVertices(data.Vertices);
            mesh.SetTriangles(data.Triangles, 0);
            mesh.SetUVs(0, data.UVs);
        }

        public static void DataToMesh(GeometryData data, ref Mesh mesh)
        {
            mesh.SetVertices(data.Vertices);
            mesh.SetTriangles(data.Triangles, 0);
            mesh.SetUVs(0, data.UVs);
        }
    }
}