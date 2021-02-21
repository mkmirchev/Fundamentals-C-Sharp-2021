using System;
using System.Linq;
using System.Collections.Generic;


namespace TeamworkProjects
{
    class Program
    {
        static void Main(string[] args)
        {
            int teamsToCreate = int.Parse(Console.ReadLine());
            List<Team> teamList = new List<Team>();

            for (int i = 0; i < teamsToCreate; i++)
            {
                List<string> input = Console.ReadLine().Split('-').ToList();
                if (TeamExist(teamList, input[1]) != null)
                {
                    Console.WriteLine("Team {0} was already created!",input[1]);
                    continue;
                }
                if (CreatorExist(teamList, input[1]))
                {
                    Console.WriteLine("{0} cannot create another team!", input[1]);
                    continue;
                }

                Team tm = new Team
                {
                    Creator = input[0],
                    TeamName = input[1]
                };

                teamList.Add(tm);
                Console.WriteLine("Team {0} has been created by {1}!",tm.TeamName, tm.Creator);
               
            }
            while (true)
            {
                List<string> secondInput = Console.ReadLine().Split("->").ToList();
                if (secondInput[0] == "end of assignment")
                {
                    break;
                }
                if (TeamExist(teamList, secondInput[1]) == null)
                {
                    Console.WriteLine("Team {0} does not exist!",secondInput[1]);
                    continue;
                }
                if (IsMemberPartOfTeam(teamList, secondInput[0]))
                {
                    Console.WriteLine("Member {0} cannot join team {1}!",secondInput[0], secondInput[1]);
                    continue;
                }
                Team existingTeam = new Team();
                existingTeam = (GetTeamByName(teamList, secondInput[1]));
                existingTeam.Member.Add(secondInput[0]);
                
               // existingTeam.Member.Add();

            }
            List<Team> sortedByNumOfMembers = teamList.OrderByDescending(x => x.Member.Count).ThenBy(y => y.TeamName).ToList();
            foreach (Team tm in sortedByNumOfMembers)
            {
                if (tm.Member.Count > 0)
                {
                    
                    Console.WriteLine(tm.TeamName);
                    Console.WriteLine($"- {tm.Creator}");
                    List<string> strMembers = tm.Member.OrderBy(x=>x.ToString()).ToList();
                    foreach (var member in strMembers)
                {
                        Console.WriteLine($"-- {member}");
                }
                }
                
            }
            Console.WriteLine("Teams to disband:");
            List<Team> sorted = teamList.OrderBy(x => x.TeamName).ToList();
            foreach (Team tm in sorted)
            {
                if (tm.Member.Count == 0)
                {
                    Console.WriteLine(tm.TeamName);

                }

            }

        }
        private static Team GetTeamByName(List<Team> teamList, string teamName)
        {
            Team currentTeam = new Team();
            foreach (Team item in teamList)
            {
                if (item.TeamName == teamName)
                {
                    return item;
                }
            }
            return null;
        
        }
        private static string TeamExist(List<Team> team, string newTeamName)
        {
            foreach (Team createdTeam in team)
            {
                if (createdTeam.TeamName == newTeamName)
                {
                    return newTeamName;
                }
            }
            return null;
        }
        private static bool CreatorExist(List<Team> team, string creator)
        {
            foreach (Team createdTeam in team)
            {
                if (createdTeam.Creator == creator)
                {
                    return true;
                }
            }
            return false;
        }
        private static bool IsMemberPartOfTeam(List<Team> team, string member)
        {
            foreach (var creator in team)
            {
                if (creator.Creator == member)
                {
                   return true;
                }
            }
            foreach (Team tm in team)
            {
                if (tm.Member == null)
                {
                    return false;
                }
                foreach (string existingMember in tm.Member)
                {
                    if (existingMember == member)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
    }

    public class Team
    {
        public Team()
        {
            Member = new List<string>();
        }
        public string Creator { get; set; }
        public string TeamName { get; set; }
        public List<string> Member {get; set;}

    }
}
