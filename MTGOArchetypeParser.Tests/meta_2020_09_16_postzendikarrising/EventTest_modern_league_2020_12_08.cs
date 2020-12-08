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
#01 moutierdu42: Reclaimer Titan (WRG)
#02 Vashezzo: Niv To Light (WUBRG, Yorion)
#03 vasko19: Izzet Restore Balance (UR)
#04 MegaMollt: Gifts Storm (UR)
#05 Kontrabanda: Amulet Titan (RG)
#06 Ivc: Azorius Control (WU)
#07 RyanWu: Jund Midrange (BRG)
#08 CptGrumblecakes: Abzan Company (WBG)
#09 Rulleboren: Hammer Time (WG, Lurrus)
#10 Dirk513: Oops All Spells (WUBG)
#11 Trailovsky: Shadow Prowess (BR, Lurrus)
#12 StreexIT: Neobrand (UG)
#13 qbturtle15: Burn (WRG, Lurrus)
#14 Busterbrown52: Elementals (WUBRG)
#15 mashmalovsky: Ad Nauseam (WUB)
#16 Kurusu: Kiki Chord (WURG, Yorion)
#17 Frutuoso: Gruul Midrange (RG)
#18 Lucabireskusku: WURG Control (WURG)
#19 mechrataal: Izzet Control (UR)
#20 MTGnextlevel: Obosh Aggro (R, Obosh)
#21 Sodeq: Dredge (BRG)
#22 merliche: Winota (WR, Yorion)
#23 tcgshin: Titan Shift (RG)
#24 smoran02: Mill (UB, Lurrus)
#25 _Ditlev_: Mono Red Prowess (R)
#26 SvenSveeterSven: Mardu Midrange (WBR)
#27 marcofabrizi: Bant Midrange (WUG)
#28 Ryan_39: Sultai Control (UBG)
#29 xame3: Burn (WR, Lurrus)
#30 CaptainFarbosa: Sultai Control (UBG)
#31 Nextep: Izzet Control (UR)
#32 Orpheus819: Mill (UB, Lurrus)
#33 J0SE: Heliod Combo (WG)
#34 bcs8995: Izzet Control (UR)
#35 jrussellanderson: KGC Tron (G, Jegantha)
#36 moosedroppings: Heliod Combo (WR)
#37 Jezz-: Izzet Prowess (UR)
#38 ShutoShotokan: Humans (WUBRG)
#39 WoodwardUppr: Bant Spirits (WUG)
#40 Boucha: Belcher (URG)
#41 Woooter: Bant Blink (WUG)
#42 IPlayBadDecks: Yawgmoth (BG)
#43 jsphfcll: Eight Rack (WB)
#44 adriaferrer: Sultai Control (UBG)
#45 MastaHorus: Izzet Living End (UR)
#46 nano_g: Izzet Prowess (UR)
#47 ander_lizarrakoa: Dimir Control (UB)
#48 LewisCBR: Scapeshift (URG)
#49 MtGilligan: Zoo (WRG)
#50 AlphaBlade: E Tron (C)
#51 yintao: Temur Control (URG)
#52 Sprouts: Hammer Time (WR)
#53 GruGloG: Crabvine (UBG)
#54 shoktroopa: U Tron (UR)
#55 ColdPier: Thopter Urza (WUBR)
#56 Xenowan: Jeskai Breach (WUR, Jegantha)
#57 CrusherBotBG: Hammer Time (W, Lurrus)
#58 Goose70: Grixis Shadow (UBR)
#59 ziofrancone: Shadow Prowess (BRG, Lurrus)
#60 Trailovsky: Kiki Chord (WUG)
#61 __Ghost__: Zombies (UB)
#62 Clexxor: Azorius Taxes (WU, Yorion)
#63 stainerson: Snoop Goblins (BR)
#64 Captainschwiggles: Rakdos Midrange (BR)
#65 heyakita: Omnath Saheeli (WURG, Yorion)
#66 Teston: Shadow Prowess (BR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_12_08 : EventTest
    {
        [Test]
        public void Deck01_moutierdu42_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",0),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck02_Vashezzo_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-08",1),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_vasko19_IzzetRestoreBalance_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-08",2),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck04_MegaMollt_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-08",3),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Kontrabanda_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",4),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck06_Ivc_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-12-08",5),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_RyanWu_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",6),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_CptGrumblecakes_AbzanCompany_WBG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",7),
                new PostZendikarRising(),
                ArchetypeColor.WBG,
                typeof(AbzanCompany),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Rulleboren_HammerTime_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-08",8),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Dirk513_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",9),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Trailovsky_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-08",10),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_StreexIT_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",11),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck13_qbturtle15_Burn_WRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-08",12),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Busterbrown52_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",13),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck15_mashmalovsky_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-12-08",14),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Kurusu_KikiChord_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-08",15),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck17_Frutuoso_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",16),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Lucabireskusku_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",17),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_mechrataal_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-08",18),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_MTGnextlevel_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-12-08",19),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck21_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",20),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck22_merliche_Winota_WR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-08",21),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Winota),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck23_tcgshin_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",22),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck24_smoran02_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-08",23),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_Ditlev_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-12-08",24),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck26_SvenSveeterSven_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-league-2020-12-08",25),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck27_marcofabrizi_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",26),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Ryan39_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",27),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_xame3_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-08",28),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_CaptainFarbosa_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",29),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Nextep_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-08",30),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Orpheus819_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-08",31),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck33_J0SE_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",32),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck34_bcs8995_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-08",33),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck35_jrussellanderson_KGCTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-12-08",34),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck36_moosedroppings_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-league-2020-12-08",35),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck37_Jezz_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-08",36),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck38_ShutoShotokan_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",37),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck39_WoodwardUppr_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",38),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck40_Boucha_Belcher_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",39),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck41_Woooter_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",40),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck42_IPlayBadDecks_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",41),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck43_jsphfcll_EightRack_WB()
        {
            Test(
                GetDeck("modern-league-2020-12-08",42),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(EightRack),
                null,
                null
            );
        }

        [Test]
        public void Deck44_adriaferrer_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",43),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck45_MastaHorus_IzzetLivingEnd_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-08",44),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetLivingEnd),
                null
            );
        }

        [Test]
        public void Deck46_nanog_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-08",45),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck47_anderlizarrakoa_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-12-08",46),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck48_LewisCBR_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",47),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck49_MtGilligan_Zoo_WRG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",48),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Zoo),
                null,
                null
            );
        }

        [Test]
        public void Deck50_AlphaBlade_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-12-08",49),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck51_yintao_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",50),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Sprouts_HammerTime_WR()
        {
            Test(
                GetDeck("modern-league-2020-12-08",51),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck53_GruGloG_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",52),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck54_shoktroopa_UTron_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-08",53),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck55_ColdPier_ThopterUrza_WUBR()
        {
            Test(
                GetDeck("modern-league-2020-12-08",54),
                new PostZendikarRising(),
                ArchetypeColor.WUBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck56_Xenowan_JeskaiBreach_WUR_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-12-08",55),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(JeskaiAscendancy),
                typeof(JeskaiBreach),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck57_CrusherBotBG_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-08",56),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck58_Goose70_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-12-08",57),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck59_ziofrancone_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-08",58),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck60_Trailovsky_KikiChord_WUG()
        {
            Test(
                GetDeck("modern-league-2020-12-08",59),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(KikiChord),
                null,
                null
            );
        }

        [Test]
        public void Deck61_Ghost_Zombies_UB()
        {
            Test(
                GetDeck("modern-league-2020-12-08",60),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Zombies),
                null,
                null
            );
        }

        [Test]
        public void Deck62_Clexxor_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-08",61),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck63_stainerson_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-12-08",62),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck64_Captainschwiggles_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-12-08",63),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck65_heyakita_OmnathSaheeli_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-08",64),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck66_Teston_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-08",65),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
