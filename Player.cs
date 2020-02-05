using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using DmTools;

namespace DmTools
{   
    class Player
    {
        
        public string PlayerSheet => $"Player Id: {PlayerId}\n" +
                                          $"Player Name: {PlayerName}\n" +
                                          $"Character Name: {CharacterName}\n" +
                                          "Strength Dexterity Constitution Intelligence Wisdom Charisma\n" +
                                          $"{Strength,5}{Dexterity,9}{Constitution,11}{Intelligence,14}{Wisdom,10}{Charisma,8}\n"+
                                          $"{StrMod, 5}{DexMod, 9}{ConMod, 11}{IntMod, 14}{WisMod, 10}{ChaMod, 8}";

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

        public int StrMod;
        public int DexMod;
        public int ConMod;
        public int IntMod;
        public int WisMod;
        public int ChaMod;

        public int InitiativeScore;

        public static void InputPlayer(List<Player> playerList)
            {
                Console.WriteLine("Enter Player Id");
                var playerId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Your Name");
                var playerName = Console.ReadLine();
                Console.WriteLine("Enter Your Character Name");
                var characterName = Console.ReadLine();
                Console.WriteLine("Enter your Strength Score");
                int strength = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Dexterity Score");
                var dexterity = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Constitution Score");
                var constitution = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Intelligence Score");
                var intelligence = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Wisdom Score");
                var wisdom = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Charisma Score");
                var charisma = Convert.ToInt32(Console.ReadLine());

                var player = new Player();
                player.PlayerId = playerId;
                player.PlayerName = playerName;
                player.CharacterName = characterName;
                player.Strength = strength;
                player.Dexterity = dexterity;
                player.Constitution = constitution;
                player.Intelligence = intelligence;
                player.Wisdom = wisdom;
                player.Charisma = charisma;

                player.StrMod = (strength - 10) / 2;
                player.DexMod = (dexterity - 10) / 2;
                player.ConMod = (constitution - 10) / 2;
                player.IntMod = (intelligence - 10) / 2;
                player.WisMod = (wisdom - 10) / 2;
                player.ChaMod = (charisma - 10) / 2;

                Console.WriteLine(player.PlayerSheet);


                playerList.Add(player);

               
            }
    }
}
