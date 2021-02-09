using System;
using System.Collections.Generic;
using System.Text;

namespace CodeITAirlines
{
    class Program
    {
        static Aviao aviao = new Aviao();
        static SmartForTwo smart = new SmartForTwo();
        static Tripulacao tripulacao = new Tripulacao();
        static Terminal term = new Terminal();
        static void Main(string[] args)
        {
            Console.WriteLine("================================================================================\n");
            Console.WriteLine("Por motivos de segurança, o primeiro passageiro deve ser o Policial, index: 6\n");
            Console.WriteLine("================================================================================\n");
            Console.WriteLine("Entre com os indices respectivos à cada pessoa dos passageiros do SmartForTwo");
            Console.WriteLine("===========================================================================\n");
            Console.WriteLine("\n");
            Console.WriteLine("  0 - Piloto" + "\n" +
                              "  1 - Oficial 01" + "\n" +
                              "  2 - Oficial 02" + "\n" +
                              "  3 - CHefe de Serviço" + "\n" +
                              "  4 - Comissaria 01" + "\n" +
                              "  5 - Comissaria 02 " + "\n" +
                              "  6 - Policial" + "\n" +
                              "  7 - Presidiario" + "\n"
                             );
            Console.WriteLine("===========================================================================\n");
            var passageiros = tripulacao.carregaPessoas();
            term.carrega_terminal(passageiros);
            listagem();
            SmartVehicle(passageiros);
        }

        // Função Dinâmica para escolher os condutores e passageiros do veículo
        public static void SmartVehicle(List<Tripulacao> passageiros) 
        {
            foreach(Tripulacao obj in passageiros )
            {
                Console.WriteLine("Por favor digite o numero correspondente ao condutor do SmartForTwo");
                int idx_condutor = int.Parse(Console.ReadLine());
                Console.WriteLine("Por favor digite o numero correspondente ao passageiro do SmartForTwo");
                int idx_passageiro = int.Parse(Console.ReadLine());

                smart.validaPessoas(idx_condutor, idx_passageiro, passageiros);

                if (smart.validaPessoas(idx_condutor, idx_passageiro, passageiros) != false)
                    Console.WriteLine("Pessoas validadas com sucesso!");
                else
                { 
                    Console.WriteLine("A validação de pessoas retornou com erro, verifique o motorista e o passageiro corretamente.\n");
                    Console.WriteLine("ENCERRANDO O PROGRAMA! \n");
                    Environment.Exit(0);
                }

                smart.TerminalAteAviao(passageiros[idx_condutor].index, passageiros[idx_passageiro].index, passageiros);
                listagem();

                smart.AviaoAteTerminal(passageiros[idx_condutor].index, passageiros[idx_passageiro].index, passageiros);
                listagem();
            }
        }
    
        // função para listagem de pessoas do terminal e avião simultaneamente
        public static void listagem()
        {
            term.ListaTerminal();
            aviao.ListaAviao();

        }
    }
}
