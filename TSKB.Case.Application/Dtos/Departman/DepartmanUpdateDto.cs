using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSKB.Case.Application.Dtos.Common;

namespace TSKB.Case.Application.Dtos.Departman
{
    public class DepartmanUpdateDto : BaseEntityDto
    {
        public string DepartmanAdi { get; set; }
    }
}
