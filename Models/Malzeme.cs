using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazlab1.Models
{
    public class Malzeme
    {
        public int MalzemeID { get; set; }
        public string MalzemeAdi { get; set; }
        public string ToplamMiktar { get; set; }

        public string MalzemeBirim { get; set; }    

        public string BirimFiyat { get; set; }  
    }
}