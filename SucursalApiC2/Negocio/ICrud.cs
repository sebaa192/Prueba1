using Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Negocio
{
    public  interface ICrud<T> where T : IDataEntity
    {
         ResponseExec Create(T o);
         T GetById(T o);
         List<T> GeQuery(T o);
         List<T> Get(T o);
         ResponseExec Update(T o);
         ResponseExec Delete(T o);
    }
}
