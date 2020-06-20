using System;

namespace Discount
{
    
    
    public abstract class Discount
    {

        public double discountValue;
        public Discount(double discountAmount)
        {
            discountValue = discountAmount;
        }


        public abstract int CalculateDiscount(int originalPrice);

    }

    
    public class FixedDiscount : Discount
    {
        FixedDiscount(double discountAmount) : base(discountAmount) { }

        public override int CalculateDiscount(int originalPrice)
        {
            int newVal = Convert.ToInt32(originalPrice - discountValue);
            return newVal;
        }
    }

  
    public class PercentageDiscount : Discount
    {

        PercentageDiscount(double discountAmount) : base(discountAmount) { }
        public override int CalculateDiscount(int originalPrice)
        {
            int newVal = Convert.ToInt32(originalPrice - discountValue);
            return newVal;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
        }
    }
}
