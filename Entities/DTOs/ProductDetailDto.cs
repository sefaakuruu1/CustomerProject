using Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs
{
    public class ProductDetailDto:IDto
    {
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public string KategoriAdi { get; set; }
        public string BirimdekiMiktar { get; set; }
    }
}
