using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Map
    {
        public int Id { get; set; }
        public List<string> positions { get; set; }
        public string SecretKey { get; set; }
    }
}
