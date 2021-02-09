using System;
using System.Collections.Generic;
using System.Text;

namespace CodeITAirlines
{
    class SmartForTwo : Aviao // uso de Herança
    {
        Terminal term = new Terminal();
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
                Console.WriteLine("O Oficial 01 não pode viajar com o chefe de serviço");
                return false;
            }
            else if (tripulacao[idx_passageiro].index == 2 && tripulacao[idx_motorista].index == 3)
            {
                Console.WriteLine("O " + passageiro +  "não pode viajar com o " + motorista);
                return false;
            }
            else if (tripulacao[idx_passageiro].index == 4 && tripulacao[idx_motorista].index == 0) 
            {
                Console.WriteLine("O " + passageiro + "não pode viajar com o " + motorista);
                return false;
            }
            else if (tripulacao[idx_passageiro].index == 5 && tripulacao[idx_motorista].index == 0)
            {
                Console.WriteLine("O " + motorista + "não pode ficar sozinha com a" + passageiro);
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
                AddPessoasAviao(idx_passageiro, tripulacao);
                AddPessoasAviao(idx_motorista, tripulacao);
            }
        }

        public void AviaoAteTerminal(int idx_motorista, int idx_passageiro, List<Tripulacao> tripulacao)
        {
            string motorista = tripulacao[idx_motorista].descricao;

            if (tripulacao[idx_motorista].permissao_conducao != 1)
                Console.WriteLine("O " + motorista + " não tem permissão para condução do veiculo");

            else if (tripulacao.Count == 1 && tripulacao[idx_motorista].permissao_conducao == 1 )
                AddPessoasAviao(idx_motorista, tripulacao);

            else if (tripulacao[idx_motorista].permissao_conducao == 1)
            {
                Console.WriteLine("O " + motorista + " irá sozinho ate o terminal");
                RmPessoasAviao(idx_motorista, tripulacao);
                term.AddPessoasTerminal(idx_motorista, tripulacao);
            }
        }
    }
}
