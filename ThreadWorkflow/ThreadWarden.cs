namespace ThreadWorkflow
{
    public class ThreadWarden
    {
        private ThreadRunner _runner;
        private bool _isActive;

        public bool IsActive => _isActive;

        public void Configure(ThreadRunner runner)
        {
            _runner = runner;
        }

        public void StartThread()
        {
            _runner.Run();
            _isActive = true;
        }

        public void StopThread()
        {
            _runner.Stop();
            _isActive = false;
        }
    }
}