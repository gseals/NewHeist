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
            Console.WriteLine("Please enter a difficulty level for the bank. (this number must be a positive integer)");
            int bankDifficultyLevel = 0;
            var testNumber = int.TryParse(Console.ReadLine(), out bankDifficultyLevel);
            while (!testNumber || bankDifficultyLevel < 0)
            {
                Console.WriteLine("The value you entered does not look correct. Please follow the rules.");
                testNumber = int.TryParse(Console.ReadLine(), out bankDifficultyLevel);
            }



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
                Console.WriteLine("Would you like to add another team member? [y or n]");
                addTeamMember = Console.ReadLine().ToLower();
            } while (addTeamMember == "y");

            Console.WriteLine($"You have {teamTeamTeam.Count} members on your team. They are:");
            foreach (var teamTeam in teamTeamTeam)
            {
                Console.WriteLine($"{teamTeam.Name}. Skill Level: {teamTeam.SkillLevel}. Courage: {teamTeam.CourageFactor}.");
            }

            Console.ReadLine();
            Console.Clear();

            int numberOfTries = 0;
            Console.WriteLine("How many times would you like to run this scenario?");
            var convertNumber = int.TryParse(Console.ReadLine(), out numberOfTries);

            var successTotal = 0;

            for (var i = 0; i < numberOfTries; i++)
            {
                Random random = new Random();
                var randomDifficultyLevel = random.Next(-10, 10);
                var finalBankLevel = bankDifficultyLevel + randomDifficultyLevel;
                var totalSkill = teamTeamTeam.Sum(t => t.SkillLevel);
                //int totalSkill = 0;
                //foreach (var teamTeam in teamTeamTeam)
                //{
                //    totalSkill += teamTeam.SkillLevel;
                //}
                Console.WriteLine($"Your team's total skill level is {totalSkill}. The banks is {finalBankLevel}");

                if (totalSkill >= finalBankLevel)
                {
                    Console.WriteLine("You did it. Success!");
                    successTotal += 1;
                }
                else
                {
                    Console.WriteLine("Are those sirens? Run failed.");
                }
            }
            Console.WriteLine($"You successfully infiltrated the bank {successTotal} times. You failed {numberOfTries - successTotal} times.");
            Console.ReadLine();
        }
    }
}
