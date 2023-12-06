using ComputeWorkflow;
using UnityEngine;

namespace Planet.View
{
    public class GeometryParametres : IParametresModel
    {
        private const string _RESOLUTION = "Resolution";
        private const string _SCALE = "Scale";

        private int _resolution;
        private float _scale;

        public GeometryParametres(int resolution, float scale)
        {
            _resolution = resolution;
            _scale = scale;
        }

        public void AssignData(ComputeShader compute)
        {
            compute.SetInt(_RESOLUTION, _resolution);
            compute.SetFloat(_SCALE, _scale);
        }
    }
}