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
#01 GombleWhop: Humans (WUBRG)
#02 Soondubu: Mono White Taxes (W)
#03 yamakiller: Obosh Aggro (R, Obosh)
#04 McWinSauce: WURG Control (WURG)
#05 cicciogire: WURG Control (WURG)
#06 TheMelkMan: KGC Tron (G)
#07 karatedom: Infect (UG)
#08 lordavery: Bant Midrange (WUG)
#09 MIkepick7: Dredge (BRG)
#10 coert: Merfolk (U)
#11 pokerswizard: Humans (WUBRG)
#12 andrw1232: WURG Control (WURG)
#13 benchsummer: UBRG Shadow (UBRG)
#14 Gobern: Bring To Niv (WUBRG, Yorion)
#15 MartinezDP: Snow Saheeli (WURG, Yorion)
#16 sandydogmtg: Shadow Prowess (WBR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_16 : EventTest
    {
        [Test]
        public void Deck01_GombleWhop_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-16",0),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Soondubu_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-16",1),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck03_yamakiller_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-16",2),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck04_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-16",3),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_cicciogire_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-16",4),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_TheMelkMan_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-16",5),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck07_karatedom_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-16",6),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck08_lordavery_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-16",7),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_MIkepick7_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-16",8),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck10_coert_Merfolk_U()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-16",9),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck11_pokerswizard_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-16",10),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck12_andrw1232_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-16",11),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_benchsummer_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-16",12),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Gobern_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-16",13),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck15_MartinezDP_SnowSaheeli_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-16",14),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(SnowSaheeli),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_sandydogmtg_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-16",15),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
