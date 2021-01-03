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
#01 Nastier: KGC Tron (G, Jegantha)
#02 Stefywefy215: Bant Midrange (WUG)
#03 Iceman76: Snoop Goblins (BR)
#04 FranPi: Gifts Storm (UR)
#05 kokoko098: Jeskai Breach (WURG, Jegantha)
#06 Samcaster-Mage: E Tron (C)
#07 Shadowz2005: Grixis Shadow (UBR)
#08 Yamada: Belcher (URG)
#09 Rvng: Mill (UB, Lurrus)
#10 Trailovsky: Jeskai Ascendancy (WURG)
#11 Parrotlet: Uroza (UBG)
#12 SpiderSpace: Mono White Taxes (W, Yorion)
#13 Javipv: Shadow Prowess (BR, Lurrus)
#14 NightKnight131: Heliod Combo (WG)
#15 Frozon: Shadow Prowess (BR, Lurrus)
#16 Senzacolpa: Izzet Control (UR)
#17 Zerito: Bogles (WG, Lurrus)
#18 idutra: Izzet Prowess (UR)
#19 gazurmah: Izzet Control (UR)
#20 Chuki322: Mono White Taxes (W)
#21 _badmoon_: Devoted (WG)
#22 oskiyaa: Devoted (WG)
#23 TuggaNaxos: Sultai Control (UBG)
#24 Maxi1996: Humans (WUBRG)
#25 FirstTimePlayer: Temur Control (URG)
#26 BernardoDG: Reclaimer Titan (WRG)
#27 pedrogush: Hammer Time (WB, Lurrus)
#28 sydneydude: Mono Red Prowess (R)
#29 wutang08: UBRG Shadow (UBRG, Lurrus)
#30 ragingpikey: Spirits (WU)
#31 Mordeka1ser: Enigmatic Incarnation (WUBRG, Yorion)
#32 scorpion87: Oops All Spells (WUBG)
#33 twinlesstwin: Rakdos Midrange (BR)
#34 faisal: WBRG Shadow (WBRG)
#35 Qua4tre: Rakdos Midrange (BR)
#36 fabee1: Boros Taxes (WR, Yorion)
#37 Nextep: Ninja Faeries (UB)
#38 ichi-roku: Ad Nauseam (WUB)
#39 zMunkeyXz: Mill (UBG)
#40 Wuby123: Burn (WR, Lurrus)
#41 ContraEgo: Thopter Urza (WUB)
#42 yumad3988: Simic Control (UG)
#43 kentaro_hokori: WURG Control (WURG)
#44 zumekun19850204: Izzet Control (UR)
#45 Skrug092: Heliod Combo (WG)
#46 billsive: Grinding Breach (URG)
#47 AlphaBlade: Amulet Titan (G)
#48 jupiterbrando: Jeskai Control (WUR)
#49 MagicDevil666: U Tron (UR)
#50 Hazzrd: Neobrand (UG)
#51 Hayseed: Scapeshift (URG)
#52 tcgshin: Titan Shift (RG)
#53 tanisong1221: Sultai Control (UBG)
#54 Bordas99: Dredge (BRG)
#55 Rakdos91: Hardened Scales (BG, Lurrus)
#56 teagantime: Primeval Titan (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_12_29 : EventTest
    {
        [Test]
        public void Deck01_Nastier_KGCTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-12-29",0),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck02_Stefywefy215_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",1),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Iceman76_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-12-29",2),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck04_FranPi_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-29",3),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck05_kokoko098_JeskaiBreach_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-12-29",4),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                typeof(JeskaiBreach),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck06_SamcasterMage_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-12-29",5),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Shadowz2005_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-12-29",6),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Yamada_Belcher_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",7),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Rvng_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-29",8),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Trailovsky_JeskaiAscendancy_WURG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",9),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Parrotlet_Uroza_UBG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",10),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck12_SpiderSpace_MonoWhiteTaxes_W_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-29",11),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck13_Javipv_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-29",12),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_NightKnight131_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",13),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Frozon_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-29",14),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_Senzacolpa_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-29",15),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Zerito_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-29",16),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_idutra_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-29",17),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck19_gazurmah_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-29",18),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Chuki322_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-12-29",19),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck21_badmoon_Devoted_WG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",20),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck22_oskiyaa_Devoted_WG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",21),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck23_TuggaNaxos_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",22),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Maxi1996_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",23),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck25_FirstTimePlayer_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",24),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck26_BernardoDG_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",25),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck27_pedrogush_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-29",26),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_sydneydude_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-12-29",27),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck29_wutang08_UBRGShadow_UBRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-29",28),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_ragingpikey_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-12-29",29),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Mordeka1ser_EnigmaticIncarnation_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-29",30),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(EnigmaticIncarnation),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck32_scorpion87_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",31),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck33_twinlesstwin_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-12-29",32),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck34_faisal_WBRGShadow_WBRG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",33),
                new PostZendikarRising(),
                ArchetypeColor.WBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck35_Qua4tre_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-12-29",34),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck36_fabee1_BorosTaxes_WR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-29",35),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck37_Nextep_NinjaFaeries_UB()
        {
            Test(
                GetDeck("modern-league-2020-12-29",36),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(NinjaFaeries),
                null,
                null
            );
        }

        [Test]
        public void Deck38_ichiroku_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-12-29",37),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck39_zMunkeyXz_Mill_UBG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",38),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck40_Wuby123_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-29",39),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck41_ContraEgo_ThopterUrza_WUB()
        {
            Test(
                GetDeck("modern-league-2020-12-29",40),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck42_yumad3988_SimicControl_UG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",41),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck43_kentarohokori_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",42),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck44_zumekun19850204_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-29",43),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck45_Skrug092_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",44),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck46_billsive_GrindingBreach_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",45),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck47_AlphaBlade_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-league-2020-12-29",46),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck48_jupiterbrando_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-12-29",47),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck49_MagicDevil666_UTron_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-29",48),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Hazzrd_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",49),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck51_Hayseed_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",50),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck52_tcgshin_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",51),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck53_tanisong1221_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",52),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck54_Bordas99_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",53),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck55_Rakdos91_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-29",54),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck56_teagantime_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-league-2020-12-29",55),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }


    }
}
