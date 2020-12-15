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
#01 ht991122: WURG Control (WURG)
#02 JV_7777: WURG Control (WURG)
#03 kiko: Azorius Taxes (WU, Yorion)
#04 tzio: Orzhov Midrange (WB)
#05 GrandDrou: Shadow Prowess (WBR, Lurrus)
#06 Jack_Kashtan: Izzet Control (UR)
#07 TuralyonMap: Spirits (WU)
#08 Violent_Outburst: WURG Control (WURG)
#09 otakkun: WURG Control (WURG)
#10 gyyby297: Oops All Spells (WUBG)
#11 Lucabireskusku: Izzet Control (UR)
#12 AlpInco: Oops All Spells (WUBG)
#13 SanPop: Oops All Spells (WUBG)
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
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_JV7777_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_kiko_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",2),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_tzio_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",3),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_GrandDrou_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",4),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_JackKashtan_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",5),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_TuralyonMap_Spirits_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",6),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck08_ViolentOutburst_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",7),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_otakkun_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",8),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_gyyby297_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",9),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Lucabireskusku_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",10),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_AlpInco_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",11),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck13_SanPop_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-11",12),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }


    }
}