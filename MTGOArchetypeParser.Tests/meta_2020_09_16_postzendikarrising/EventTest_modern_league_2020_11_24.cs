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
#01 ragingpikey: Spirits (WU)
#02 Parrit: Mono White Taxes (W)
#03 nedyahiske: Jund Midrange (BRG)
#04 TuggaNaxos: Temur Midrange (URG)
#05 N3to: Gifts Storm (UR)
#06 Kurusu: Kiki Chord (WRG, Yorion)
#07 Draccon136: Hammer Time (WG, Lurrus)
#08 EnricoPalazzo: Faeries (UB)
#09 Sarv: Ad Nauseam (WUB)
#10 JustinAkinori: Bant Spirits (WUG)
#11 Apeliotes: KGC Tron (G)
#12 Mateusf34: E Tron (C)
#13 fifteenstepper: Infect (UG)
#14 asa1986: Sultai Control (UBG)
#15 JUJUBEAN__2004: Izzet Control (UR)
#16 willmitchell785: Mono Red Prowess (R)
#17 Frank_Bonaparte: Heliod Combo (WR)
#18 DemianDesposito10: Burn (WR, Lurrus)
#19 thedoc96: Shadow Prowess (WBR, Lurrus)
#20 cypress223: Reclaimer Titan (WRG)
#21 Cuthbertthecat: Dimir Control (UB)
#22 MHayashi: Obosh Aggro (R, Obosh)
#23 Mazzu93: Shadow Prowess (BRG, Lurrus)
#24 xJCloud: Mono White Taxes (W, Yorion)
#25 Rexplosion: Bant Blink (WUG)
#26 brunocaffaro: Oops All Spells (WUBG)
#27 Troll3nNTheDeep: Kiki Chord (WRG, Yorion)
#28 LyaApocalypse: Thopter Urza (UBR)
#29 Aphiladon: Hardened Scales (G)
#30 RagingTiltMonster: Temur Delver (URG)
#31 hmmyespanda: Esper Shadow (WUB)
#32 MomQuest: Golgari Midrange (BG)
#33 Ramzamela7: Elves (G)
#34 Voltzwagon: Gruul Midrange (RG)
#35 dough_shack: Scapeshift (WURG)
#36 balltap: WURG Control (WURG)
#37 Sodeq: Dredge (BRG)
#38 Pastratta: Mono Blue Delver (U)
#39 Vertyx_: Izzet Prowess (UR)
#40 drew3141: Amulet Titan (WURG)
#41 MartinezDP: Omnath Saheeli (WURG, Yorion)
#42 shoktroopa: U Tron (UR)
#43 Muldrotha7912: Izzet Control (UR)
#44 Wuhsa: Niv To Light (WUBRG, Yorion)
#45 NicDamian: Bant Midrange (WUG)
#46 mariogomes097: Grixis Shadow (UBR)
#47 603Leb: Amulet Titan (UBRG)
#48 MlckyB: Bogles (WUG)
#49 pbarrrgh: Azorius Control (WU)
#50 Pando89: Incinerator Burn (WR)
#51 Monochrome09: Temur Control (URG)
#52 Lollosauro: Heliod Combo (WG)
#53 V_Olkhovikov: UBRG Shadow (UBRG)
#54 xame3: Burn (WRG)
#55 StableSalmon: Scapeshift (URG)
#56 hodgepodge0: Yawgmoth (BG)
#57 Chipsoss: Orzhov Midrange (WB)
#58 oskiyaa: Rakdos Midrange (BR)
#59 dough_shack: Jeskai Control (WUR)
#60 mechint: Belcher (URG)
#61 WebZone: Humans (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_11_24 : EventTest
    {
        [Test]
        public void Deck01_ragingpikey_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-24",0),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Parrit_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-11-24",1),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck03_nedyahiske_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",2),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_TuggaNaxos_TemurMidrange_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",3),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_N3to_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-24",4),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-24",5),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck07_Draccon136_HammerTime_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-24",6),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_EnricoPalazzo_Faeries_UB()
        {
            Test(
                GetDeck("modern-league-2020-11-24",7),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Faeries),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Sarv_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-11-24",8),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck10_JustinAkinori_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",9),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck11_Apeliotes_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-11-24",10),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck12_Mateusf34_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-11-24",11),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck13_fifteenstepper_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",12),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck14_asa1986_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",13),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_JUJUBEAN2004_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-24",14),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_willmitchell785_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-11-24",15),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck17_FrankBonaparte_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-league-2020-11-24",16),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck18_DemianDesposito10_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-24",17),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_thedoc96_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-24",18),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_cypress223_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",19),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck21_Cuthbertthecat_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-11-24",20),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_MHayashi_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-11-24",21),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck23_Mazzu93_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-24",22),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_xJCloud_MonoWhiteTaxes_W_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-24",23),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck25_Rexplosion_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",24),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck26_brunocaffaro_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",25),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Troll3nNTheDeep_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-24",26),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck28_LyaApocalypse_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-11-24",27),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Aphiladon_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-11-24",28),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck30_RagingTiltMonster_TemurDelver_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",29),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Delver),
                typeof(TemurDelver),
                null
            );
        }

        [Test]
        public void Deck31_hmmyespanda_EsperShadow_WUB()
        {
            Test(
                GetDeck("modern-league-2020-11-24",30),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck32_MomQuest_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",31),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Ramzamela7_Elves_G()
        {
            Test(
                GetDeck("modern-league-2020-11-24",32),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Elves),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Voltzwagon_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",33),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck35_doughshack_Scapeshift_WURG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",34),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck36_balltap_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",35),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck37_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",36),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck38_Pastratta_MonoBlueDelver_U()
        {
            Test(
                GetDeck("modern-league-2020-11-24",37),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(Delver),
                typeof(MonoBlueDelver),
                null
            );
        }

        [Test]
        public void Deck39_Vertyx_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-24",38),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck40_drew3141_AmuletTitan_WURG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",39),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck41_MartinezDP_OmnathSaheeli_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-24",40),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck42_shoktroopa_UTron_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-24",41),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck43_Muldrotha7912_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-24",42),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck44_Wuhsa_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-24",43),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck45_NicDamian_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",44),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck46_mariogomes097_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-11-24",45),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck47_603Leb_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",46),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck48_MlckyB_Bogles_WUG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",47),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck49_pbarrrgh_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-24",48),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Pando89_IncineratorBurn_WR()
        {
            Test(
                GetDeck("modern-league-2020-11-24",49),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck51_Monochrome09_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",50),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Lollosauro_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",51),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck53_VOlkhovikov_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",52),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck54_xame3_Burn_WRG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",53),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck55_StableSalmon_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",54),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck56_hodgepodge0_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",55),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck57_Chipsoss_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-league-2020-11-24",56),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck58_oskiyaa_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-11-24",57),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck59_doughshack_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-11-24",58),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck60_mechint_Belcher_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",59),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck61_WebZone_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-24",60),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }


    }
}
