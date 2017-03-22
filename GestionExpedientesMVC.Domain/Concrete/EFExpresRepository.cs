using GestionExpedientesMVC.Domain.Abstract;
using GestionExpedientesMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExpedientesMVC.Domain.Concrete
{
    public class EFExpresRepository:IExprsRepository
    {
        private EFDbContext context = new EFDbContext();
        public IEnumerable<Exprs> Expres { get { return context.Expres; } }
    }
}
