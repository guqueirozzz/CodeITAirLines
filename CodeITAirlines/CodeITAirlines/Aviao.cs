using System;
using System.Collections.Generic;
using System.Text;

namespace CodeITAirlines
{
    class Aviao
    {

        static List<string> lista_aviao = new List<string>();


        // Função para adicionar pessoas ao avião
        public void AddPessoasAviao(int index_pessoa, List<Tripulacao> pessoas)
        {

            lista_aviao.Add(pessoas[index_pessoa].descricao);

        }

        // Função para remover pessoas do avião
        public void RmPessoasAviao(int index_pessoa, List<Tripulacao> pessoas)
        {
            lista_aviao.Remove(pessoas[index_pessoa].descricao);

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
                foreach (string pessoa in lista_aviao)
                {
                    Console.WriteLine(pessoa);
                }
            }

            else if (lista_aviao.Contains("7 - Presidiário") && lista_aviao.Count > 0 )
                Console.WriteLine("O presidiário nao pode ficar sozinho sem a presença do polciial");


            Console.WriteLine("========================\n\n");
        }
    }
}
