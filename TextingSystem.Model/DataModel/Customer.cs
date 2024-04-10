using TextingSystem.Core.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextingSystem.Model.DataModel
{
    public partial class Customer : IAggregateRoot
    {
        public Customer()
        {
        }

        public int customer_id { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string customer_type { get; set; }
        public string AspNetUserId { get; set; }
        public DateTime? date_created { get; set; }
        public DateTime? date_modified { get; set; }
        public string track_password { get; set; }
        public bool? AESApplied { get; set; }

    }
}
