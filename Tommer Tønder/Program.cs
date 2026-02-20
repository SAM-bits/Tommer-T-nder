namespace Tommer_Tønder
{
    internal class Program
    {
        static double Volume(double radius , double højde ) 
        {
            // det her er udregning af volumen formlen det er p*radius^2*h 
            double volumen = Math.PI * Math.Pow(radius, 2) * højde;



            return volumen;

        }

        static double Overfladearealet(double radius, double højde)
        {
            // det her er udregning af volumen formlen det er p*radius^2*h 
            double overfladearealet = 2 * Math.PI * radius * (radius + højde);
            


            return overfladearealet;

        }
        static void Main(string[] args)
        {

            bool playagain = true;
           
            
            
            while (playagain)
            {

                string answer = "";


                Console.WriteLine("Hvilken hej beregner program vil du brug ? ");
                Console.WriteLine("1 Volumen \n2 Overfladearealet  ");
                answer = (Console.ReadLine());
                Console.Clear();




                if (answer == "1")
                {

                    double r;
                    double h;
                    double resultat;

                    Console.WriteLine("Indtast Radius");
                    r = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Indtast højde");
                    h = Convert.ToDouble(Console.ReadLine());


                    resultat = Volume(r, h);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Volumen er :" + resultat);
                    Console.ResetColor();


                }


                if (answer == "2")
                {

                    double r;
                    double h;
                    double resultat;

                    Console.WriteLine("Indtast Radius");
                    r = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine("Indtast højde");
                    h = Convert.ToDouble(Console.ReadLine());


                    resultat = Overfladearealet(r, h);

                    Console.WriteLine("Overfladearealet er = " + resultat);




                }
                
                Console.WriteLine("Vil du prøve igen ? y/n ");
                answer = (Console.ReadLine());
                if (answer == "y")
                {

                    playagain = true;
                    Console.Clear();
                    Console.ResetColor();
                }

                else if (answer == "n")
                {
                    playagain = false;
                    Console.WriteLine("tak for at være med ");
                } 
                
                



            }



            



        }
    }
}
