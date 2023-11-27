using UnityEngine;

namespace ComputeWorkflow
{
    public interface IParametresModel : IModel
    {
        public void AssignData(ComputeShader compute);
    }
}