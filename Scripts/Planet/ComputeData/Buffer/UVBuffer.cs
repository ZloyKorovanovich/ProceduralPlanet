using ComputeWorkflow;
using ComputeWorkflow.Handler;
using UnityEngine;

namespace Planet.ComputeData
{
    public class UVBuffer : RWBuffer
    {
        private Vector2[] _uVs;

        public UVBuffer(ComputeConvoy convoy, string name, Vector2[] uVs) 
            : base(convoy, name, uVs.Length, sizeof(float) * 2)
        {
            _uVs = uVs;
            _buffer.SetData(_uVs);
        }

        public override void ReadData()
        {
            _buffer.GetData(_uVs);
        }
    }
}