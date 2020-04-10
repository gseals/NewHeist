using System;
using System.Collections.Generic;
using System.Linq;

namespace NewHeist
{
    class Program
    {
        static void Main(string[] args)
        {

            List<TeamMember> teamTeamTeam = new List<TeamMember>();


            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine();

            string addTeamMember;

            do
            {
                Console.WriteLine("Please enter your team member's name!");
                var memberName = Console.ReadLine();

                Console.WriteLine($"What is {memberName}'s skill level (this number must be a positive integer)");
                int memberSkill;
                var skillNum = int.TryParse(Console.ReadLine(), out memberSkill);
                while (!skillNum || memberSkill < 0)
                {
                    Console.WriteLine("The value you entered does not look correct. Please follow the rules.");
                    skillNum = int.TryParse(Console.ReadLine(), out memberSkill);
                }

                Console.WriteLine(
                    $"{memberSkill} is a great choice. Now, enter a number between 0.0 and 2.0 for your courage factor.");
                decimal courageDecimal;
                var courageNum = decimal.TryParse(Console.ReadLine(), out courageDecimal);
                while (!courageNum || courageDecimal < 0.0m || courageDecimal > 2.0m)
                {
                    Console.WriteLine("The value you entered does not look correct. Please follow the rules.");
                    courageNum = decimal.TryParse(Console.ReadLine(), out courageDecimal);
                }

                Console.WriteLine(
                    $"Your team member {memberName}, whose skill level is {memberSkill} and whose courage level is {courageDecimal}, has been created. Hit Enter.");
                Console.ReadLine();

                teamTeamTeam.Add(new TeamMember(memberName, memberSkill, courageDecimal));
                Console.WriteLine("Would you like to add another team member? Enter y for yes, use any other character for no.");
                addTeamMember = Console.ReadLine().ToLower();
            } while (addTeamMember == "y");

            Console.WriteLine($"You have {teamTeamTeam.Count} members on your team. They are:");
            foreach (var teamTeam in teamTeamTeam)
            {
                Console.WriteLine($"{teamTeam.Name}. Skill Level: {teamTeam.SkillLevel}. Courage: {teamTeam.CourageFactor}.");
            }

            Console.ReadLine();
            Console.Clear();
            var bankDifficultyLevel = 100;
            var totalSkill = teamTeamTeam.Sum(t => t.SkillLevel);
            //int totalSkill = 0;
            //foreach (var teamTeam in teamTeamTeam)
            //{
            //    totalSkill += teamTeam.SkillLevel;
            //}
            Console.WriteLine($"Your team's total skill level is {totalSkill}.");
            Console.ReadLine();

            if (totalSkill >= bankDifficultyLevel)
            {
                Console.WriteLine("You did it. Success!");
            }
            else
            {
                Console.WriteLine("Are those sirens?");
            }

            Console.ReadLine();

        }
    }
}
