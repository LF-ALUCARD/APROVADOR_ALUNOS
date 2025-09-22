using System;

namespace APROVADOR_ALUNOS.program
{
    internal class UI
    {
        public static void menu()
        {
            Console.WriteLine("BEM VINDO AO MENU DE DADOS");
            Console.WriteLine("[1] - Buscar Resultados");
            Console.WriteLine("[2] - Sair");
            Console.Write("Digite sua opção: ");
            int opcao = int.Parse(Console.ReadLine()); // captura a entrada de informação do Menu
            if (opcao == 1)
            {
                Buscar();
            }
            else if (opcao == 2)
            {

                Console.WriteLine("Obrigado por usar nossos Serviços");
                Environment.Exit(0); // encerra o programa

            }
            else
            {
                Console.WriteLine("Opção não disponivél");
                continuar();
            }
        }

        private static void Buscar()
        {
            Console.Clear();
            Console.WriteLine("MENU DE BUSCA");
            Console.WriteLine("[1] - Por Alunos");
            Console.WriteLine("[2] - Por Disciplina");
            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Por_Aluno();
            }
            else if (opcao == 2)
            {
                Por_Discipluna();
            }
            else
            {
                Console.WriteLine("Opção invalida!");
                continuar();
            }
        }

        private static void Por_Aluno()
        {
            Console.Clear();
            Console.WriteLine("MENU DE BUSCA DE ALUNO");
            Console.WriteLine("[1] - Buscar por nome");
            Console.WriteLine("[2] - Buscar por matricula");

            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                
            }
            else if (opcao == 2)
            {
               
            }
            else
            {
                Console.WriteLine("Opção invalida!");
                continuar();
            }

        }

        private static void Por_Aluno_Nome()
        {
            Console.Clear();
            Console.Write("Digite o nome completo do Aluno: ");
            String nome = Console.ReadLine();
        }

        private static void Por_Discipluna()
        {

        }

        // Metodo para apagar tudo e iniciar camêra do zero
        private static void continuar()
        {
            Console.WriteLine("clique em alguma tecla para continuar!");
            Console.ReadKey();
            Console.Clear();
            menu(); // inicia o menu novamente
        }

    }
}
