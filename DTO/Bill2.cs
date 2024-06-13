using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class Bill2
    {
        public int ID { get; set; }
        public int TableID { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int Discount { get; set; }
        public int TotalPrice { get; set; }

    }
}
