using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP.NET_Core_Web_App.Models
{
    public class Hold
    {
        public int Id { get; set; }
        
        public virtual LibraryAsset LibraryAsset { get; set; }
        
        public virtual LibraryCard LibraryCard { get; set; }

        public DateTime HoldPlaced { get; set; }



    }
}
