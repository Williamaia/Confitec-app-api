using Confitec.Business.Interfaces;
using Confitec.Business.Models;
using Confitec.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;

namespace Confitec.Data.Repository
{
    public class UsuarioRepository : Repository<Usuarios>, IUsuarioRepository
    {
        public UsuarioRepository(ConfitecContext context) : base(context)
        {
        }
    }
}
