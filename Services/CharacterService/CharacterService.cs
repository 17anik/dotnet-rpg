using System.Collections.Generic;
using System.Linq;
using dotnet_rpg.Models;

namespace dotnet_rpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {
        private static List<Character> characters = new List<Character>{
            new Character(),
            new Character {ID = 1, Name = "Siri"}
        };
        List<Character> ICharacterService.AddCharacter(Character newCharacter)
        {
            characters.Add(newCharacter);
            return characters;
        }

        List<Character> ICharacterService.GetAllCharacters()
        {
            return characters;
        }

        Character ICharacterService.GetCharacterById(int id)
        {
            return characters.FirstOrDefault(c => c.ID == id);
        }
    }
}