using System;
using System.Collections.Generic;
using System.Text;

namespace NewHeist
{
    class TeamMember
    {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public decimal CourageFactor { get; set; }

        public TeamMember(string name, int skillLevel, decimal courageFactor)
        {
            Name = name;
            SkillLevel = skillLevel;
            CourageFactor = courageFactor;
        }
    }
}
