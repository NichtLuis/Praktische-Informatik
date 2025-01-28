namespace Exeptions_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Gib eine Zahl ein");
            string zahl1 = Console.ReadLine();
            Console.WriteLine("Gib noch eine Zahl ein");
            string zahl2 = Console.ReadLine();
            try
            {
                double Zahl1 = Convert.ToDouble(zahl1);
                double Zahl2 = Convert.ToDouble(zahl2);
                double Zahl3 = Zahl1 / Zahl2;
                Console.WriteLine(Zahl3);
            }
            catch (FormatException)
            {
                Console.WriteLine("Das war keine Zahl");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Man kann nicht durch 0 teilen");
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("Mathematischer Fehler");
            }
            catch (OutOfMemoryException)
            {
                Console.WriteLine("Arbeitsspeicher Voll");
            }
            finally
            {
                Console.WriteLine("Fertig");
            }
        }
    }
}
