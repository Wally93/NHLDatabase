using NHLDatabase.Models.NHL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHLDatabase.Data
{
    public class DummyData
    {
        public static System.Collections.Generic.List<Team> getTeams()
        {
            List<Team> teams = new List<Team>()
            {
                new Team()
                {
                    TeamName = "Canucks",
                    City = "Vancouver",
                    Province = "BC",
                    Country = "Canada"

                },

                new Team()
                {
                    TeamName = "Oilers",
                    City = "Edmonton",
                    Province = "Alberta",
                    Country = "Canada"
                },
                new Team()
                {
                    TeamName = "Flames",
                    City = "Calgary",
                    Province = "Alberta",
                    Country = "Canada"
                },

                new Team()
                {
                    TeamName = "Sharks",
                    City = "San Jose",
                    Province = "California",
                    Country = "USA"
                },
            };

            return teams;
        }

        public static List<Player> getPlayers(NhlContext context)
        {
                //Link the player to his team
            List<Player> players = new List<Player>()
            {
                new Player
                {
                    FirstName = "SVEN",
                    LastName = "BAERTSCHI",
                    TeamName = context.Teams.Find("Canucks").TeamName,
                    Salary = 5.2,
                    Position = "Forward",
                    
                },
                new Player
                {
                    FirstName = "Henrik",
                    LastName = "Sedin",
                    TeamName = context.Teams.Find("Canucks").TeamName,
                    Salary = 6.3,
                    Position = "Left Wing",
                    
                },
                new Player
                {
                    FirstName = "John",
                    LastName = "Rooster",
                    TeamName = context.Teams.Find("Flames").TeamName,
                    Salary = 4.5,
                    Position = "Right Wing",
                   
                },
                new Player
                {
                    FirstName = "Bob",
                    LastName = "Plumber",
                    TeamName = context.Teams.Find("Oilers").TeamName,
                    Salary = 5.3,
                    Position = "Defense",
                    
                },
            };

            return players;
        }
    }
}