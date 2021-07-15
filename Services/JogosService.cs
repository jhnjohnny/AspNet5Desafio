using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AspNet5Desafio.Models;
using AspNet5Desafio.Repositories;

namespace AspNet5Desafio.Services
{
    public class JogosService : IJogosService
    {
        private readonly IJogosData _jogosData;

        public JogosService(IJogosData jogosData)
        {
            _jogosData = jogosData;
        }

        public List<JogosModel> ListarJogos()
        {
            List<JogosModel> listaJogos;

            try
            {
                listaJogos = _jogosData.GetList();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return listaJogos;
        }

        public JogosModel BuscarJogo(JogosModel jogo)
        {
            JogosModel resultJogo;

            try
            {
                resultJogo = _jogosData.Find(jogo.Id);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return resultJogo;
        }

        public void AdicionarJogo(JogosModel jogo)
        {
            if (jogo == null)
            {
                throw new NullReferenceException();
            }

            try
            {
                _jogosData.Add(jogo);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
            
        }

        public void AtualizarJogo(JogosModel jogo)
        {
            try
            {
                _jogosData.Update(jogo);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void DeletarJogo(JogosModel jogo)
        {
            try
            {
                _jogosData.Delete(jogo);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

    }
}
