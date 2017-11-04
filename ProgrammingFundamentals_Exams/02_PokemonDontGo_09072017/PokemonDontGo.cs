using System;
using System.Linq;

class PokemonDontGo
{
    static void Main(string[] args)
    {
        int[] pokemons = Console.ReadLine().Split(' ')
                    .Select(int.Parse).ToArray();

        int pokeLength = pokemons.Length;
        long sumPokemons = 0;

        while (pokeLength != 0)
        {
            int index = int.Parse(Console.ReadLine());

            int removedPoke;

            if (index < 0)
            {
                removedPoke = pokemons[0];
                pokemons[0] = pokemons[pokeLength - 1];
            }
            else if (index >= pokeLength)
            {
                removedPoke = pokemons[pokeLength - 1];
                pokemons[pokeLength - 1] = pokemons[0];
            }
            else
            {
                removedPoke = pokemons[index];
                pokemons[index] = 0;
            }

            for (int i = 0; i < pokeLength; i++)
            {
                if (i == index)
                {
                    continue;
                }
                else if (pokemons[i] <= removedPoke)
                {
                    pokemons[i] += removedPoke;
                }
                else if (pokemons[i] > removedPoke)
                {
                    pokemons[i] -= removedPoke;
                }
            }

            sumPokemons += removedPoke;
            pokemons = pokemons.Where(x => x != 0).Concat(pokemons.Where(x => x == 0)).ToArray();
            if (index >= 0 && index < pokeLength)
            {
                pokeLength--;
            }
        }
        Console.WriteLine(sumPokemons);
    }
}
