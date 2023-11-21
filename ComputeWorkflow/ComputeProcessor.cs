using System.Collections.Generic;

namespace ComputeWorkflow
{
    public static class ComputeProcessor
    {
        private static List<ComputeConvoy> _convoys;
        public static int ConvoyCount => _convoys.Count;

        static ComputeProcessor()
        {
            _convoys = new List<ComputeConvoy>();
        }

        public static void AddConvoy(ComputeConvoy convoy)
        {
            if(_convoys.Contains(convoy))
                _convoys.Add(convoy);
        }

        public static void End(ComputeConvoy convoy)
        {
            _convoys[_convoys.IndexOf(convoy)].End();
            _convoys.Remove(convoy);
        }

        public static void EndAll()
        {
            for (int i = 0; i < _convoys.Count; i++)
                _convoys[i].End();

            _convoys.Clear();
        }
    }
}