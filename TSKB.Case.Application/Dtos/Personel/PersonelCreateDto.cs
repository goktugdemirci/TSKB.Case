using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSKB.Case.Application.Dtos.Common;

namespace TSKB.Case.Application.Dtos.Personel
{
    public class PersonelCreateDto 
    {
        public int SicilNumarasi { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        public string MailAdresi { get; set; }
        public string Cinsiyet { get; set; }
        public string CepTelefonu { get; set; }
        public string? EvTelefonu { get; set; }
    }
}
