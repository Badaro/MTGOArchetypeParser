using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Text.RegularExpressions;

namespace MTGOArchetypeParser.Model
{
    public abstract class Archetype
    {
        public string Name { get; set; }

        public bool IncludeColorInName { get; set; }

        public string GetName(ArchetypeColor color)
        {
            string name = this.Name.Replace("Generic", "");

            if (IncludeColorInName)
            {
                string colorName = GetColorName(color);
                name = colorName + name;
            }

            // Source: https://stackoverflow.com/questions/3216085/split-a-pascalcase-string-into-separate-words
            name = new Regex(@"(?<=[A-Z])(?=[A-Z][a-z])|(?<=[^A-Z])(?=[A-Z])|(?<=[A-Za-z])(?=[^A-Za-z])").Replace(name, " ");
            name = new Regex("\\s+").Replace(name, " ");

            return name;
        }

        public override string ToString()
        {
            return this.Name;
        }

        public virtual int GetComplexity()
        {
            return Int32.MaxValue;
        }

        private string GetColorName(ArchetypeColor color)
        {
            switch (color)
            {
                case ArchetypeColor.W:
                    return $"MonoWhite";
                case ArchetypeColor.U:
                    return $"MonoBlue";
                case ArchetypeColor.B:
                    return $"MonoBlack";
                case ArchetypeColor.R:
                    return $"MonoRed";
                case ArchetypeColor.G:
                    return $"MonoGreen";
                case ArchetypeColor.WU:   // Azorius
                    return $"Azorius";
                case ArchetypeColor.WB:   // Orzhov
                    return $"Orzhov";
                case ArchetypeColor.WR:   // Boros
                    return $"Boros";
                case ArchetypeColor.WG:   // Selesnya
                    return $"Selesnya";
                case ArchetypeColor.UB:   // Dimir
                    return $"Dimir";
                case ArchetypeColor.UR:   // Izzet
                    return $"Izzet";
                case ArchetypeColor.UG:   // Simic
                    return $"Simic";
                case ArchetypeColor.BR:   // Rakdos
                    return $"Rakdos";
                case ArchetypeColor.BG:   // Golgari
                    return $"Golgari";
                case ArchetypeColor.RG:   // Gruul
                    return $"Gruul";
                case ArchetypeColor.WUB:  // Esper
                    return $"Esper";
                case ArchetypeColor.WUR:  // Jeskai
                    return $"Jeskai";
                case ArchetypeColor.WUG:  // Bant
                    return $"Bant";
                case ArchetypeColor.WBR:  // Mardu
                    return $"Mardu";
                case ArchetypeColor.WBG:  // Abzan
                    return $"Abzan";
                case ArchetypeColor.WRG:  // Naya
                    return $"Naya";
                case ArchetypeColor.UBR:  // Grixis
                    return $"Grixis";
                case ArchetypeColor.UBG:  // Sultai
                    return $"Sultai";
                case ArchetypeColor.URG:  // Temur
                    return $"Temur";
                case ArchetypeColor.BRG:  // Jund
                    return $"Jund";
                case ArchetypeColor.WUBR: // Not-G
                    return $"WUBR";
                case ArchetypeColor.WBRG: // Not-U
                    return $"WBRG";
                case ArchetypeColor.WUBG: // Not-R
                    return $"WUBG";
                case ArchetypeColor.WURG: // Not-B
                    return $"WURG";
                case ArchetypeColor.UBRG: // Not-W
                    return $"UBRG";
                case ArchetypeColor.WUBRG:
                    return $"5Color";
                default:
                    return "";
            }
        }
    }

    public class ArchetypeSpecific : Archetype
    {
        public ArchetypeCondition[] Conditions { get; set; }
        public ArchetypeVariant[] Variants { get; set; }

        public override int GetComplexity()
        {
            return this.Conditions.Length;
        }
    }

    public class ArchetypeVariant : ArchetypeSpecific
    {
    }

    public class ArchetypeGeneric : Archetype
    {
        public string[] CommonCards { get; set; }
    }
}
