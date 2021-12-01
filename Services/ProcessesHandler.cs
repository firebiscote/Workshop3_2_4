using Core.Business;
using System.Diagnostics;

namespace Core.Services
{
    public class ProcessesHandler
    {
        public Processes Processes { get; }

        public ProcessesHandler()
        {
            Processes = new Processes();
        }

        public void AddProcess(string fullName)
        {
            Processes.Add(fullName);
        }

        //public ProcessStartInfo Execute(string name)
    }
}
