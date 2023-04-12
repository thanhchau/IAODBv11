using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IAODBV1.Models
{
    public class MainResponse
    {
        public bool isSucccess { get; set; }
        public string ErrorMsg { get; set; }
        public object Content { get; set; }
    }
}
