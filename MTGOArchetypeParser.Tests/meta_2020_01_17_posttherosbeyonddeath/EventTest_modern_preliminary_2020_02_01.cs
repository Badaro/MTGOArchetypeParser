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
#01 Boland: Grixis Shadow (UBR)
#02 Accelerator_GTR: Jund Midrange (BRG)
#03 thepensword: Izzet Control (UR)
#04 Mark_Confidant: Devoted (WBG)
#05 penips: Orzhov Taxes (WB)
#06 Swarm_OF_Mats: WURG Control (WURG)
#07 Wolvenjoe1984: Thopter Urza (UB)
#08 quinniac: Ad Nauseam (WUB)
#09 dasalmon: Jund Midrange (BRG)
#10 JustBurn420: Slivers (WUBRG)
#11 xakx47x: Heliod Combo (WBG)
#12 Nammersquats: Mono Red Prowess (R)
#13 brueck4: Izzet Control (UR)
#14 MiamiKidz: Amulet Titan (UG)
#15 ItC-Dahoonya: WURG Control (WURG)
#16 Sonic_Smasher: Uroza (UBG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_02_01 : EventTest
    {
        [Test]
        public void Deck01_Boland_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-01",0),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck02_AcceleratorGTR_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-01",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck03_thepensword_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-01",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_MarkConfidant_Devoted_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-01",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.WBG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck05_penips_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-01",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.WB,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck06_SwarmOFMats_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-01",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Wolvenjoe1984_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-01",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck08_quinniac_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-01",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck09_dasalmon_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-01",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck10_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-01",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUBRG,
                "Slivers",
                null,
                null
            );
        }

        [Test]
        public void Deck11_xakx47x_HeliodCombo_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-01",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.WBG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Nammersquats_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-01",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck13_brueck4_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-01",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck14_MiamiKidz_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-01",13),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck15_ItCDahoonya_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-01",14),
                "PostTherosBeyondDeath",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck16_SonicSmasher_Uroza_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-01",15),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBG,
                "Uroza",
                null,
                null
            );
        }


    }
}
