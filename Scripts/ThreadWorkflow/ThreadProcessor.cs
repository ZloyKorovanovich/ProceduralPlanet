using System.Collections.Generic;

namespace ThreadWorkflow
{
    public static class ThreadProcessor
    {
        private static List<ThreadWarden> _threads;

        static ThreadProcessor()
        {
            _threads = new List<ThreadWarden>();
        }

        public static void StopAll()
        {
            for (int i = 0; i < _threads.Count; i++)
                _threads[i].StopThread();
        }

        public static void StartThread(ThreadRunner runner)
        {
            if(!FindFreeWarden(out ThreadWarden threadWarden))
            {
                threadWarden = new ThreadWarden();
                _threads.Add(threadWarden);
            }

            threadWarden.Configure(runner);
            threadWarden.StartThread();
        }

        public static bool FindFreeWarden(out ThreadWarden threadWarden)
        {
            for (int i = 0; i < _threads.Count; i++)
            {
                if (!_threads[i].IsActive)
                {
                    threadWarden = _threads[i];
                    return true;
                }

            }

            threadWarden = null;
            return false;
        }
    }
}