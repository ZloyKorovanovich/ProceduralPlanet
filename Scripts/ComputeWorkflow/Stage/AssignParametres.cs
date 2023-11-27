namespace ComputeWorkflow.Stage
{
    public class AssignParametres : KernelStage
    {
        protected IParametresModel _parametres;

        public AssignParametres(IParametresModel parametres, KernelData kernelData)
        {
            _kernelData = kernelData;
            _parametres = parametres;
        }

        public override void Complete()
        {
            _parametres.AssignData(_kernelData.Compute);
        }
    }
}