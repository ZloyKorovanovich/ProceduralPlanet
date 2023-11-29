using ComputeWorkflow;
using ComputeWorkflow.Configuration;
using Planet.View;

namespace Planet.Model
{
    public class GeometryConfigurator : KernelConfigurator
    {
        public GeometryConfigurator(KernelModel kernelModel, GeometryAssignConfigurator assign, 
            DispatchConfigurator dispatch) : base(kernelModel, assign, dispatch)
        {

        }
    }
}