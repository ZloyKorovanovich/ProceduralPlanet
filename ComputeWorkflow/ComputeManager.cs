using ConvoyWorkflow;
using System.Collections.Generic;
using UnityEngine;

namespace ComputeWorkflow
{
    public class ComputeManager : MonoBehaviour, IService
    {
        private ConvoyPool _pool;
        
        private void OnEnable()
        {
            if (!ServiceLocator.RegisterService(this))
            {
                Destroy(gameObject);
                return;
            }

            DontDestroyOnLoad(gameObject);
            _pool = new ConvoyPool();
        }

        public void OnDisable()
        {
            ServiceLocator.UnregisterService<ComputeManager>();
        }

        public void ConfigureConvoy(Stack<IStage> stages, out IConvoy convoyInetraction)
        {
            _pool.GetConvoy(out DirectConvoy convoy);
            convoy.Configure(stages);
            convoy.Run();

            convoyInetraction = convoy;
        }
    }
}