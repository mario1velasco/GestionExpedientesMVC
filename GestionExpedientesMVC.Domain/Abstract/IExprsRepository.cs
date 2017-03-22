using GestionExpedientesMVC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionExpedientesMVC.Domain.Abstract
{
    public interface IExprsRepository
    {
        IEnumerable<Exprs> Expres { get; }
    }
}
