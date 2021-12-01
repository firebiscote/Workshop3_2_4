using System.Collections.Generic;
using System.Diagnostics;

namespace Core.Business
{
    public class Processes
    {
        private Dictionary<string, Process> processes;

        public Processes()
        {
            processes = new Dictionary<string, Process>();
        }

        public Process Get(string name)
        {
            return processes[name];
        }

        public void Add(string name, Process p)
        {
            processes.Add(name, p);
        }

        public void Add(string fullName)
        {
            string name = fullName.Split('.')[0];
            Process p = new Process() { StartInfo = new ProcessStartInfo(fullName) };
            processes.Add(name, p);
        }

        public void Add(string fullName, string argument)
        {
            string name = fullName.Split('.')[0];
            Process p = new Process() { StartInfo = new ProcessStartInfo(fullName) };
            processes.Add(name, p);
        }

        public bool Execute(string name)
        {
            return processes[name].Start();
        }  
    }
}
