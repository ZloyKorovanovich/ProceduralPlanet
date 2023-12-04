using ComputeWorkflow;
using ComputeWorkflow.Configuration;
using System;

namespace Planet.View
{
    public class GeometryConfigurator : KernelConfigurator
    {
        public GeometryConfigurator(KernelModel kernelModel, GeometryAssignConfigurator assign, 
            DispatchConfigurator dispatch) : base(kernelModel, assign, dispatch)
        {

        }
    }
}