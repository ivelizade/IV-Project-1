using System;

namespace HomeWork
{
    interface IPay
    {
        void pay();
    }
    class AzerCell : IPay
    {
        string number;

        public AzerCell(string number)
        {
            this.number = number;
        }

        public void pay()
        {
            Console.WriteLine("AzerCell  Balans Artirildi");
        }

    }
    class BakCell : IPay
    {
        string number;

        public BakCell(string number)
        {
            this.number = number;
        }

        public void pay()
        {
            if (number[1]=='5')
            {

            }
            Console.WriteLine("BakCell  Balans Artirildi");
        }
    }
    class NarMobile : IPay
    {
        string number;

        public NarMobile(string number)
        {
            this.number = number;
        }

        public void pay()
        {
            Console.WriteLine("NarMobile Balans Artirildi");
        }
    }
    class CIB
    {
        public void IncreaseBalance()
        {
            pay.pay();
        }
        IPay pay;
        public CIB(IPay pay)
        {
            this.pay = pay;
        }
    }
    class Prog
    {
        static void Main()
        {
            DateTime dateTime = new DateTime(2018, 6, 14);
            DateTime now = DateTime.Now;
            TimeSpan left =dateTime-now;
            Console.WriteLine(left.Days);
        }
    }
}

