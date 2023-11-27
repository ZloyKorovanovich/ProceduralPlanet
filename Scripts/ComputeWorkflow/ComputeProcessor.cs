using ConvoyWorkflow;
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
    }
}