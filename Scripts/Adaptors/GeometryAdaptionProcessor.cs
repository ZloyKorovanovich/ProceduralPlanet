using UnityEngine;

namespace ProceduralPlanet.Adaptors
{
    public static class GeometryAdaptionProcessor
    {
        public static Generators.PeakGeometry FillPeakGeometry(Parametres.Visualisation.Geometry parametres, Parametres.CalculatingComponents.Compute calculting)
        {
            return new Generators.PeakGeometry(parametres.Resolution, calculting.ComputeShader, calculting.KernelName);
        }
    }
}
