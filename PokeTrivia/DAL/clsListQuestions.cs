using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using Entities;

namespace DAL
{
    public class clsListQuestions
    {
        public static List<clsQuestions> FullListOfQuestion()
        {
            List<clsQuestions> listQuiz;

            listQuiz = new List<clsQuestions>
            {
                new clsQuestions(1,"What is the first Pokémon in the National Pokédex?", "https://assets.pokemon.com/assets/cms2/img/pokedex/full/039.png"),
                new clsQuestions(2, "What is the name of the Pokémon that can transform into any other Pokémon?", "https://assets.pokemon.com/assets/cms2/img/pokedex/full/143.png"),
                new clsQuestions(3, "What is the name of the Pokémon that is always with Team Rocket?", "https://assets.pokemon.com/assets/cms2/img/pokedex/full/053.png"),
                new clsQuestions(4, "Identify the Pokémon that is known as the \"Fire Mouse Pokémon\" and evolves into Quilava.",  "https://assets.pokemon.com/assets/cms2/img/pokedex/full/131.png"),
                new clsQuestions(5, "Which Legendary Pokémon is known as the \"Time Travel Pokémon\"?", "https://assets.pokemon.com/assets/cms2/img/pokedex/full/384.png"),
                new clsQuestions(6, "Identify the Dragon/Flying-type Legendary Pokémon associated with the Hoenn region.", "https://assets.pokemon.com/assets/cms2/img/pokedex/full/152.png"),
                new clsQuestions(7, "What is the name of the Pokémon that evolves into Jolteon when exposed to a Thunder Stone?",  "https://assets.pokemon.com/assets/cms2/img/pokedex/full/700.png"),
                new clsQuestions(8, "Identify the Poison/Flying-type Pokémon often associated with Team Rocket.", "https://assets.pokemon.com/assets/cms2/img/pokedex/full/202.png"),
                new clsQuestions(9, "What is the name of the Legendary Pokémon associated with the creation of the Unova region?", "https://assets.pokemon.com/assets/cms2/img/pokedex/full/543.png"),
                new clsQuestions(10, "Name the Psychic/Fairy-type Pokémon introduced in the Galar region",  "https://assets.pokemon.com/assets/cms2/img/pokedex/full/858.png"),
                new clsQuestions(11, "Which Pokémon is known as the \"Flame Pokémon\" and evolves into Charizard?", "https://assets.pokemon.com/assets/cms2/img/pokedex/full/001.png"),
                new clsQuestions(12, "Which Pokémon is known as the \"Water-type Turtle Pokémon\" and is the first in the National Pokédex?",  "https://assets.pokemon.com/assets/cms2/img/pokedex/full/133.png"),
                new clsQuestions(13, "Which Pokémon is the legendary trio master in the Kanto region?", "https://assets.pokemon.com/assets/cms2/img/pokedex/full/151.png"),
                new clsQuestions(14, "What is the name of the Rock-type Pokémon known for its high defense and evolution into Golem?",  "https://assets.pokemon.com/assets/cms2/img/pokedex/full/076.png"),
                new clsQuestions(15, "Which Pokémon is known as the \"Huge Power Pokémon\" and has a pre-evolution called Marill?", "https://assets.pokemon.com/assets/cms2/img/pokedex/full/183.png"),
                new clsQuestions(16, "In Pokémon lore, what is the name of the mythical Pokémon that created the Sinnoh region?",  "https://assets.pokemon.com/assets/cms2/img/pokedex/full/056.png"),
                new clsQuestions(17, "Name the Psychic-type Pokémon that evolves into Kadabra and then Alakazam.", "https://assets.pokemon.com/assets/cms2/img/pokedex/full/093.png"),


        };

           return listQuiz;
        }
    }
}
