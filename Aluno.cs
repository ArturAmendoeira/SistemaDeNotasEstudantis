using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XulambsCollege
{
    class Aluno
    {
        private string nome;
        private int matricula;
        private double[] notas = new double[5];
        private double notaTotal;
        public void registrarNotas(double[] vetor)
        {
            for(int i = 0; i < 5; i++)
            {
                notas[i] = vetor[i];
            }
        }

        public Aluno(string name, int code)
        {
            nome = name;
            matricula = code;
        }
        public Boolean aprovado()
        {
            return (notaTotal >= 60);
        }
        public void somaNotas()
        {
            double soma = 0;
            for(int i = 0; i < 5; i++)
            {
                soma += notas[i]; 
            }
            notaTotal = soma;
        }
        public Boolean limiteNota(double nota)
        {
            if (nota >= 0 && nota <= 20)
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}
