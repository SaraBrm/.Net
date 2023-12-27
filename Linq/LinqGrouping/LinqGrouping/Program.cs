using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqGrouping
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>()
            {
                 new Team {  Name="Perpolis" , Country = " Iran"},
                 new Team {  Name="Esteghlal" , Country = " Iran"},
                 new Team {  Name="psg" , Country = " France"},
                 new Team {  Name="Arsenal" , Country = " England"},
                 new Team {  Name="Everton" , Country = " England"},
                 new Team {  Name="Manchester City" , Country = " England"},
            };

            var result = teams.GroupBy(p => p.Country);
            foreach (var country in result)
            {
                Console.WriteLine("Country Group: {0}", country.Key);
                foreach (var item in country)
                {
                    Console.WriteLine("Team Name: {0}", item.Name);
                }
                Console.WriteLine("______________________");
            }


            var result2 = teams.ToLookup(p => p.Country);
            foreach (var country in result2)
            {
                Console.WriteLine("Country Group: {0}", country.Key);
                foreach (var item in country)
                {
                    Console.WriteLine("Team Name: {0}", item.Name);
                }
                Console.WriteLine("______________________");
            }

            Console.ReadLine();
        }
    }
}
