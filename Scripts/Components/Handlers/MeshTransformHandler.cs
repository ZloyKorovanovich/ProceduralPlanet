using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ProceduralPlanet.Components.Handlers
{
    public class MeshTransformHandler
    {
        private Transform _meshTransform;
        private Transform _planetTransform;

        private Vector3 _start; 
        private Vector3 _endX;
        private Vector3 _endY;
        private Vector3 _peak;

        private float _displacement;

        public MeshTransformHandler(Transform meshTransform, Transform planetTarnsform)
        {
            _meshTransform = meshTransform;
            _planetTransform = planetTarnsform;
            CalculatePeakBounds(1.0f);
        }
        public MeshTransformHandler(Transform meshTransform, Transform planetTarnsform, float boundScale)
        {
            _meshTransform = meshTransform;
            _planetTransform = planetTarnsform;
            CalculatePeakBounds(boundScale);
        }
        public void SetLookAtSpectator(Vector3 spectator)
        {
            _meshTransform.LookAt(spectator);
        }

        public void GetPeakBounds(out Vector3 start, out Vector3 endX, out Vector3 endY, out Vector3 peak)
        {
            Vector3 displ = Vector3.forward * _displacement;
            start = _planetTransform.InverseTransformPoint(_meshTransform.TransformPoint(_start + displ));
            endX = _planetTransform.InverseTransformPoint(_meshTransform.TransformPoint(_endX + displ));
            endY = _planetTransform.InverseTransformPoint(_meshTransform.TransformPoint(_endY + displ));
            peak = _planetTransform.InverseTransformPoint(_meshTransform.TransformPoint(_peak + displ));
        }

        private void CalculatePeakBounds(float scale)
        {
            _start = -new Vector3(0.5f, 0.5f, 0.0f) * scale;
            _endX = new Vector3(0.5f, -0.5f, 0.0f) * scale;
            _endY = new Vector3(-0.5f, 0.5f, 0.0f) * scale;
            _peak = new Vector3(0.0f, 0.0f, 0.5f) * scale;
        }
    }
}

