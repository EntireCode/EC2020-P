using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EC.Web.Areas.RMA.Data
{
    public class RMANumber
    {
        public int Id { get; set; }

        [Display(Name = "Current RMA Number")]
        public long CurrentRMANumber { get; set; }
    }
}
