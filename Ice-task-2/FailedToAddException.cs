using System.Security.Cryptography.X509Certificates;

namespace Ice_task_2
{
    internal class FailedToAddException : Exception
    {
        private string _message = String.Empty;
        public DateTime ErrorTimeStamp { get; set; }
        public string CauseOfError { get; set; }
        public string Solution { get; set; }
        public FailedToAddException() { }
        public FailedToAddException(string cause, DateTime time, string Solution) : this(cause, time,Solution, string.Empty)
        {
        }
        public FailedToAddException(string cause, DateTime time, string solution, string message): this(cause, time, solution,message, null) 
        { 
        }
        public FailedToAddException(string cause, DateTime time, string solution, string message, System.Exception inner): base(message, inner)
        {
            CauseOfError = cause;
            ErrorTimeStamp = time;
            Solution = solution;
        }

    }
}
