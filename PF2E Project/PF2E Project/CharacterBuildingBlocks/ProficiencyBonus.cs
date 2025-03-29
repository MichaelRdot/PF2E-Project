using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PF2E_Project.CharacterBuildingBlocks
{
    public class ProficiencyBonus
    {
        public enum ProficiencyBonusValue
        {
            Untrained,
            Trained = 2,
            Expert = 4,
            Master = 6,
            Legendary = 8
        }
        public static string ProficiencyBonusName(ProficiencyBonusValue PB)
        {
            switch (PB)
            {
                case ProficiencyBonusValue.Untrained:
                    return "Untrained";
                case ProficiencyBonusValue.Trained:
                    return "Trained";
                case ProficiencyBonusValue.Expert:
                    return "Expert";
                case ProficiencyBonusValue.Master:
                    return "Master";
                case ProficiencyBonusValue.Legendary:
                    return "Legendary";
                default:
                    return "Invalid Proficiency Bonus";
            }
        }
        public static char ProficiencyBonusInitial(ProficiencyBonusValue PB) => ProficiencyBonusName(PB)[0];
    }
}