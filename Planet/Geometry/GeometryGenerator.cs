using ComputeWorkflow;
using ConvoyWorkflow;
using GeometryWorkflow;
using Planet.Configuration;
using System.Collections.Generic;
using UnityEngine;

namespace Planet.Geometry
{
    public class GeometryGenerator : PlanetGenerator
    {
        private GeometryOptions _geometryOptions;
        private GeometryData _geometryData;

        public GeometryData GeometryData => _geometryData;

        public GeometryGenerator(GeometryOptions geometryOptions, GeneralOptions generalOptions)
            : base(geometryOptions.Compute, generalOptions)
        {
            _geometryOptions = geometryOptions;
        }

        public override void Generate()
        {
            GenerateGeometry(out _geometryData);
            base.Generate();
        }

        private void GenerateGeometry(out GeometryData geometryData)
        {
            ConfigureGeometryData(_geometryOptions, out geometryData);
            var assignConfigurator = new GeometryAssignableConfigurator(geometryData, _geometryOptions.Resolution, _generalOptions.Radius);

            assignConfigurator.Configure(out var buffers, out var parametres);

            ConfigureKernelData(_geometryOptions.Compute, out var kernelData);
            ConfigureThreadSize(_geometryOptions.Resolution, out var threadSize);

            ConfigureStages(ref geometryData, out var convoyStages);
            RunConvoy(convoyStages);


            void ConfigureStages(ref GeometryData geometryData, out Stack<IStage> stages)
            {
                stages = new Stack<IStage>();
                var stageConfigurator = new GeometryStageConfigurator(kernelData, threadSize, buffers, parametres, ref geometryData);
                stageConfigurator.Configure(ref stages);
            }

            void RunConvoy(Stack<IStage> stages)
            {
                ServiceLocator.GetService<ConvoyManager>().ConfigureConvoy(stages, out var convoy);
                while (convoy.CompleteStage()) ;
            }
        }

        private void ConfigureGeometryData(GeometryOptions parametres, out GeometryData geometry)
        {
            var verts = new Vector3[parametres.Resolution * parametres.Resolution];
            var tris = new int[(parametres.Resolution - 1) * (parametres.Resolution - 1) * 6];
            var uVs = new Vector2[parametres.Resolution * parametres.Resolution];

            geometry = new GeometryData(verts, tris, uVs);
        }
    }
}