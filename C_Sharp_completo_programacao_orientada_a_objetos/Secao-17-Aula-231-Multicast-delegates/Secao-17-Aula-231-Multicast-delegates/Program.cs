﻿using System;
using Secao_17_Aula_231_Multicast_delegates.Entities;

namespace Secao_17_Aula_231_Multicast_delegates
{
    internal class Program
    {
        delegate void BinaryNumericOperation(double n1, double n2);
        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op = CalculationService.ShowSum;
            op += CalculationService.ShowMax;
            op(a, b);
        }
    }
}
