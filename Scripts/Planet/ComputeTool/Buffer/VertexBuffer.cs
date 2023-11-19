using ComputeWorkflow;
using ComputeWorkflow.Handler;
using UnityEngine;

namespace Planet.ComputeTool
{
    public class VertexBuffer : RWBuffer
    {
        private Vector3[] _vertices;

        public VertexBuffer(ComputeConvoy convoy, string name, Vector3[] vertices) 
            : base(convoy, name, vertices.Length, sizeof(float) * 3)
        {
            _vertices = vertices;
            _buffer.SetData(_vertices);
        }

        public override void ReadData()
        {
            _buffer.GetData(_vertices);
        }
    }
}