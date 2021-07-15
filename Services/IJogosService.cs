using AspNet5Desafio.Models;
using System.Collections.Generic;

namespace AspNet5Desafio.Services
{
    public interface IJogosService
    {
        List<JogosModel> ListarJogos();
        JogosModel BuscarJogo(JogosModel jogo);
        bool AdicionarJogo(JogosModel jogo);
        bool AtualizarJogo(JogosModel jogo);
        bool DeletarJogo(JogosModel jogo);
    }
}