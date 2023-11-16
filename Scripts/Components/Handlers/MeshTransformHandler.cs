using Unity.VisualScripting;
using UnityEngine;

namespace ProceduralPlanet.Components.Handlers
{
    public class MeshTransformHandler
    {
        private Parametres.Generation.General _generalParametres;

        private Transform _meshTransform;
        private Transform _planetTransform;

        public MeshTransformHandler(Transform planetTarnsform, Parametres.Generation.General generalParametres, out MeshFilter meshFilter, out MeshRenderer meshRenderer)
        {
            _generalParametres = generalParametres;
            _planetTransform = planetTarnsform;
            CreateMeshTransfrom();
            InitMeshComponents(out meshFilter, out meshRenderer);
        }

        public void SetLookAtSpectator(Vector3 spectator)
        {
            Vector3 lookDirection = Vector3.Normalize(spectator - _planetTransform.position);
            _meshTransform.rotation = Quaternion.LookRotation(lookDirection);
        }

        public void GetRotationMatrix(out Matrix4x4 rotationMatrix)
        {
            rotationMatrix = Matrix4x4.Rotate(_meshTransform.localRotation);
        }
        private void CreateMeshTransfrom()
        {
            _meshTransform = new GameObject().transform;
            _meshTransform.name = _generalParametres.MeshName;
            _meshTransform.position = _planetTransform.position;
            _meshTransform.parent = _planetTransform;
            _meshTransform.localScale = Vector3.one * (_generalParametres.Radius + _generalParametres.Height);
        }

        private void InitMeshComponents(out MeshFilter meshFilter, out MeshRenderer meshRenderer)
        {
            meshFilter = _meshTransform.AddComponent<MeshFilter>();
            meshRenderer = _meshTransform.AddComponent<MeshRenderer>();
        }
    }
}

