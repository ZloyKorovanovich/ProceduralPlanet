using System;
using System.Collections.Generic;

namespace ThreadWorkflow
{
    public interface IActionExecutor
    {
        public void Execute(Stack<Action> actions);
    }
}