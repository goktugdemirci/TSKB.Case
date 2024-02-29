using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSKB.Case.Domain.Entities.Common;

namespace TSKB.Case.Domain.Entities
{
    public class Departman : BaseEntity
    {
        public int DepartmanKodu { get; set; }
        public string DepartmanAdi { get; set; }
        public ICollection<Personel> Personels { get; set; }
    }
}
