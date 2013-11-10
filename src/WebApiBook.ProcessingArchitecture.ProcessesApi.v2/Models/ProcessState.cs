using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace WebApiBook.ProcessingArchitecture.ProcessesApi.v2.Models
{
    public class ProcessState
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double TotalProcessorTimeInMillis { get; set; }
        // other properties

        public ProcessState() { }
        public ProcessState(Process proc)
        {
            Id = proc.Id;
            Name = proc.ProcessName;
            TotalProcessorTimeInMillis = proc.TotalProcessorTime.TotalMilliseconds;
            // other properties
        }
    }

    public class ProcessCollectionState
    {
        public IEnumerable<ProcessState> Processes { get; set; }
    }
}