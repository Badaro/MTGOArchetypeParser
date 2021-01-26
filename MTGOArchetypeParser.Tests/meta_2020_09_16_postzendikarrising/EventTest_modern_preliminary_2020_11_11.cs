using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 ht991122: WURG Control (WURG)
#02 JV_7777: WURG Control (WURG)
#03 kiko: Azorius Taxes (WU, Yorion)
#04 tzio: Orzhov Midrange (WB)
#05 GrandDrou: Shadow Prowess (WBR, Lurrus)
#06 Jack_Kashtan: Jeskai Control (WUR)
#07 TuralyonMap: Spirits (WU)
#08 Violent_Outburst: WURG Control (WURG)
#09 otakkun: WURG Control (WURG)
#10 gyyby297: Oops All Spells (WUBRG)
#11 Lucabireskusku: Izzet Control (UR)
#12 AlpInco: Oops All Spells (WUBRG)
#13 SanPop: Oops All Spells (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_11_11 : EventTest
    {
        [Test]
        public void Deck01_ht991122_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",0),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_JV7777_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",1),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_kiko_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",2),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Taxes",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_tzio_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",3),
                "PostZendikarRising",
                ArchetypeColor.WB,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck05_GrandDrou_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",4),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_JackKashtan_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",5),
                "PostZendikarRising",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_TuralyonMap_Spirits_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",6),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck08_ViolentOutburst_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",7),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck09_otakkun_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",8),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_gyyby297_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",9),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Lucabireskusku_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",10),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck12_AlpInco_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",11),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }

        [Test]
        public void Deck13_SanPop_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",12),
                "PostZendikarRising",
                ArchetypeColor.WUBRG,
                "OopsAllSpells",
                null,
                null
            );
        }


    }
}
