using ComputeWorkflow;
using ComputeWorkflow.Configuration;
using System;

namespace Planet.View
{
    public class GeometryConfigurator : KernelConfigurator
    {
        public GeometryConfigurator(GeometryAssignConfigurator assign, 
            DispatchConfigurator dispatch) : base(assign, dispatch)
        {

        }
    }
}