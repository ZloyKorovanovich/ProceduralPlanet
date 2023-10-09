using UnityEngine;

namespace ProceduralPlanet.Generators.ExternalData
{
    public static class GeometryProcessor
    {
        public static void ConvertDataToMesh(GeometryData data, out Mesh mesh)
        {
            mesh = new Mesh();
            mesh.SetVertices(data.Vertices);
            mesh.SetTriangles(data.Triangles, 0);
            mesh.SetUVs(0, data.UVs);
            mesh.RecalculateNormals();
            mesh.RecalculateTangents();
            mesh.bounds = new Bounds(Vector3.zero, Vector3.one);
        }
        public static void ConvertDataToMesh(GeometryData data, float scale, out Mesh mesh)
        {
            mesh = new Mesh();
            mesh.SetVertices(data.Vertices);
            mesh.SetTriangles(data.Triangles, 0);
            mesh.SetUVs(0, data.UVs);
            mesh.RecalculateNormals();
            mesh.RecalculateTangents();
            mesh.bounds = new Bounds(Vector3.zero, Vector3.one * scale);
        }
    }
}
