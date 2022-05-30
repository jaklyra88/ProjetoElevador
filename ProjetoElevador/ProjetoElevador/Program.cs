using System;
using ControlElevador.Model;


namespace ControlElevador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ESTÂNCIANDO A CLASSE ELEVADOR
            Elevador elevador = new Elevador();
            
            //CHAMANDO O MÉTODO INICIALIZAR PARA SOLICITAR AO USUÁRIO O TOTAL DE ANDARES DO PRÉDIO 
            //E A CAPACIDADE MÁXIMA DE PESSOAS NO ELEVADOR
            elevador.inicializar();
            Console.WriteLine(" ");

            Boolean continuar = true;

            //INCÍCIO DO LOOP QUE EXIBE O MENU ATÉ QUE O USUÁRIO SELECIONE PARA FECHAR O SISTEMA
            do
            {

                //MENU PARA SOLICITAR AO USUÁRIO A OPÇÃO QUE DESEJA
                Console.WriteLine("");
                Console.WriteLine(@"Escolha uma opção:
                                    1 - Entrar
                                    2 - Subir
                                    3 - Descer
                                    4 - Sair
                                    5 - Fechar Sistema");

                string opcaoEscolhida = Console.ReadLine();



                //PARA LIMPAR O CONSOLE
                Console.Clear();

                //INICIANDO O SWITCH COM A OPÇÃO ESCOLHIDA PELO USUÁRIO
                switch (opcaoEscolhida)
                {
                    //ELE SELECIONA O MÉTODO DE ACORDO COM A OPÇÃO SELECIONADA NA VARIÁVEL OPCAOESCOLHIDA
                    //AO CHAMAR O MÉTODO , O SISTEMA ACESSA A CLASSE USUÁRIO , BUSCANDO O MÉTODO
                    ////PARA EXECUTA-LO
                    case "1": elevador.entrar(); break;
                    case "2": elevador.subir(); break;
                    case "3": elevador.descer(); break;
                    case "4": elevador.sair(); break;
                    case "5": continuar = false; break;
                    default: Console.WriteLine("Escolha uma opção válida"); break;

                }


            }

            while (continuar);
            //FIM DO LOOP DO WHILE - VAI EXECUTAR ENQUANTO A CONDIÇÃO FOR VERDADEIRA



        }

    }
}

