using System;
using System.Collections.Generic;
using System.Text;

namespace CodeITAirlines
{
    class Terminal
    {
        static List<string> lista_terminal = new List<string>();

        public void carrega_terminal(List<Tripulacao> tripulacao)
        {
            foreach (Tripulacao obj in tripulacao)
                lista_terminal.Add(obj.descricao);
        }

        // Função para adicionar pessoas ao terminal
        public void AddPessoasTerminal(int idx_passageiro, List<Tripulacao> tripulacao)
        {
            lista_terminal.Add(tripulacao[idx_passageiro].descricao);
        }

        // Função para remover pessoas do terminal
        public void RmPessoasTerminal(int idx_passageiro, List<Tripulacao> tripulacao)
        {
            lista_terminal.Remove(tripulacao[idx_passageiro].descricao);
        }

        // Lista as pessoas no terminal, caso nao tenha mais pessoas no terminal, o programa é encerrado
        public void ListaTerminal()
        {
            Console.WriteLine("");
            Console.WriteLine("======Pessoas no Terminal=======");
            Console.WriteLine("========================\n\n");

            if (lista_terminal.Count == 0)
            {
                Console.WriteLine("Terminal vazio! Todas as pessoas estão no avião!\n");
                Console.WriteLine("ENCERRANDO PROGRAMA...");
                Environment.Exit(0);
            }

            else
                foreach (string pessoa in lista_terminal)
                {
                    Console.WriteLine(pessoa);

                }

            // Tentativa de fazer uma validação para presidiário sozinho com outras pessoas
            if (lista_terminal.IndexOf("Presidiário") >= 0 && lista_terminal.Count > 0)
            {
                Console.WriteLine("Preso está sozinho com as pessoas da tripulação");
                Console.WriteLine("=========== ENCERRANDO O PROGRAMA =============");
                Environment.Exit(0);
            }
 
            
            Console.WriteLine("========================");
            
        }
    }

}
