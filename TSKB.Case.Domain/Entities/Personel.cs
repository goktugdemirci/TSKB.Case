using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TSKB.Case.Domain.Entities.Common;

namespace TSKB.Case.Domain.Entities
{
    public class Personel : BaseEntity
    {
        [ForeignKey("DepartmanId")]
        public int DepartmanId { get; set; }
        public int SicilNumarasi { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public DateTime IseGirisTarihi { get; set; }
        [AllowNull]
        public DateTime? IsttenCikisTarihi { get; set; }
        public string MailAdresi { get; set; }
        public string Cinsiyet { get; set; }
        public string CepTelefonu { get; set; }
        [AllowNull]
        public string? EvTelefonu { get; set; }
        public Departman Departman { get; set; }
    }
}
