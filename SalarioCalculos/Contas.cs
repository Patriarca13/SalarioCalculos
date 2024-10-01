using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioCalculos
{
    internal class Contas
    {
        public double SalarioBase { get; set; }
        public int StarPlus { get; set; }

        public int Fx { get; set; }
        public int X30 { get; set; }
        public double Imposto { get; set; }
        public double Porcentagem { get; set; }



        public int BonusStarplus()
        {
            return StarPlus * 25;
        }
        public int bonusFx()
        {
            return Fx * 35;
        }
        public double BonusX30()
        {
            return X30 * 12.50;
        }
        public double ValorTotal()
        {
            return BonusStarplus() + bonusFx() + BonusX30();
        }

        public double SalarioTotal()
        {
            return ValorTotal() + SalarioBase;
        }
        public double SalarioPercentual()
        {
            double salarioTotal = SalarioTotal();
            double bonusPercentual = salarioTotal * (Imposto / 100);
            return salarioTotal - bonusPercentual;
        }
        public double SalarioComPercentual()
        {
            double salarioTotal = SalarioPercentual();
            double bonusPercentual = salarioTotal * (Porcentagem / 100);
            return salarioTotal + bonusPercentual;
        }
    }
}
