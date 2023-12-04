namespace ThreadWorkflow
{
    public abstract class ThreadRunner
    {
        protected IActionExecutor _executor;

        public ThreadRunner(IActionExecutor executor)
        {
            _executor = executor;
        }

        public abstract void Run();
        public abstract void Stop();
    }
}