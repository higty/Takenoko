using System;
using System.Collections.Generic;
using System.Text;

namespace Takenoko.Data
{
    public class DBlogRecord
    {
        public Guid BlogCD { get; set; }
        public String Title { get; set; }
        public DateTimeOffset CreateTime { get; set; }
        public Guid UserCD { get; set; }
        public String BdoyText { get; set; }
    }
}
