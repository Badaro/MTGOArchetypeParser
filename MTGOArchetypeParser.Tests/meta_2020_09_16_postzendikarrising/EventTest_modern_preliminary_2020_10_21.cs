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
#01 Kiwairay: OopsAllSpells (WUBRG)
#02 stayrospet: SaheeliCombo (WURG, Jegantha)
#03 HouseOfManaMTG: AmuletTitan (UBRG)
#04 tkcheungab: KGCTron (G)
#05 Moniz0801: PrimevalTitan (WRG)
#06 iL_Tedesco: AbzanMidrange (WBG)
#07 yoshiwata: MonoWhiteTaxes (W)
#08 taruto1212: WURGControl (WURG)
#09 mxlzxk: ShadowProwess (WBR, Lurrus)
#10 Snugglie: JundMidrange (BRG)
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
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck02_stayrospet_SaheeliCombo_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-21",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck03_HouseOfManaMTG_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-21",2),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck04_tkcheungab_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-21",3),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck05_Moniz0801_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-21",4),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck06_iLTedesco_AbzanMidrange_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-21",5),
                new PostZendikarRising(),
                ArchetypeColor.WBG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_yoshiwata_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-21",6),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck08_taruto1212_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-21",7),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_mxlzxk_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-21",8),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Snugglie_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-21",9),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
