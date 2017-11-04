using System;

namespace _0510_CubeProperties
{
    class CubeProperties
    {
        static void Main(string[] args)
        {

            double cubeEdge = double.Parse(Console.ReadLine());
            string parameter = Console.ReadLine();

            double output = CalculateCubeParameters(cubeEdge, parameter);
            Console.WriteLine("{0:0.00}", output);
        }

        static double CalculateCubeParameters(double cubeEdge, string parameter)
        {
            double result = 0;
            if (parameter == "face")
            {
                result = Math.Sqrt(2 * cubeEdge * cubeEdge);
            }
            else if (parameter == "space")
            {
                result = Math.Sqrt(3 * cubeEdge * cubeEdge);
            }
            else if (parameter == "volume")
            {
                result = cubeEdge * cubeEdge * cubeEdge;
            }
            else if (parameter == "area")
            {
                result = 6 * cubeEdge * cubeEdge;
            }
            return result;
        }
    }
}
