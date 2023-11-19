using ComputeWorkflow.Handler;
using UnityEngine;

namespace Planet.ComputeTool
{
    public class UVDynamicParametres : Parametres
    {
        private const string _ROTATION_MATRIX = "RotationMatrix";

        private Matrix4x4 _rotationMatrix;

        public UVDynamicParametres(Matrix4x4 rotationMatrix)
        {
            _rotationMatrix = rotationMatrix;
        }

        public void SetRotationMatrix(Matrix4x4 rotationMatrix)
        {
            _rotationMatrix = rotationMatrix;
        }

        public override void ToCompute()
        {
            _convoy.Compute.SetMatrix(_ROTATION_MATRIX, _rotationMatrix);
        }
    }
}