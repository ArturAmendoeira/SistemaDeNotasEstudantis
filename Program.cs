using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsCollege
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva o nome do aluno: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o numero de matrícula do aluno: ");
            int matricula = int.Parse(Console.ReadLine());
            Aluno aluno = new Aluno(nome, matricula);
            double[] notas = new double[5];
            Console.WriteLine("Mostre qual a nota do aluno em cada uma das 5 atividades: ");
            for(int i=0; i<5; i++)
            {
                Console.WriteLine($"Nota da atividade {i + 1}: ");
                double valor = double.Parse(Console.ReadLine());
                while (!aluno.limiteNota(valor))
                {
                    Console.WriteLine($"Nota inválida, tente de novo (0 a 20){i + 1}: ");
                    valor = double.Parse(Console.ReadLine());
                }
                notas[i] = valor;
                
            }
            aluno.registrarNotas(notas);
            aluno.somaNotas();
            Boolean aprovado = aluno.aprovado();
            if (aprovado)
            {
                Console.WriteLine("O aluno consegiu sua aprovação!!!");
            }
            else if (!aprovado)
            {
                Console.WriteLine("O aluno foi reprovado");
            }
            Console.ReadKey();

        }
    }
}
