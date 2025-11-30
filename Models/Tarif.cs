using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Yazlab1.Models
{
    public class Tarif
    {
        public int TarifId { get; set; }
        public string TarifAdi { get; set; }
        public string Kategori { get; set; }
        public string HazirlanmaSuresi { get; set; }
        public string Talimatlar { get; set; }
        public List<Malzeme> Malzemeler { get; set; } = new List<Malzeme>();
    }
}