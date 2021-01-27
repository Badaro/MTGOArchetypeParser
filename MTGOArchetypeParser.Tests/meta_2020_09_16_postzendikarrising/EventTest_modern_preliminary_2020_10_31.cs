using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 JUJUBEAN__2004: UBRG Control (UBRG)
#02 Theo_Jung: Reclaimer Titan (WRG)
#03 Coronthemoron: Oops All Spells (WUBRG)
#04 ChironTheMage: Jeskai Control (WUR)
#05 exoticherman: Jund Shadow (BRG)
#06 polishdynamit3: Shadow Prowess (WBR, Lurrus)
#07 Bunnykept: Heliod Combo (WG)
#08 eclipse4343: Miracles (WU)
#09 Leviathan102: Amulet Titan (RG)
#10 random_deck: Selesnya Midrange (WG)
#11 ice_nine_: Land Destruction (WR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_31 : EventTest
    {
        [Test]
        public void Deck01_JUJUBEAN2004_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-31",0),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_TheoJung_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-31",1),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck03_Coronthemoron_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-31",2),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck04_ChironTheMage_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-31",3),
                "PostZendikarRising",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_exoticherman_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-31",4),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck06_polishdynamit3_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-31",5),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Bunnykept_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-31",6),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck08_eclipse4343_Miracles_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-31",7),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Miracles",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Leviathan102_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-31",8),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck10_randomdeck_SelesnyaMidrange_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-31",9),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck11_icenine_LandDestruction_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-31",10),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "LandDestruction",
                null,
                null
            );
        }


    }
}
