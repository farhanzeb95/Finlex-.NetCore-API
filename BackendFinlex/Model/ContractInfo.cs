using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using System.Threading.Tasks;

namespace BackendFinlex.Model
{
    public class ContractInfo
    {
        public string Id { get; set; }
        public string customerName { get; set; }
        public string customerAddress { get; set; }
        public string totalPrice { get; set; }
        public string brokerName { get; set; }
        public string brokerAddress { get; set; }
        public string contractStartDate { get; set; }
        public string contractEndDate { get; set; }

        public override string ToString() => JsonSerializer.Serialize<ContractInfo>(this);

    }
}
