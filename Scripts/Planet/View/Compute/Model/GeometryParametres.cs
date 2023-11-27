using ComputeWorkflow;
using UnityEngine;

namespace Planet.View
{
    public class GeometryParametres : IParametresModel
    {
        private int _resolution;
        private float _scale;

        private string _nameResolution;
        private string _nameScale;

        public GeometryParametres(int resolution, int scale, string nameResolution, string nameScale)
        {
            _resolution = resolution;
            _scale = scale;

            _nameResolution = nameResolution;
            _nameScale = nameScale;
        }

        public void AssignData(ComputeShader compute)
        {
            compute.SetInt(_nameResolution, _resolution);
            compute.SetFloat(_nameScale, _scale);
        }
    }
}