using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PF2E_Project;
using PF2E_Project.CharacterBuildingBlocks;
using static PF2E_Project.CharacterBuildingBlocks.ProficiencyBonus;

namespace PF2E_Project.CharacterBuildingBlocks
{
    class Skill
    {
        private string skillName;
        private int skillValue;
        private ProficiencyBonusValue proficiencyBonus;
        public Skill()
        {
            skillName = "N/A";
            skillValue = 0;
            proficiencyBonus = 0;
        }

        public Skill(string skillName, int skillValue, ProficiencyBonusValue proficiencyBonus)
        {
            this.skillName = skillName;
            this.skillValue = skillValue;
            this.proficiencyBonus = proficiencyBonus;
        }

        public string GetSkillName() { return skillName; }
        public int GetSkillValue() { return skillValue; }
        public int GetProficiencyBonusValue() { return (int)proficiencyBonus; }
        public string GetProficiencyBonusName() { return ProficiencyBonus.ProficiencyBonusName(proficiencyBonus); }
        public char GetProficiencyBonusInitial() { return ProficiencyBonus.ProficiencyBonusInitial(proficiencyBonus); }
    }
}