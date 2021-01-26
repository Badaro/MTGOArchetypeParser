using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Kiwairay: Oops All Spells (WUBRG)
#02 stayrospet: Omnath Saheeli (WURG, Jegantha)
#03 HouseOfManaMTG: Amulet Titan (RG)
#04 tkcheungab: Green Tron (G)
#05 Moniz0801: Reclaimer Titan (WRG)
#06 iL_Tedesco: Abzan Midrange (WBG)
#07 yoshiwata: Mono White Taxes (W)
#08 taruto1212: WURG Control (WURG)
#09 mxlzxk: Shadow Prowess (WBR, Lurrus)
#10 Snugglie: Jund Midrange (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_21 : EventTest
    {
        [Test]
        public void Deck01_Kiwairay_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-21",0),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck02_stayrospet_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-21",1),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "SaheeliCombo",
                "OmnathSaheeli",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck03_HouseOfManaMTG_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-21",2),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck04_tkcheungab_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-21",3),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck05_Moniz0801_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-21",4),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck06_iLTedesco_AbzanMidrange_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-21",5),
                "PostZendikarRising",
                ArchetypeColor.WBG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_yoshiwata_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-21",6),
                "PostZendikarRising",
                ArchetypeColor.W,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck08_taruto1212_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-21",7),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck09_mxlzxk_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-21",8),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Snugglie_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-21",9),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}
