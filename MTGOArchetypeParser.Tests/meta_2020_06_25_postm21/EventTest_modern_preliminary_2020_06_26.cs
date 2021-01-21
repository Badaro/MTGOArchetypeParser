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
#01 MindOfAKid: Burn (WR, Lurrus)
#02 Trisky: Gruul Midrange (RG)
#03 staples87: Eldrazi Tron (C)
#04 Misplacedginger: Bant Control (WUG)
#05 samslam: Burn (WR)
#06 yamakiller: Neobrand (UG)
#07 qbturtle15: Gruul Midrange (RG, Obosh)
#08 no_lyfe: Mono Red Prowess (R)
#09 tyty123: Gruul Midrange (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_preliminary_2020_06_26 : EventTest
    {
        [Test]
        public void Deck01_MindOfAKid_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-26",0),
                "PostM21",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_Trisky_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-26",1),
                "PostM21",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck03_staples87_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-26",2),
                "PostM21",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck04_Misplacedginger_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-26",3),
                "PostM21",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_samslam_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-26",4),
                "PostM21",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck06_yamakiller_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-26",5),
                "PostM21",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck07_qbturtle15_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-26",6),
                "PostM21",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck08_nolyfe_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-26",7),
                "PostM21",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck09_tyty123_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-26",8),
                "PostM21",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}
