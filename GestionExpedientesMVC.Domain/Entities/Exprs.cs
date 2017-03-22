using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExpedientesMVC.Domain.Entities
{
    [Table("Expres")]
    public class Exprs
    {
        [Key]
        public int ID { get; set; }
        public string EXP_CODIGO { get; set; }
        public int EXP_N_INTERNO { get; set; }
        public string EXP_SMT_MAT_CODIGO { get; set; }
        public string EXP_TITULO { get; set; }
        public decimal EXP_IMP_INI { get; set; }
    }
}
