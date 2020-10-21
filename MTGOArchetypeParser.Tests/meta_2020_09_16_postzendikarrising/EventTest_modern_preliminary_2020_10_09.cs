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
#01 McWinSauce: WURGControl (WURG)
#02 Draccon136: Bogles (WG, Lurrus)
#03 Jaberwocki: JundMidrange (BRG)
#04 lordavery: BantMidrange (WUG)
#05 Mcleskey: OboshAggro (R, Obosh)
#06 TheMelkMan: ETron (C)
#07 Bohnz: WURGControl (WURG)
#08 Rav104: OopsAllSpells (WUBRG)
#09 timewalkinonsunshine: TakingTurns (URG)
#10 wambocombo2020: ShadowProwess (WBR, Lurrus)
#11 Clockwork Dean: MonoWhiteTaxes (W)
#12 yamakiller: PrimevalTitan (WRG)
#13 ziofrancone: Elementals (WURG)
#14 maikage: Belcher (RG)
#15 karatedom: Crabvine (UBG)
#16 AbelMolto: Burn (WRG)
#17 Gobern: BringToNiv (WUBRG, Yorion)
#18 tibalt_of_red_sub: Mill (UB, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_10_09 : EventTest
    {
        [Test]
        public void Deck01_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",0),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Draccon136_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",1),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Jaberwocki_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",2),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_lordavery_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",3),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Mcleskey_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",4),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck06_TheMelkMan_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",5),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Bohnz_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",6),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Rav104_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",7),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck09_timewalkinonsunshine_TakingTurns_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",8),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(TakingTurns),
                null,
                null
            );
        }

        [Test]
        public void Deck10_wambocombo2020_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",9),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_ClockworkDean_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",10),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck12_yamakiller_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",11),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck13_ziofrancone_Elementals_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",12),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck14_maikage_Belcher_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",13),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck15_karatedom_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",14),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck16_AbelMolto_Burn_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",15),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Gobern_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",16),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_tibaltofredsub_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-10-09",17),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
