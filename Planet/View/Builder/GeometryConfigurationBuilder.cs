using BuilderWorkflow;
using ComputeWorkflow;
using ConvoyWorkflow;
using System;

namespace Planet.View
{
    public class GeometryConfigurationBuilder : IConfigurationBuilder
    {
        private GeometryAssignConfigurator _assign;
        private DispatchConfigurator _dispatch;

        public void ConstructAssignConfigurator(GeometryModel model)
        {
            _assign = new GeometryAssignConfigurator(model.BufferModel, model.ParametresModel, model.KernelModel);
        }

        public void ConstructDispatchConfigurator(KernelModel model, Action onDispatched)
        {
            _dispatch = new DispatchConfigurator(model, onDispatched);
        }

        public void ConstructConfiguartor(out IStageConfigurator configurator)
        {
          
            configurator = new GeometryConfigurator(_assign, _dispatch);
        }
    }
}