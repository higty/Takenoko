using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppMySns
{
    public class UserRecord
    {
        public Guid UserCD { get; set; }
        public String DisplayName { get; set; }
        public String ID { get; set; }
        public String Twitter { get; set; }
        public String Facebook { get; set; }
        public String Instagram { get; set; }
        public String Youtube { get; set; }
    }
}
