namespace Secao_04_Aula_42_Exercicio_03
{
    internal class Aluno
    {
        public string Nome;//Por padrão do C# os atributos começam com letra maiúscula.
        public double Nota1;
        public double Nota2;
        public double Nota3;

        public double NotaFinal()//Não tem parâmetro de entrada, então os parênteses ficam vazios.
        {
            return Nota1 + Nota2 + Nota3;
        }

        public bool Aprovado()
        {
            if (NotaFinal() >= 60.0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double NotaRestante()
        {
            if (Aprovado())
            {
                return 0.0;
            }
            else
            {
                return 60.0 - NotaFinal();
            }
        }
    }
}