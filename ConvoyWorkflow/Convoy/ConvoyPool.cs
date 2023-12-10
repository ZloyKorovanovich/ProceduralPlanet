using System.Collections.Generic;

namespace ConvoyWorkflow
{
    public class ConvoyPool
    {
        private List<Convoy> _convoys;

        public ConvoyPool()
        {
            _convoys = new List<Convoy>();
        }

        public void GetConvoy(out Convoy convoy)
        {
            if (!TryGetConvoy(out convoy))
            {
                convoy = new Convoy();
                _convoys.Add(convoy);
            }
        }

        public bool TryGetConvoy(out Convoy convoy)
        {
            for(int i = 0; i < _convoys.Count; i++)
            {
                if (!_convoys[i].IsActive)
                {
                    convoy = _convoys[i];
                    convoy.SetActive(true);
                    return true;
                }
            }

            convoy = null;
            return false;
        }

        public void ReleaseAll()
        {
            for (int i = 0; i < _convoys.Count; i++)
                _convoys[i].SetActive(false);
        }

        public void Clear()
        {
            _convoys.Clear();
        }
    }
}
