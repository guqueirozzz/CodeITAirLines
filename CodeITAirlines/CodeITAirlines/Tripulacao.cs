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
        public int fl_policia { get; set; }

        // Construtor padrão
        public Tripulacao()
        { }

       public Tripulacao(int index, int permissao_conducao, string descricao, int fl_policia)
        {
            this.index = index;
            this.permissao_conducao = permissao_conducao;
            this.descricao = descricao;
            this.fl_policia = fl_policia;

        }

        //Função para carregas as pessoas para dar inicio ao prgrama
        public List<Tripulacao> carregaPessoas()
        {
            List<Tripulacao> tripulacao_lista = new List<Tripulacao>();

            tripulacao_lista.Add(new Tripulacao(index = 0, 1, "0 - Piloto", 0));
            tripulacao_lista.Add(new Tripulacao(index = 1, 0, "1 - Oficial 01", 0));
            tripulacao_lista.Add(new Tripulacao(index = 2, 0, "2 - Oficial 02", 0));
            tripulacao_lista.Add(new Tripulacao(index = 3, 1, "3 - Chefe de Serviço", 0));
            tripulacao_lista.Add(new Tripulacao(index = 4, 0, "4 - Comissaria 01", 0));
            tripulacao_lista.Add(new Tripulacao(index = 5, 0, "5 - Comissaria 02", 0));
            tripulacao_lista.Add(new Tripulacao(index = 6, 1, "6 - Policial", 1));
            tripulacao_lista.Add(new Tripulacao(index = 7, 0, "7 - Presidiário", 0));
           

            return tripulacao_lista;

        }

    }
}
