using ConvoyWorkflow;
using System.Collections.Generic;
using UnityEngine;

namespace ComputeWorkflow
{
    public class ComputeProcessor : MonoBehaviour
    {
        private static ComputeProcessor _instance;
        private static ConvoyPool _pool;
        
        private void OnEnable()
        {
            if (_instance)
            {
                Destroy(gameObject);
                return;
            }

            DontDestroyOnLoad(gameObject);
            _instance = this;
            _pool = new ConvoyPool();
        }

        public void OnDisable()
        {
            if (_instance != this)
                return;
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