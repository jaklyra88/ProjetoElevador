using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlElevador.Model
{
    //CRIAÇÃO DA CLASSE ELEVADOR
    class Elevador
    {
        //CRIAÇÃO DOS ATRIBUTOS E DOS MÉTODOS GETTER E SETTER
        public int andarAtual { get; set; }

        public int totalAndares { get; set; }

        public int capacidade { get; set; }

        public int pessoas { get; set; }


        //MÉTODOS QUE SOLICITA DOS DADOS PARA INICIALIZAÇÃO DAS
        //VARIÁVEIS DO TOTAL DE ANDARES E CAPACIDADE DO ELEVADOR
        public void inicializar()
        {
            //SOLICITANDO O TOTAL DE ANDARES
            Console.WriteLine("Informe o número de andares do prédio (desconsiderar o térreo): ");
            totalAndares = int.Parse(Console.ReadLine());

            //SOLICITANDO A CAPACIDADE DO ELEVADOR
            Console.WriteLine("Informe a capacidade de pessoas suportadas pelo elevador: ");
            capacidade = int.Parse(Console.ReadLine());

        }

        //MÉTODO QUE CONTROLA A ENTRADA DE PESSOAS NO ELEVADOR
        public void entrar()
        {
            //SE O NÚMERO DE PESSOAS FOR MENOR QUE A CAPACIDADE ELE AUTORIZA A ENTRADA

            if (pessoas < capacidade)
            {
                Console.WriteLine("Embarque Liberado");
                pessoas++;
                Console.WriteLine(" ");
                Console.WriteLine("Embarcando...");
                Console.WriteLine(" ");
                Console.WriteLine($"O número de pessoas no elevador é {pessoas}");
            }
            //SE O NÚMERO DE PESSOAS FOR MAIOR QUE A CAPACIDADE ELE NÃO PERMITE A ENTRADA
            else
            {
                Console.WriteLine("Capacidade Máxima Atingida");
                Console.WriteLine(" ");
                Console.WriteLine($"O número de pessoas no elevador é {pessoas}");
                Console.WriteLine(" ");
            }



        }
        //MÉTODO QUE CONTROLA A SAÍDA DE PESSOAS DO ELEVADOR
        public void sair()

        {

            //SE O NÚMERO DE PESSOAS FOR MAIOR DO QUE ZERO, ELE SUBTRAI O NÚMERO DE PESSOAS
            if (pessoas > 0)
            {
                Console.WriteLine("Saida Liberada");
                Console.WriteLine(" ");
                pessoas--;
                Console.WriteLine("Desembarcando...");
                Console.WriteLine(" ");
                Console.WriteLine($"O número de pessoas no elevador é {pessoas}");
                Console.WriteLine(" ");
            }
            //SE O NÚMERO DE PESSOAS FOR 0 ELE EXIBE QUE O ELEVADOR JÁ ESTÁ VAZIO
            else
            {
                Console.WriteLine("O elevador está vazio");
                Console.WriteLine(" ");
                Console.WriteLine($"O número de pessoas no elevador é {pessoas}");
                Console.WriteLine(" ");
            }


        }

        //MÉTODO QUE CONTROLA O MOVIMENTO DE SUBIR DO ELEVADOR
        public void subir()

        {
            //SE O NÚMERO DO ANDAR ATUAL FOR MENOR DO QUE O TOTAL DE ANDARES , O ELEVADOR SOBE
            if (andarAtual < totalAndares)
            {

                Console.WriteLine($"Andar Atual {andarAtual}");
                Console.WriteLine(" ");
                Console.WriteLine("Elevador subindo..");
                Console.WriteLine(" ");
                andarAtual++;
                Console.WriteLine($"Chegamos ao andar {andarAtual}");
                Console.WriteLine(" ");
            }
            //SE O NÚMERO DE ANDAR ATUAL FOR MAIOR QUE O TOTAL DE ANDARES, O SISTEMA NÃO PERMITE QUE ELE SUBA
            else
            {
                Console.WriteLine("Já estamos no último andar");
                Console.WriteLine(" ");
                Console.WriteLine($"Andar Atual {andarAtual}");
                Console.WriteLine(" ");

            }

        }

        //MÉTODO PARA CONTROLAR O MOVIMENTO DE DESCER DO ELEVADOR
        public void descer()
        {

            //SE A VARIÁVEL DO ANDAR ATUAL FOR MAIOR QUE 0 ELE PERMITE QUE O ELEVADOR DESÇA
            if (andarAtual > 0)
            {
                Console.WriteLine($"Andar Atual {andarAtual}");
                Console.WriteLine(" ");
                Console.WriteLine("Elevador está descendo..");
                Console.WriteLine(" ");
                andarAtual--;
                Console.WriteLine($"Chegamos ao andar {andarAtual}");
                Console.WriteLine(" ");
            }
            //SE O ANDAR ATUAL FOR MENOR QUE 0, O SISTEMA NÃO PERMITE QUE O ELEVADOR DESÇA
            else
            {
                Console.WriteLine("Já estamos no térreo");
                Console.WriteLine(" ");
                Console.WriteLine($"Andar Atual {andarAtual}");
                Console.WriteLine(" ");

            }

        }

    }
}
