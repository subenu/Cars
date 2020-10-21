using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cars.Models
{
    public class PlaneList
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
