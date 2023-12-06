using UnityEngine;

namespace ComputeWorkflow
{
    public struct BufferData
    {
        public ComputeBuffer ComputeBuffer;
        public string Name;

        public BufferData(ComputeBuffer buffer, string name)
        {
            ComputeBuffer = buffer;
            Name = name;
        }
    }
}