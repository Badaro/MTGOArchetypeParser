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
#01 pepeteam: Amulet Titan (UG)
#02 osmanozguney: Rakdos Midrange (BR)
#03 azatoyellow: Mono Red Prowess (R)
#04 ACG88: Crabvine (UBG)
#05 WingedHussar: Neobrand (UG)
#06 bubbsei: Devoted (WG, Lurrus)
#07 LickNsticK: Jund Midrange (BRG)
#08 RicardoMSLan: Eldrazi Tron (C)
#09 PizzaRolls: Eldrazi Tron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_preliminary_2020_07_14 : EventTest
    {
        [Test]
        public void Deck01_pepeteam_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-14",0),
                "PostM21",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck02_osmanozguney_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-14",1),
                "PostM21",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck03_azatoyellow_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-14",2),
                "PostM21",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck04_ACG88_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-14",3),
                "PostM21",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck05_WingedHussar_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-14",4),
                "PostM21",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck06_bubbsei_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-14",5),
                "PostM21",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_LickNsticK_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-14",6),
                "PostM21",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck08_RicardoMSLan_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-14",7),
                "PostM21",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck09_PizzaRolls_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-14",8),
                "PostM21",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }


    }
}
