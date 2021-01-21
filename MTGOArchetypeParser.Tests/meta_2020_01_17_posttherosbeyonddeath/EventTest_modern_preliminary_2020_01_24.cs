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
#01 JustBurn420: Slivers (WUBRG)
#02 Tiemuuu: Izzet Control (UR)
#03 Janh: Saheeli Combo (WUR)
#04 timmojay: Green Tron (G)
#05 BReal2: Mardu Midrange (WBR)
#06 Waumpus: Bant Midrange (WUG)
#07 SourceOdin: Primeval Titan (UG)
#08 yamakiller: Eldrazi Tron (G)
#09 PRGJJAR: Dredge (BRG)
#10 Nammersquats: Mono Red Prowess (R)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_01_24 : EventTest
    {
        [Test]
        public void Deck01_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-24",0),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUBRG,
                "Slivers",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-24",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Janh_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-24",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUR,
                "SaheeliCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck04_timmojay_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-24",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck05_BReal2_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-24",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.WBR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Waumpus_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-24",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_SourceOdin_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-24",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck08_yamakiller_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-24",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck09_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-24",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Nammersquats_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-24",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }


    }
}
