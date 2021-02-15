using System;
using System.Collections.Generic;
using System.Text;

namespace CodeITAirlines
{
    class Aviao
    {
        static List<Tripulacao> lista_aviao = new List<Tripulacao>();


        // Função para adicionar pessoas ao avião
        public void AddPessoasAviao(int index_pessoa, List<Tripulacao> pessoas)
        {
            lista_aviao.Add(new Tripulacao(pessoas[index_pessoa].index, pessoas[index_pessoa].permissao_conducao, pessoas[index_pessoa].descricao, pessoas[index_pessoa].fl_policia));
        }

        // Função para remover pessoas do avião
        public void RmPessoasAviao(int index_pessoa, List<Tripulacao> pessoas)
        {
            lista_aviao.RemoveAll(x => x.index == index_pessoa);
        }

        // Listagem de pessoas no avião
        public void ListaAviao()
        {
            Console.WriteLine("Pessoas no Avião:");
            Console.WriteLine("========================");

            if (lista_aviao.Count == 0)
            {
                Console.WriteLine("Ninguém está no Avião");
            }
            else if (lista_aviao.Count > 0)
            {
                foreach (Tripulacao trip in lista_aviao)
                {
                    Console.WriteLine(trip.descricao);
                }
            }

            if (lista_aviao.Exists(p => p.descricao == "6 - Policial") && lista_aviao.Exists(p => p.descricao == "7 - Presidiário") && lista_aviao.Count > 1)
                Console.WriteLine("EXISTE POLICIALLLLLLL");
            else if (lista_aviao.Count == 0)
            {
                Console.WriteLine("Aguardando passageiros para validação");
            }
            else if ( !lista_aviao.Exists(p => p.descricao == "6 - Policial") && lista_aviao.Exists(p => p.descricao == "7 - Presidiário") && lista_aviao.Count > 1)
            {
                Console.WriteLine("O policial nao esta com o presidiário");
                Console.WriteLine("Encerrando programa! ");
                Environment.Exit(0);
            }
            Console.WriteLine("========================\n\n");
        }
    }
}
