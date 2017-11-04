using System;
using System.Linq;
using System.Text.RegularExpressions;

class CameraView
{
    static void Main()
    {
        var skipTake = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int skip = skipTake[0];
        int take = skipTake[1];

        string picture = Console.ReadLine();
        string pattern = @"|<";
        
        string[] cameras = picture.Split(new string[] {pattern}, StringSplitOptions.None);

        for (int i = 1; i < cameras.Length; i++)
        {
            char[] camera = cameras[i].ToCharArray();
            string view = new string(camera.Skip(skip).Take(take).ToArray());

            if (i == 1)
            {
                Console.Write("{0}", view);
                continue;
            }
            Console.Write(", {0}", view);
        }
        Console.WriteLine();

    }
}
