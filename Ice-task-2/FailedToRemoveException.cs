using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Ice_task_2
{
    internal class FailedToRemoveException : Exception
    {
        private string _message = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }
        public string Solution { get; set; }
        
        public FailedToRemoveException() { }
        public FailedToRemoveException(string cause, DateTime time, string Solution) : this(cause, time, Solution, string.Empty)
        {
        }
        public FailedToRemoveException(string cause, DateTime time, string solution, string message) : this(cause, time, solution, message, null)
        {
        }
        public FailedToRemoveException(string cause, DateTime time, string solution, string message, System.Exception inner) : base(message, inner)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
            Solution = solution;
        }

    }
}
