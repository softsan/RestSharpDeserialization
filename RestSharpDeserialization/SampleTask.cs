using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestSharpDeserialization
{
    /// <summary>
    /// The sample task.
    /// </summary>
    public class SampleTask
    {
        public bool HasTitle { get; set; }
        public string Title { get; set; }
        public List<List<object>> Entries { get; set; }
    }
}
