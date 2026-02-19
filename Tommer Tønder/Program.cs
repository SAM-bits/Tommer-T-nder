namespace Tommer_Tønder
{
    internal class Program
    {
        static void Volume(double radius , double højde ) 
        {
            // det her er udregning af volumen formlen det er p*radius^2*h 
            double volumen = Math.PI * Math.Pow(radius, 2) * højde;
            Console.WriteLine($"{volumen:F3}");


            return;

        }

        static void Overfladearealet(double radius, double højde)
        {
            // det her er udregning af volumen formlen det er p*radius^2*h 
            double overfladearealet = 2 * Math.PI * radius * (radius + højde);
            Console.WriteLine($"{overfladearealet:F3}");


            return;

        }
        static void Main(string[] args)
        {
            /* udregne volumen = V = p *r2 * h
            overfladearealet for en cylinder : A=2*p*r^2+2*p*r*h


             */
            // double input = Convert.ToDouble(Console.ReadLine());



            Volume(10 , 5);
            Overfladearealet(10, 5);
            
            
        }
    }
}
