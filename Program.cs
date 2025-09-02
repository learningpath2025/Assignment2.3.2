namespace Assignment2._3._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TipCalculator();
        }

        public static void TipCalculator()
        {
            Console.Write("Enter the bill total: ");
            decimal billTotal = Convert.ToDecimal(Console.ReadLine());
            Console.Write("Enter the tip percentage (e.g., 15 for 15%): ");
            decimal tipPercentage = Convert.ToDecimal(Console.ReadLine());
            decimal tipAmount = (tipPercentage / 100) * billTotal;
            decimal grandTotal = billTotal + tipAmount;
            Console.WriteLine($"Bill Total: {billTotal:C}");
            Console.WriteLine($"Tip Percentage: {tipPercentage}%");
            Console.WriteLine($"Tip Amount: {tipAmount:C}");
            Console.WriteLine($"Grand Total: {grandTotal:C}");
        }
    }
}
