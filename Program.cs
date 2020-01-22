using System;
using System.Collections.Generic;
using System.Linq;

namespace DmTools
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var programRunning = true;
            var playerList = new List<Player>();
            var playerDictionary = new Dictionary<string, Player>();
           
            while (programRunning)
                { 
                    DisplayMenu();
                    int selection = Convert.ToInt32(Console.ReadLine());
                    if (selection == 1) 
                    {
                        InputPlayer(playerDictionary, playerList);
                        Console.WriteLine("Player has been input.");
                    }
                    else if (selection == 2)
                    {
                    DisplayPlayers(playerList);   
                    }
                    else if (selection == 3) 
                    {
                    SearchPlayers(playerList);
                    }
                    else { programRunning = false;}              
                }

         static void InputPlayer(Dictionary<string, Player> playerDictionary, List<Player> playerList)
            {
                Console.WriteLine("Enter Player Id");
                var playerId = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Your Name");
                var playerName = Console.ReadLine();
                Console.WriteLine("Enter Your Character Name");
                var characterName = Console.ReadLine();
                Console.WriteLine("Enter your Strength Score");
                var strength = Convert.ToInt32(Console.ReadLine());
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

                Console.WriteLine(player.PlayerSheet);

                playerDictionary.Add(player.PlayerName, player);
                playerList = playerDictionary.Select(p => p.Value).ToList();

               
            }

         static void DisplayPlayers(List<Player> playerList) 
            {
               
                playerList.ForEach(s =>
                {
                    Console.WriteLine(s.PlayerSheet);
                });
                
            }
         static void SearchPlayers(List<Player> playerList)
            {
                Console.WriteLine("Search string:");
                var searchString = Console.ReadLine();
                var players = playerList.Where(p => p.PlayerName.Contains(searchString)).ToList();
                if (players.Any())
                {
                    
                    players.ForEach(p =>
                    {
                        Console.WriteLine(p.PlayerSheet);
                    });
                }
            }
         
         static void DisplayMenu()
            {
                Console.WriteLine("DM Tools Menu");
                Console.WriteLine("1. Input Player");
                Console.WriteLine("2. List Players");
                Console.WriteLine("3. Find Player by Name");
                Console.WriteLine("4. Exit");
            }   

        }
    }
}
