using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHLDatabase.Models.NHL
{
    public class Player
    {
        //[Key, Column(Order = 0)]
        public int PlayerId { get; set; }
        //[Key, Column(Order = 1)]
        public string FirstName { get; set; }
        //[Key, Column(Order = 2)]
        public string LastName { get; set; }
        public string Position { get; set; }
        public double Salary { get; set; }

        //Forein Key.
        public string TeamName { get; set; }
        public Team Team { get; set; }

    }
}