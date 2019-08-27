using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Testapp2Api.Models
{
    public class Complain
    {
        [Key]
        public String ComplainerName { get; set; }
        public int houseNo { get; set; }
        public String complain { get; set; }


    }
}
