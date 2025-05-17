using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PF2E_Project;
using PF2E_Project.CharacterBuildingBlocks;
using static PF2E_Project.CharacterBuildingBlocks.Attribute;
namespace PF2E_Project
{
    public class Character()
    {
        private PF2E_Project.CharacterBuildingBlocks.Attribute Str = new PF2E_Project.CharacterBuildingBlocks.Attribute("Strength", "Str", 10);;
        private PF2E_Project.CharacterBuildingBlocks.Attribute Dex = new PF2E_Project.CharacterBuildingBlocks.Attribute("Dexterity", "Dex", 10);;
        private PF2E_Project.CharacterBuildingBlocks.Attribute Cha = new PF2E_Project.CharacterBuildingBlocks.Attribute("Charisma", "Cha", 10);;
        private PF2E_Project.CharacterBuildingBlocks.Attribute Con = new PF2E_Project.CharacterBuildingBlocks.Attribute("Constitution", "Con", 10);;
        private PF2E_Project.CharacterBuildingBlocks.Attribute Int = new PF2E_Project.CharacterBuildingBlocks.Attribute("Intelligence", "Int", 10);;
        private PF2E_Project.CharacterBuildingBlocks.Attribute Wis = new PF2E_Project.CharacterBuildingBlocks.Attribute("Wisdom", "Wis", 10);
        private string name = "";
        public Character(string name)
        {
            this.name = name;

        }
    }
}