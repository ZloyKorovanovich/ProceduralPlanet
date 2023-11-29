using ConvoyWorkflow;
using System.Collections.Generic;
using UnityEngine;

namespace ComputeWorkflow
{
    public class ComputeProcessor : MonoBehaviour, IService
    {
        #region SingleTone
        private static ConvoyPool _pool;
        
        private void OnEnable()
        {
            if (ServiceLocator.ComputeProcessor)
            {
                Destroy(gameObject);
                return;
            }

            DontDestroyOnLoad(gameObject);
            ServiceLocator.SetComputeProcessor(this);
            _pool = new ConvoyPool();
        }

        public void OnDisable()
        {
            if (ServiceLocator.ComputeProcessor != this)
                return;
        }
        #endregion

        public void ConfigureConvoy(Stack<IStage> stages, out IConvoy convoyInetraction)
        {
            _pool.GetConvoy(out DirectConvoy convoy);
            convoy.Configure(stages);
            convoy.Run();

            convoyInetraction = convoy;
        }
    }
}