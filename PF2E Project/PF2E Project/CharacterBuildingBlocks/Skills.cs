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
        private sbyte skillValue;
        private ProficiencyBonusValue proficiencyBonus;
        private Attribute skillAttribute;
        public Skill(string skillName, ProficiencyBonusValue proficiencyBonus, Attribute skillAttribute)
        {
            this.skillName = skillName;
            this.proficiencyBonus = proficiencyBonus;
            this.skillAttribute = skillAttribute;
            this.skillValue = (sbyte) (skillAttribute.GetAttributeModifier() + (byte)proficiencyBonus);
        }

        public string GetSkillName() => skillName; 
        public sbyte GetSkillValue() => skillValue;
        public byte GetProficiencyBonusValue() => (byte)proficiencyBonus; 
        public string GetProficiencyBonusName() => ProficiencyBonus.ProficiencyBonusName(proficiencyBonus);
        public char GetProficiencyBonusInitial() => ProficiencyBonus.ProficiencyBonusInitial(proficiencyBonus);
        public Attribute GetSkillAttribute() => skillAttribute;
    }
}