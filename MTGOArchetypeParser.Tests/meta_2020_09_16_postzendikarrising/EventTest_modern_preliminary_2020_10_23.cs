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
#01 bigjc00: Amulet Titan (RG)
#02 Ihavethefire: Mardu Midrange (WBR)
#03 Nammersquats: Infect (UG)
#04 reswax: WURG Control (WURG)
#05 Xwhale: Reclaimer Titan (WRG)
#06 rameison: Green Tron (G)
#07 Bordas99: Dredge (BRG)
#08 PTarts2win: WURG Control (WURG)
#09 lordavery: Bant Midrange (WUG)
#10 ecobaronen: WURG Control (WURG)
#11 GombleWhop: Humans (WUBRG)
#12 QuaCk QuaCk: Humans (WUBRG)
#13 NosonosaN: WURG Control (WURG)
#14 mario7389: Burn (WRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_23 : EventTest
    {
        [Test]
        public void Deck01_bigjc00_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",0),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck02_Ihavethefire_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",1),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Nammersquats_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",2),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck04_reswax_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",3),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Xwhale_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",4),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck06_rameison_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",5),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck07_Bordas99_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",6),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck08_PTarts2win_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",7),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck09_lordavery_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",8),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck10_ecobaronen_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",9),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_GombleWhop_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",10),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck12_QuaCkQuaCk_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",11),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck13_NosonosaN_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",12),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck14_mario7389_Burn_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",13),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "RedAggro",
                "Burn",
                null
            );
        }


    }
}
