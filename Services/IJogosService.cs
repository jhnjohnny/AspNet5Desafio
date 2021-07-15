using AspNet5Desafio.Models;
using System.Collections.Generic;

namespace AspNet5Desafio.Services
{
    public interface IJogosService
    {
        List<JogosModel> ListarJogos();
        JogosModel BuscarJogo(JogosModel jogo);
        void AdicionarJogo(JogosModel jogo);
        void AtualizarJogo(JogosModel jogo);
        void DeletarJogo(JogosModel jogo);
    }
}