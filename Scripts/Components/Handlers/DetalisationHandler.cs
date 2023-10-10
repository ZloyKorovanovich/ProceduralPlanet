using UnityEngine;

namespace ProceduralPlanet.Components.Handlers
{
    public class DetalisationHandler
    {
        private ProceduralPlanet.Parametres.Visualisation.Detalisation _parametres;
        private ProceduralPlanet.Parametres.Generation.General _generalParametres;

        private float _density;

        public float Density => _density;

        public DetalisationHandler(ProceduralPlanet.Parametres.Visualisation.Detalisation parametres, Parametres.Generation.General generalParametres)
        {
            _parametres = parametres;
            _generalParametres = generalParametres;
        }

        public void CalculateDensity(Vector3 target, Vector3 spectator)
        {
            float distanceM = Vector3.SqrMagnitude(target - spectator);
            float distanceMScaled = (distanceM) / (_parametres.MaxDistanceMagnitude * _generalParametres.Radius * _generalParametres.Radius);

            float radiusMScaled = 1.0f / _parametres.MaxDistanceMagnitude;

            distanceMScaled -= radiusMScaled;
            distanceMScaled = Mathf.Clamp(distanceMScaled, 0.0f, 1.0f);

            _density = 1.0f - _parametres.DensityFunction.Evaluate(distanceMScaled);
        }
    }
}
