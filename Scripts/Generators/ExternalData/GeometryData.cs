using UnityEngine;

namespace ProceduralPlanet.Generators.ExternalData
{
    public struct GeometryData
    {
        public Vector3[] Vertices;
        public Vector2[] UVs;
        public int[] Triangles;

        public GeometryData(Vector3[] vertices, Vector2[] uVs, int[] triangles)
        {
            Vertices = vertices;
            UVs = uVs;
            Triangles = triangles;
        }
    }
}
