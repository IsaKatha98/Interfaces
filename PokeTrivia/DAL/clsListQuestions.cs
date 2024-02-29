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
                new clsQuestions(1,"What is the first Pokémon in the National Pokédex?"),
            new clsQuestions(2, "What is the name of the Pokémon that can transform into any other Pokémon?"),
            new clsQuestions(3, "What is the name of the Pokémon that is always with Team Rocket?"),
            new clsQuestions(4, "Identify the Pokémon that is known as the \"Fire Mouse Pokémon\" and evolves into Quilava."),
            new clsQuestions(5, "Which Legendary Pokémon is known as the \"Time Travel Pokémon\"?"),
            new clsQuestions(6, "Identify the Dragon/Flying-type Legendary Pokémon associated with the Hoenn region."),
            new clsQuestions(7, "What is the name of the Pokémon that evolves into Jolteon when exposed to a Thunder Stone?"),
            new clsQuestions(8, "Identify the Poison/Flying-type Pokémon often associated with Team Rocket."),
            new clsQuestions(9, "What is the name of the Legendary Pokémon associated with the creation of the Unova region?"),
            new clsQuestions(10, "Name the Psychic/Fairy-type Pokémon introduced in the Galar region"),
            new clsQuestions(11, "Which Pokémon is known as the \"Flame Pokémon\" and evolves into Charizard?"),
            new clsQuestions(12, "Which Pokémon is known as the \"Water-type Turtle Pokémon\" and is the first in the National Pokédex?"),
            new clsQuestions(13, "Which Pokémon is the legendary trio master in the Kanto region?"),
            new clsQuestions(14, "What is the name of the Rock-type Pokémon known for its high defense and evolution into Golem?"),
            new clsQuestions(15, "Which Pokémon is known as the \"Huge Power Pokémon\" and has a pre-evolution called Marill?"),
            new clsQuestions(16, "In Pokémon lore, what is the name of the mythical Pokémon that created the Sinnoh region?"),
            new clsQuestions(17, "Name the Psychic-type Pokémon that evolves into Kadabra and then Alakazam."),


        };

           return listQuiz;
        }
    }
}
