using ConvoyWorkflow;
using System.Collections.Generic;
using UnityEngine;

namespace ComputeWorkflow
{
    public class ConvoyManager : MonoBehaviour, IService
    {
        private ConvoyPool _pool;
        
        private void OnEnable()
        {
            ServiceLocator.RegisterService(this);
            DontDestroyOnLoad(gameObject);
            _pool = new ConvoyPool();
        }

        public void OnDisable()
        {
            ServiceLocator.UnregisterService<ConvoyManager>();
        }

        public void ConfigureConvoy(Stack<IStage> stages, out Convoy convoy)
        {
            _pool.GetConvoy(out convoy);
            convoy.Configure(stages);
        }
    }
}