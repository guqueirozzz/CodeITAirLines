using System;
using System.Collections.Generic;
using System.Text;

namespace CodeITAirlines
{
    class SmartForTwo  // uso de Herança
    {
        Terminal term = new Terminal();
        Aviao aviao = new Aviao();

        public bool validaPessoas(int idx_motorista, int idx_passageiro, List<Tripulacao> tripulacao)
        {
            string motorista = tripulacao[idx_motorista].descricao;
            string passageiro = tripulacao[idx_passageiro].descricao;

            if (tripulacao[idx_motorista].permissao_conducao != 1)
            {
                Console.WriteLine(motorista + " não pode dirigir!");
                return false;
            }
            else if (tripulacao[idx_passageiro].index == 1 && tripulacao[idx_motorista].index == 3)
            {
                Console.WriteLine(passageiro + " não pode viajar com o " + motorista);
                return false;
            }
            else if (tripulacao[idx_passageiro].index == 2 && tripulacao[idx_motorista].index == 3)
            {
                Console.WriteLine( passageiro +  " não pode viajar com o " + motorista);
                return false;
            }
            else if (tripulacao[idx_passageiro].index == 4 && tripulacao[idx_motorista].index == 0) 
            {
                Console.WriteLine( passageiro + " não pode viajar com o " + motorista);
                return false;
            }
            else if (tripulacao[idx_passageiro].index == 5 && tripulacao[idx_motorista].index == 0)
            {
                Console.WriteLine( passageiro + " não pode viajar com o " + motorista);
                return false;
            }
            else
                return true;

        }

        public void TerminalAteAviao(int idx_motorista, int idx_passageiro, List<Tripulacao> tripulacao)
        {
            
            var motorista = tripulacao[idx_motorista].descricao;
            var passageiro = tripulacao[idx_passageiro].descricao;

            if (tripulacao[idx_motorista].permissao_conducao != 1)
                Console.WriteLine(motorista + "nao pode dirigir");
            else
            {
                Console.WriteLine("Trajeto: " + motorista + " leva " + passageiro + " do terminal até o avião.");
                term.RmPessoasTerminal(idx_motorista, tripulacao);
                term.RmPessoasTerminal(idx_passageiro, tripulacao);
                aviao.AddPessoasAviao(idx_passageiro, tripulacao);
                aviao.AddPessoasAviao(idx_motorista, tripulacao);
            }
        }

        public void AviaoAteTerminal(int idx_motorista, int idx_passageiro, List<Tripulacao> tripulacao)
        {
            string motorista = tripulacao[idx_motorista].descricao;

            if (tripulacao[idx_motorista].permissao_conducao != 1)
                Console.WriteLine("O " + motorista + " não tem permissão para condução do veiculo");

            else if (tripulacao.Count == 1 && tripulacao[idx_motorista].permissao_conducao == 1 )
                aviao.AddPessoasAviao(idx_motorista, tripulacao);

            else if (tripulacao[idx_motorista].permissao_conducao == 1)
            {
                Console.WriteLine("O " + motorista + " irá sozinho ate o terminal");
                aviao.RmPessoasAviao(idx_motorista, tripulacao);
                term.AddPessoasTerminal(idx_motorista, tripulacao);

            }
        }
    }
}
