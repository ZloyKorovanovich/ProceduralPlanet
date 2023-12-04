using BuilderWorkflow;
using ConvoyWorkflow;
using System;

namespace Planet.View
{
    public class GeometryConfigurationBuilder : IConfigurationBuilder
    {
        private Action _onDispatched;
        private GeometryModel _model;

        public GeometryConfigurationBuilder(GeometryModel model, Action onDispatched)
        { 
            _model = model;
            _onDispatched = onDispatched;
        }

        public void ConstructConfiguartor(out IStageConfigurator configurator)
        {
            GeometryAssignConfigurator assign = new GeometryAssignConfigurator(_model.BufferModel, _model.ParametresModel, _model.KernelModel);
            DispatchConfigurator dispatch = new DispatchConfigurator(_model.KernelModel, _onDispatched);
            configurator = new GeometryConfigurator(_model.KernelModel, assign, dispatch);
        }
    }
}