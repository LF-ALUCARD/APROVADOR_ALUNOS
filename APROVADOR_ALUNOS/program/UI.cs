using APROVADOR_ALUNOS.entidades;
using APROVADOR_ALUNOS.services;
using APROVADOR_ALUNOS.services.alunos;
using APROVADOR_ALUNOS.services.disciplina;
using APROVADOR_ALUNOS.services.curso;
using System;

namespace APROVADOR_ALUNOS.program
{
    internal class UI
    {

        private Lista<Aluno> aluno;
        private Lista<Curso> curso;
        private Lista<Disciplina> disciplina;


        public UI(String caminho_aluno, String caminho_disciplina, String caminho_curso)
        { 
            aluno = ServicosAlunos.iniciar(caminho_aluno);
            disciplina = ServicosDisciplina.iniciar(caminho_disciplina);
            curso = ServicosCursos.iniciar(caminho_curso, aluno, disciplina);
        }


        public void menu() //Menu inicial da minha tela
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

        private void Buscar() //MENU DE OPÇÃO DE BUSCA
        {
            Console.Clear(); //Faz a limpeza do console, para imprimir o novo Menu
            Console.WriteLine("MENU DE BUSCA");
            Console.WriteLine("[1] - Por Alunos");
            Console.WriteLine("[2] - Por Disciplina");
            Console.Write("Digite sua opção: ");
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

        private void Por_Aluno() //MENU PARA ESCOLHER COMO QUER BUSCAR O ALUNO
        {
            Console.Clear(); //Faz a limpeza do console, para imprimir o novo Menu
            Console.WriteLine("MENU DE BUSCA DE ALUNO");
            Console.WriteLine("[1] - Buscar por nome");
            Console.WriteLine("[2] - Buscar por matricula");
            Console.Write("Digite sua opção: ");

            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Por_Aluno_Nome();
            }
            else if (opcao == 2)
            {
                Por_Aluno_Mátricula();
            }
            else
            {
                Console.WriteLine("Opção invalida!");
                continuar(); //Caso escolha uma opção errada, volta para o inicio
            }

        }

        private void Por_Aluno_Nome() //Opção para buscar o Aluno Por nome
        {
            Console.Clear();
            Console.Write("Digite o nome completo do Aluno: ");
            String nome = Console.ReadLine();

            if (!ServicosAlunos.verificador_nome(nome)) {
                Console.WriteLine("Nome não encontrado");
                continuar();
            }

            Aluno estudante = ServicosAlunos.Buscar_Nome(nome); //Método que retorna o objeto aluno pelo nome
            

            Console.WriteLine();

            Console.WriteLine("===DADOS DO ALUNO==");
            ServicosCursos.ListarDesempenhoDoAluno(estudante, this.curso); //Método void que imprime os dados do Aluno com a lista de disciplinas cursadas
            continuar(); //Volta ao Menu Inicial do Projeto
        }

        private void Por_Aluno_Mátricula() //Opção para buscar o Aluno Por nome
        {
            Console.Clear();
            Console.Write("Digite a matricula do Aluno: ");
            int matricula = int.Parse(Console.ReadLine());

            if (!ServicosAlunos.verificador_matricula(matricula))
            {
                Console.WriteLine("Nome não encontrado");
                continuar();
            }

            Aluno estudante = ServicosAlunos.Buscar_Matricula(matricula); //Método que retorna o objeto aluno pelo nome


            Console.WriteLine();

            Console.WriteLine("===DADOS DO ALUNO==");
            ServicosCursos.ListarDesempenhoDoAluno(estudante, this.curso); //Método void que imprime os dados do Aluno com a lista de disciplinas cursadas
            continuar(); //Volta ao Menu Inicial do Projeto
        }

        private void Por_Discipluna()
        {
            Console.Clear(); //Faz a limpeza do console, para imprimir o novo Menu
            Console.WriteLine("MENU DE BUSCA DE DISCIPLINA");
            Console.WriteLine("[1] - Buscar por nome");
            Console.WriteLine("[2] - Buscar por códico");
            Console.Write("Digite sua opção: ");

            int opcao = int.Parse(Console.ReadLine());

            if (opcao == 1)
            {
                Por_Disciplina_Nome();
            }
            else if (opcao == 2)
            {
                Por_Disciplina_Codico();
            }
            else
            {
                Console.WriteLine("Opção invalida!");
                continuar(); //Caso escolha uma opção errada, volta para o inicio
            }
        }

        public void Por_Disciplina_Nome()
        {

        }

        public void Por_Disciplina_Codico()
        {

        }

        // Metodo para apagar tudo e iniciar Menu do zero
        private void continuar()
        {
            Console.WriteLine("clique em alguma tecla para continuar!");
            Console.ReadKey();
            Console.Clear();
            menu(); // inicia o menu novamente
        }

    }
}
