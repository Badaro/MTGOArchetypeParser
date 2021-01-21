using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 trader08111: Gruul Midrange (RG)
#02 Violent_Outburst: Scapeshift (URG)
#03 mogis67: Reclamation (UBG)
#04 Gerschi: Mardu Prowess (WBR, Lurrus)
#05 Samlg01: Amulet Titan (RG)
#06 _Stream: Izzet Prowess (UR)
#07 IntegralHDK: Jund Midrange (BRG)
#08 aarongulevich: Izzet Prowess (UR)
#09 ilsecco14: Sultai Control (UBG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_09_12 : EventTest
    {
        [Test]
        public void Deck01_trader08111_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-12",0),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck02_ViolentOutburst_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-12",1),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck03_mogis67_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-12",2),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Gerschi_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-12",3),
                "PostAstrolabeBan",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Samlg01_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-12",4),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck06_Stream_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-12",5),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck07_IntegralHDK_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-12",6),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck08_aarongulevich_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-12",7),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck09_ilsecco14_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-12",8),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
