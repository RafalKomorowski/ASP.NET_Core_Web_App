using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Web_App.Models
{
    public class LibraryCard
    {
        public int Id { get; set; }

        public decimal Fees { get; set; }

        public DateTime Created { get; set; }

        public virtual IEnumerable <Checkout> Checkouts { get; set; }


    }
}
