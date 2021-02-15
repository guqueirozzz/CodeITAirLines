using System;
using System.Collections.Generic;
using System.Text;

namespace CodeITAirlines
{
    class Terminal
    {
        //static List<string> lista_terminal = new List<string>();
        static List<Tripulacao> list_terminal = new List<Tripulacao>();

        public void carrega_terminal(List<Tripulacao> tripulacao)
        {
            //foreach (Tripulacao obj in tripulacao)
            //    lista_terminal.Add(obj.descricao);

            foreach (Tripulacao obj in tripulacao)
                list_terminal.Add(new Tripulacao(obj.index, obj.permissao_conducao, obj.descricao, obj.fl_policia));
            
        }

        // Função para adicionar pessoas ao terminal
        public void AddPessoasTerminal(int idx_passageiro, List<Tripulacao> tripulacao)
        {
            //lista_terminal.Add(tripulacao[idx_passageiro].descricao);
            list_terminal.Add(new Tripulacao(tripulacao[idx_passageiro].index, tripulacao[idx_passageiro].permissao_conducao, tripulacao[idx_passageiro].descricao, tripulacao[idx_passageiro].fl_policia));
            
        }

        // Função para remover pessoas do terminal
        public void RmPessoasTerminal(int idx_passageiro, List<Tripulacao> tripulacao)
        {
            list_terminal.RemoveAll(x => x.index == idx_passageiro);
        }

        // Lista as pessoas no terminal, caso nao tenha mais pessoas no terminal, o programa é encerrado
        public void ListaTerminal()
        {
            Console.WriteLine("");
            Console.WriteLine("======Pessoas no Terminal=======");
            Console.WriteLine("========================\n\n");

            if (list_terminal.Count == 0)
            {
                Console.WriteLine("Terminal vazio! Todas as pessoas estão no avião!\n");
                Console.WriteLine("ENCERRANDO PROGRAMA...");
                Environment.Exit(0);
            }
            else
                foreach (Tripulacao obj in list_terminal)
                    Console.WriteLine(obj.descricao);

            if (list_terminal.Exists(p => p.descricao == "6 - Policial") && list_terminal.Exists(p => p.descricao == "7 - Presidiário"))
                Console.WriteLine("Existe policial junto com o presidiário");
            else if (!list_terminal.Exists(p => p.descricao == "7 - Presidiário" && list_terminal.Count > 1))
            {
                Console.WriteLine("Preso saiu do terminal! ");
            }
            else
            {
                Console.WriteLine("O policial nao esta com o presidiário");
                Console.WriteLine("Encerrando programa! ");
                Environment.Exit(0);
            }

            Console.WriteLine("========================");
            
        }
    }

}
