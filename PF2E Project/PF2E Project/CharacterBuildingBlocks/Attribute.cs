using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace PF2E_Project.CharacterBuildingBlocks
{
    public class Attribute
    {
        private string AttributeName;
        private string AttributeShortHand;
        private byte AttributeValue;
        public Attribute(string AttributeName,string AttributeShortHand, byte AttributeValue)
        {
            this.AttributeName = AttributeName;
            this.AttributeShortHand = AttributeShortHand;
            this.AttributeValue = AttributeValue;
        }
        public sbyte GetAttributeModifier() => (sbyte) (Math.Floor((double)AttributeValue / 2) - 5);
        public string GetAttributeName() => AttributeName;
        public string GetAttributShortHand() => AttributeShortHand;
        public byte GetAttributeValue() => AttributeValue;
    }
}
