using UnityEngine;

namespace GeometryWorkflow
{
    public static class GeometryConverter
    {
        public static void ConvertDataToMesh(GeometryData geometryData, out Mesh mesh)
        {
            mesh = new Mesh();

            mesh.SetVertices(geometryData.Vertices);
            mesh.SetTriangles(geometryData.Triangles, 0);
            mesh.SetUVs(0, geometryData.UVs);
        }

        public static void ConvertDataToMesh(GeometryData geometryData, float boundScale, out Mesh mesh)
        {
            mesh = new Mesh();

            mesh.SetVertices(geometryData.Vertices);
            mesh.SetTriangles(geometryData.Triangles, 0);
            mesh.SetUVs(0, geometryData.UVs);

            mesh.bounds = new Bounds(Vector3.zero, Vector3.one * boundScale);
        }

        public static void ConvertMeshToData(Mesh mesh, out GeometryData geometryData)
        {
            geometryData = new GeometryData(mesh.vertices, mesh.triangles, mesh.uv);
        }
    }
}