using System;
using System.Collections.Generic;
using System.Text;

namespace DmTools
{
    class Player
    {
        public string PlayerSheet => $"Player Id: {PlayerId}\n" +
                                          $"Player Name: {PlayerName}\n" +
                                          $"Character Name: {CharacterName}\n" +
                                          "Strength Dexterity Constitution Intelligence Wisdom Charisma\n" +
                                          $"{Strength,5}{Dexterity,9}{Constitution,11}{Intelligence,14}{Wisdom,10}{Charisma,8}";

        public int PlayerId;
        public string PlayerName;
        public string CharacterName;
        


        //Attributes
        public int Strength;
        public int Dexterity;
        public int Constitution;
        public int Intelligence;
        public int Wisdom;
        public int Charisma;
    }
}
