using System;
using System.Collections.Generic;
using System.Linq;

class Evolution
{
    public string EvolutionType { get; set; }
    public int EvolutionIndex { get; set; }
}

class PokemonEvolution
{
    static void Main()
    {
        var allPokemons = new Dictionary<string, List<Evolution>>();

        string input = Console.ReadLine();
        while (input != "wubbalubbadubdub")
        {
            string[] pokemonInfo = input.Split(new char[] { ' ', '-', '>' }, 
                StringSplitOptions.RemoveEmptyEntries).ToArray();

            string pokemonName = pokemonInfo[0];

            if (pokemonInfo.Length == 1)
            {
                if (allPokemons.ContainsKey(pokemonName))
                {
                    PrintThisPokemonEvolutions(pokemonInfo[0], allPokemons);
                }
                input = Console.ReadLine();
                continue;
            }

            Evolution evolution = new Evolution
            {
                EvolutionType = pokemonInfo[1],
                EvolutionIndex = int.Parse(pokemonInfo[2])
            };

            if (!allPokemons.ContainsKey(pokemonName))
            {
                allPokemons.Add(pokemonName, new List<Evolution>());
            }
            allPokemons[pokemonName].Add(evolution);

            input = Console.ReadLine();
        }

        PrintAllPokemonEvolutions(allPokemons);
    }

    private static void PrintThisPokemonEvolutions(string pokemonName, Dictionary<string, List<Evolution>> allPokemons)
    {
        Console.WriteLine($"# {pokemonName}");
        foreach (var evolution in allPokemons[pokemonName])
        {
            Console.WriteLine($"{evolution.EvolutionType} <-> {evolution.EvolutionIndex}");
        }
    }

    private static void PrintAllPokemonEvolutions(Dictionary<string, List<Evolution>> allPokemons)
    {
        foreach (var pokemon in allPokemons)
        {
            Console.WriteLine($"# {pokemon.Key}");
            foreach (var evolution in pokemon.Value.OrderByDescending(x => x.EvolutionIndex))
            {
                Console.WriteLine($"{evolution.EvolutionType} <-> {evolution.EvolutionIndex}");
            }
        }

    }
}
