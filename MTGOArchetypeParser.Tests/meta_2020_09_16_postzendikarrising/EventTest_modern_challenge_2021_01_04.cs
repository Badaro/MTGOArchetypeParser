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
#01 pedrogush: Hammer Time (WB, Lurrus)
#02 triosk: Hammer Time (WB, Lurrus)
#03 Laplasjan: Hammer Time (WB, Lurrus)
#04 katoriarch123: WURG Control (WURG)
#05 paucr5: Hammer Time (WB, Lurrus)
#06 ACG88: Spirits (WU)
#07 B1gDan: Shadow Prowess (BR, Lurrus)
#08 Lord_Beerus: Burn (WR)
#09 slamanscott1228: Bant Midrange (WUG)
#10 r64v3a: Reclaimer Titan (WUG)
#11 Arrias: Heliod Combo (WG)
#12 ajifly: Devoted (WG, Lurrus)
#13 joker10289: Sultai Control (UBG)
#14 PieGonti: Belcher (BRG)
#15 pokerswizard: Temur Control (URG)
#16 penips: Mono White Taxes (W)
#17 CrusherBotBG: Hammer Time (W, Lurrus)
#18 Sommertroll: Humans (WUBRG)
#19 Nekonii: Dredge (BRG)
#20 xame3: Burn (WR)
#21 _Marian_: Primeval Titan (UG)
#22 Mussie99: Sultai Control (UBG)
#23 mark_68: Sultai Control (UBG)
#24 toondoslav: Infect (UG)
#25 2radMTG: Amulet Titan (G)
#26 Ibaitor: Taking Turns (UR)
#27 TSPJendrek: Bant Control (WUG)
#28 EmErgy: Bant Midrange (WUG)
#29 Nastier: KGC Tron (G, Jegantha)
#30 Rosencrantz_920: KGC Amulet Titan (G)
#31 MaxMagicer: Omnath Saheeli (WURG, Jegantha)
#32 ichi-roku: Ad Nauseam (WUB)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2021_01_04 : EventTest
    {
        [Test]
        public void Deck01_pedrogush_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",0),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_triosk_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",1),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Laplasjan_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",2),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_katoriarch123_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",3),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_paucr5_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",4),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_ACG88_Spirits_WU()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",5),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck07_B1gDan_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",6),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_LordBeerus_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",7),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck09_slamanscott1228_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",8),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_r64v3a_ReclaimerTitan_WUG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",9),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck11_Arrias_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",10),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck12_ajifly_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",11),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_joker10289_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",12),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_PieGonti_Belcher_BRG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",13),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck15_pokerswizard_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",14),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_penips_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",15),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck17_CrusherBotBG_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",16),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_Sommertroll_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",17),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Nekonii_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",18),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck20_xame3_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",19),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Marian_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",20),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Mussie99_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",21),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_mark68_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",22),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_toondoslav_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",23),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck25_2radMTG_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",24),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck26_Ibaitor_TakingTurns_UR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",25),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(TakingTurns),
                null,
                null
            );
        }

        [Test]
        public void Deck27_TSPJendrek_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",26),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck28_EmErgy_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",27),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Nastier_KGCTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",28),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GreenTron),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck30_Rosencrantz920_KGCAmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",29),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck31_MaxMagicer_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",30),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck32_ichiroku_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2021-01-04",31),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }


    }
}
