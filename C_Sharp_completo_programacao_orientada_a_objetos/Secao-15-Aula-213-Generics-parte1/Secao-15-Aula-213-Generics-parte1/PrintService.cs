using System;

namespace Secao_15_Aula_213_Generics_parte1
{
    internal class PrintService
    {
        private int[] _values = new int[10];
        private int _count = 0;

        public void AddValue(int value)
        {
            if (_count == 10)//Esse if é só pra ser defensivo, não precisava ter esse aviso com essa exceção.
            {
                throw new InvalidOperationException("PrintService is full");
            }
            _values[_count] = value;
            _count++;
        }

        public int First()
        {
            if (_count == 0)//Esse if é só pra ser defensivo, não precisava ter esse aviso com essa exceção.
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }

        public void Print()//Misericórdia esse método.
        {
            Console.WriteLine("[");
            for (int i = 0; i < _count - 1; i++)
            {
                Console.WriteLine(_values[i] + ", ");
            }
            if (_count > 0)
            {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine("]");
        }
    }
}
