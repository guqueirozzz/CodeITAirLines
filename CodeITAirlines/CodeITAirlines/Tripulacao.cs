using System;
using System.Collections.Generic;
using System.Text;

namespace CodeITAirlines
{
    class Tripulacao
    {
        // Properties
        public int index { get; set; }
        public int permissao_conducao { get; set; }
        public string descricao { get; set; }

        // Construtor padrão
        public Tripulacao()
        { }

       public Tripulacao(int index, int permissao_conducao, string descricao)
        {
            this.index = index;
            this.permissao_conducao = permissao_conducao;
            this.descricao = descricao;
        }

        //Função para carregas as pessoas para dar inicio ao prgrama
        public List<Tripulacao> carregaPessoas()
        {
            List<Tripulacao> tripulacao_lista = new List<Tripulacao>();

            tripulacao_lista.Add(new Tripulacao(0, 1, "0 - Piloto"));
            tripulacao_lista.Add(new Tripulacao(1, 0, "1 - Oficial 01"));
            tripulacao_lista.Add(new Tripulacao(2, 0, "2 - Oficial 02"));
            tripulacao_lista.Add(new Tripulacao(3, 1, "3 - Chefe de Serviço"));
            tripulacao_lista.Add(new Tripulacao(4, 0, "4 - Comissaria 01"));
            tripulacao_lista.Add(new Tripulacao(5, 0, "5 - Comissaria 02"));
            tripulacao_lista.Add(new Tripulacao(6, 1, "6 - Policial"));
            tripulacao_lista.Add(new Tripulacao(7, 0, "7 - Presidiário"));
           

            return tripulacao_lista;

        }

    }
}
