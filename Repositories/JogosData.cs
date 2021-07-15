using AspNet5Desafio.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspNet5Desafio.Repositories
{
    public class JogosData : IJogosData
    {
        public static List<JogosModel> _repositorio;

        public JogosData()
        {
            //if (_repositorio == null) _repositorio = new List<JogosModel>();

            if (_repositorio == null) _repositorio = new List<JogosModel>()
            {
                new JogosModel() { Id = 1, Titulo = "Jogo 1", Categoria = "Ação" , Ano = "2015" },
                new JogosModel() { Id = 2, Titulo = "Jogo 2", Categoria = "Luta" , Ano = "2019" },
                new JogosModel() { Id = 3, Titulo = "Jogo 3", Categoria = "Corrida" , Ano = "2010" },
            };
            
        }

        public JogosData(List<JogosModel> repositorio)
        {
            _repositorio = repositorio;
        }

        public JogosModel Find(int id)
        {
            return _repositorio.FirstOrDefault(x => x.Id == id);
        }

        public List<JogosModel> GetList()
        {
            return _repositorio.ToList();
        }

        public void Add(JogosModel model)
        {
            _repositorio.Add(model);
        }

        public void Update(JogosModel model)
        {
            int index = _repositorio.FindIndex(m => m.Id == model.Id);
            if (index >= 0) _repositorio[index] = model;
        }

        public void Delete(JogosModel model)
        {
            int index = _repositorio.FindIndex(m => m.Id == model.Id);
            if (index >= 0) _repositorio.RemoveAt(index);
        }
    }
}
