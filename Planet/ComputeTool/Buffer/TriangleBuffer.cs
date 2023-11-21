using ComputeWorkflow;
using ComputeWorkflow.Handler;
using UnityEngine;

namespace Planet.ComputeTool
{
    public class TriangleBuffer : RWBuffer
    {
        private int[] _triangles;
        public TriangleBuffer(ComputeConvoy convoy, string name, int[] triangles) 
            : base(convoy, name, triangles.Length, sizeof(int) * 6)
        {
            _triangles = triangles;
            _buffer.SetData(_triangles);
        }

        public override void ReadData()
        {
            _buffer.GetData(_triangles);
        }
    }
}