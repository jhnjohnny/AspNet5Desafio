using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNet5Desafio.Models;

namespace AspNet5Desafio.Repositories
{
    public interface IJogosData
    {
        List<JogosModel> GetList();
        JogosModel Find(int id);
        void Add(JogosModel model);
        void Update(JogosModel model);
        void Delete(JogosModel model);
    }
}
