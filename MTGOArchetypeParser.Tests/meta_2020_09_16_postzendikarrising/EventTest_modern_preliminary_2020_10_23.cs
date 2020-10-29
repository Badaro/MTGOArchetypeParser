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
#01 bigjc00: AmuletTitan (UBRG)
#02 Ihavethefire: MarduMidrange (WBR)
#03 Nammersquats: Infect (UG)
#04 reswax: WURGControl (WURG)
#05 Xwhale: ReclaimerTitan (WRG)
#06 rameison: KGCTron (G)
#07 Bordas99: Dredge (BRG)
#08 PTarts2win: WURGControl (WURG)
#09 lordavery: BantMidrange (WUG)
#10 ecobaronen: WURGControl (WURG)
#11 GombleWhop: Humans (WUBRG)
#12 QuaCk QuaCk: Humans (WUBRG)
#13 NosonosaN: WURGControl (WURG)
#14 mario7389: Burn (WRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_23 : EventTest
    {
        [Test]
        public void Deck01_bigjc00_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",0),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck02_Ihavethefire_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",1),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Nammersquats_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",2),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck04_reswax_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",3),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Xwhale_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",4),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck06_rameison_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",5),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck07_Bordas99_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",6),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck08_PTarts2win_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",7),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_lordavery_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",8),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_ecobaronen_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",9),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_GombleWhop_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",10),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck12_QuaCkQuaCk_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",11),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck13_NosonosaN_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",12),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_mario7389_Burn_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-23",13),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }


    }
}
