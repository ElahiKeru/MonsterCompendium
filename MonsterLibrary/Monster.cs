using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MonsterLibrary
{
    public class Monster
    {
        #region Properties
        public string Name { get; private set; }
        public string Size { get; private set; }
        public string Type { get; private set; }
        public string SubType { get; private set; }
        public string Alignment { get; private set; }
        public int ArmorClass { get; private set; }
        public int HitPoints { get; private set; }
        public int HitDice { get; private set; }
        public int DiceType { get; private set; }
        public string Speed { get; private set; }
        public int Strength { get; private set; }
        public int StrengthMod { get; private set; }
        public int Dexterity { get; private set; }
        public int DexterityMod { get; private set; }
        public int Constitution { get; private set; }
        public int ConstitutionMod { get; private set; }
        public int Intelligence { get; private set; }
        public int IntelligenceMod { get; private set; }
        public int Wisdom { get; private set; }
        public int WisdomMod { get; private set; }
        public int Charisma { get; private set; }
        public int CharismaMod { get; private set; }
        public string Saves { get; private set; }
        public string Skills { get; private set; }
        public string DamageVuln { get; private set; }
        public string DamageRes { get; private set; }
        public string DamageImmune { get; private set; }
        public string ConditionImmune { get; private set; }
        public string Senses { get; private set; }
        public string Languages { get; set; }
        public string Challenge { get; private set; }
        public string XP { get; private set; }
        public string Features { get; private set; }
        public string Actions { get; private set; }
        public string Notes { get; private set; }
        #endregion

        public Monster(XmlNode xnd)
        {
            Name = xnd["name"].InnerText;
            Size = xnd["size"].InnerText;
            Type = xnd["type"].InnerText;
            SubType = xnd["subtype"].InnerText;
            Alignment = xnd["alignment"].InnerText;
            ArmorClass = int.Parse(xnd["armorclass"].InnerText);
            HitPoints = int.Parse(xnd["hitpoints"].InnerText);
            HitDice = int.Parse(xnd["hitdice"].InnerText);
            DiceType = int.Parse(xnd["dicetype"].InnerText);
            Speed = xnd["speed"].InnerText;
            Strength = int.Parse(xnd["strength"].InnerText);
            StrengthMod = (int)Math.Floor((double)(Strength - 10) / 2);
            Dexterity = int.Parse(xnd["dexterity"].InnerText);
            DexterityMod = (int)Math.Floor((double)(Dexterity - 10) / 2);
            Constitution = int.Parse(xnd["constitution"].InnerText);
            ConstitutionMod = (int)Math.Floor((double)(Constitution - 10) / 2);
            Intelligence = int.Parse(xnd["intelligence"].InnerText);
            IntelligenceMod = (int)Math.Floor((double)(Intelligence - 10) / 2);
            Wisdom = int.Parse(xnd["wisdom"].InnerText);
            WisdomMod = (int)Math.Floor((double)(Wisdom - 10) / 2);
            Charisma = int.Parse(xnd["charisma"].InnerText);
            CharismaMod = (int)Math.Floor((double)(Charisma - 10) / 2);
            Saves = xnd["saves"].InnerText;
            Skills = xnd["skills"].InnerText;
            DamageVuln = xnd["damagevuln"].InnerText;
            DamageRes = xnd["damageres"].InnerText;
            DamageImmune = xnd["damageimmune"].InnerText;
            ConditionImmune = xnd["conditionimmune"].InnerText;
            Senses = xnd["senses"].InnerText;
            Languages = xnd["languages"].InnerText;
            Challenge = xnd["challenge"].InnerText;
            XP = xnd["xp"].InnerText;
            Features = xnd["features"].InnerText;
            Actions = xnd["actions"].InnerText;
            Notes = xnd["notes"].InnerText;
        }

        public Monster(Monster clone)
        {
            Name = clone.Name;
            Size = clone.Size;
            Type = clone.Type;
            SubType = clone.SubType;
            Alignment = clone.Alignment;
            ArmorClass = clone.ArmorClass;
            HitPoints = clone.HitPoints;
            HitDice = clone.HitDice;
            DiceType = clone.DiceType;
            Speed = clone.Speed;
            Strength = clone.Strength;
            StrengthMod = clone.StrengthMod;
            Dexterity = clone.Dexterity;
            DexterityMod = clone.DexterityMod;
            Constitution = clone.Constitution;
            ConstitutionMod = clone.ConstitutionMod;
            Intelligence = clone.Intelligence;
            IntelligenceMod = clone.IntelligenceMod;
            Wisdom = clone.Wisdom;
            WisdomMod = clone.WisdomMod;
            Charisma = clone.Charisma;
            CharismaMod = clone.CharismaMod;
            Saves = clone.Saves;
            Skills = clone.Skills;
            DamageVuln = clone.DamageVuln;
            DamageRes = clone.DamageRes;
            DamageImmune = clone.DamageImmune;
            ConditionImmune = clone.ConditionImmune;
            Senses = clone.Senses;
            Languages = clone.Languages;
            Challenge = clone.Challenge;
            XP = clone.XP;
            Features = clone.Features;
            Actions = clone.Actions;
            Notes = clone.Notes;

        }
    }
}