using UnityEngine;

namespace GeometryWorkflow
{
    public struct GeometryData
    {
        public Vector3[] Vertices;
        public int[] Triangles;
        public Vector2[] UVs;

        public GeometryData(Vector3[] vertices, int[] triangles, Vector2[] uVs)
        {
            Vertices = vertices;
            Triangles = triangles;
            UVs = uVs;
        }
    }
}