using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HWEF5
{
    public class Store
    {
        public Guid Id { get; set; } = Guid.NewGuid();

        public string NameItems { get; set; }

        public int CountItems { get; set; }

        public int PriceItems { get; set; }
    }
}
