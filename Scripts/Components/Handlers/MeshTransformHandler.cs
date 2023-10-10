using System;
using Unity.VisualScripting;
using UnityEngine;

namespace ProceduralPlanet.Components.Handlers
{
    public class MeshTransformHandler
    {
        private Parametres.Generation.General _generalParametres;

        private Transform _meshTransform;
        private Transform _planetTransform;

        private Vector3 _start; 
        private Vector3 _endX;
        private Vector3 _endY;
        private Vector3 _peak;

        public MeshTransformHandler(Transform planetTarnsform, Parametres.Generation.General generalParametres, out MeshFilter meshFilter, out MeshRenderer meshRenderer)
        {
            _generalParametres = generalParametres;
            _planetTransform = planetTarnsform;
            CreateMeshTransfrom();
            InitMeshComponents(out meshFilter, out meshRenderer);
            CalculatePeakBounds(1.0f);
        }
        public MeshTransformHandler(Transform planetTarnsform, Parametres.Generation.General generalParametres, float boundScale, out MeshFilter meshFilter, out MeshRenderer meshRenderer)
        {
            _generalParametres = generalParametres;
            _planetTransform = planetTarnsform;
            CreateMeshTransfrom();
            InitMeshComponents(out meshFilter, out meshRenderer);
            CalculatePeakBounds(boundScale);
        }

        public void SetLookAtSpectator(Vector3 spectator)
        {
            _meshTransform.LookAt(spectator);
        }

        public void GetPeakBounds(float displacement, out Vector3 start, out Vector3 endX, out Vector3 endY, out Vector3 peak)
        {
            Vector3 displ = Vector3.forward * displacement;
            start = _planetTransform.InverseTransformPoint(_meshTransform.TransformPoint(_start + displ));
            endX = _planetTransform.InverseTransformPoint(_meshTransform.TransformPoint(_endX + displ));
            endY = _planetTransform.InverseTransformPoint(_meshTransform.TransformPoint(_endY + displ));
            peak = _planetTransform.InverseTransformPoint(_meshTransform.TransformPoint(_peak + displ));
        }
        private void CreateMeshTransfrom()
        {
            _meshTransform = new GameObject().transform;
            _meshTransform.name = _generalParametres.MeshName;
            _meshTransform.position = _planetTransform.position;
            _meshTransform.parent = _planetTransform;
        }

        private void CalculatePeakBounds(float scale)
        {
            _start = -new Vector3(0.5f, 0.5f, 0.0f) * scale;
            _endX = new Vector3(0.5f, -0.5f, 0.0f) * scale;
            _endY = new Vector3(-0.5f, 0.5f, 0.0f) * scale;
            _peak = new Vector3(0.0f, 0.0f, 0.5f) * scale;
        }

        private void InitMeshComponents(out MeshFilter meshFilter, out MeshRenderer meshRenderer)
        {
            meshFilter = _planetTransform.AddComponent<MeshFilter>();
            meshRenderer = _planetTransform.AddComponent<MeshRenderer>();
        }
    }
}

