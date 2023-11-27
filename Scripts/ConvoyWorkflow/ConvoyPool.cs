using System.Collections.Generic;

namespace ConvoyWorkflow
{
    public class ConvoyPool
    {
        private List<DirectConvoy> _convoys;

        public ConvoyPool()
        {
            _convoys = new List<DirectConvoy>();
        }

        public void GetConvoy(out DirectConvoy convoy)
        {
            if (!TryFindConvoy(out convoy))
            {
                convoy = new DirectConvoy();
                _convoys.Add(convoy);
            }
        }

        public bool TryFindConvoy(out DirectConvoy convoy)
        {
            for(int i = 0; i < _convoys.Count; i++)
            {
                if (!_convoys[i].IsActive)
                {
                    convoy = _convoys[i];
                    return true;
                }

            }

            convoy = null;
            return false;
        }

        public void ReleaseAll()
        {
            for (int i = 0; i < _convoys.Count; i++)
                _convoys[i].Release();
        }

        public void Clear()
        {
            _convoys.Clear();
        }
    }
}
