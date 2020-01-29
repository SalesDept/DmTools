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
           
           
            while (programRunning)
                { 
                    DisplayMenu();
                    int selection = Convert.ToInt32(Console.ReadLine());
                    if (selection == 1) 
                    {
                        Player.InputPlayer(playerList);
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
