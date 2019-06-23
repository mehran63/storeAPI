using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApi.Models
{
    public class ProductFilter
    {
        [StringLength(30)]
        public string Id { get; set; }

        [StringLength(30)]
        public string Model { get; set; }

        [StringLength(30)]
        public string Brand { get; set; }

        [StringLength(300)]
        public string Description { get; set; }
    }
}
