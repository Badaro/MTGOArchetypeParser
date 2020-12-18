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
#01 _IlNano_: Shadow Prowess (BR, Lurrus)
#02 ice_nine_: Boros Land Destruction (WR)
#03 WeGoingSizzler: Elementals (WUBRG)
#04 SickWorld: Obosh Aggro (R, Obosh)
#05 Metcalf23: Mono White Taxes (W, Yorion)
#06 balltap: WURG Control (WURG)
#07 122pablo: Jeskai Ascendancy (WURG)
#08 busso9494: Gruul Midrange (RG)
#09 DoctorQueller: Spirits (WU)
#10 TheWillHallExp: Mono White Taxes (W, Yorion)
#11 BaDzIo: Hammer Time (W, Lurrus)
#12 aspiringspike: Grixis Control (UBR, Lurrus)
#13 Boucha: Belcher (URG)
#14 SpiderSpace: Hollow One (R)
#15 BSK_hercules: Temur Control (URG)
#16 UmekawaneikU: Rakdos Midrange (BR)
#17 nazart: Heliod Combo (WG)
#18 -=Alfa=-: Dredge (BRG)
#19 yPrincipe: Oops All Spells (WUBG)
#20 Olioolli: Jund Shadow (BRG)
#21 fabee1: Thalia Stompy (WR)
#22 babamm: Izzet Restore Balance (UR)
#23 starfall: Boros Prowess (WR, Lurrus)
#24 bhood16: Jund Midrange (BRG)
#25 KoDiamonds: Heliod Combo (WBG)
#26 tylerjjobrien: Niv To Light (WUBRG, Yorion)
#27 Vashezzo: Omnath Saheeli (WURG, Jegantha)
#28 SvenSveeterSven: Mardu Midrange (WBR)
#29 ander_lizarrakoa: Dimir Control (UB)
#30 TuggaNaxos: Mill (UB, Lurrus)
#31 Jadacant: Dice Factory Tron (C)
#32 bwheezy: Jeskai Control (WUR)
#33 ittoku1: Bant Midrange (WUG)
#34 Ivc: Azorius Control (WU)
#35 GanYanCHN: Sultai Control (UBG)
#36 Skrug092: Heliod Combo (WG)
#37 Reflax: Gifts Storm (UR)
#38 yumad3988: Humans (WUBRG)
#39 marcofabrizi: Winota (WR, Yorion)
#40 mattingly23: Boros Taxes (WR, Yorion)
#41 Ike7: Izzet Control (UR)
#42 RAINkratos: Mono Red Prowess (R)
#43 Ne-rik-is: Mono White Taxes (W)
#44 Darshik: Naban Wizards (WUR)
#45 sepomon: Smallpox (WB)
#46 Nallemon: Smallpox (WBR)
#47 MastaHorus: Izzet Living End (UR)
#48 D00mwake: Heliod Combo (WR)
#49 mashmalovsky: Ad Nauseam (WUB)
#50 Sciakimika: KGC Amulet Titan (G)
#51 tanisong1221: Orzhov Midrange (WB)
#52 SwissRolls: E Tron (C)
#53 ryurgin: Gruul Midrange (RG)
#54 HummingBard: U Tron (U)
#55 EdB: Primeval Titan (UG)
#56 aspiringspike: Jeskai Control (WUR)
#57 NorrathDecay: KGC Tron (G)
#58 DethFrmAbove: Infect (UG)
#59 Clamavus: Yawgmoth (BG)
#60 Leviathan102: Reclaimer Titan (WRG)
#61 Kurusu: Kiki Chord (WURG, Yorion)
#62 jvidarte: Burn (WR, Lurrus)
#63 Kairos92: Red Prison (R)
#64 Blinkmoth-Nexus: Snoop Goblins (BR)
#65 RespectTheCat: Izzet Phoenix (UR)
#66 Rostocker: Bogles (WG)
#67 liftwhenready: Gifts Storm (URG, Jegantha)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_12_18 : EventTest
    {
        [Test]
        public void Deck01_IlNano_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-18",0),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_icenine_BorosLandDestruction_WR()
        {
            Test(
                GetDeck("modern-league-2020-12-18",1),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(BorosLandDestruction),
                null,
                null
            );
        }

        [Test]
        public void Deck03_WeGoingSizzler_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-12-18",2),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck04_SickWorld_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-12-18",3),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck05_Metcalf23_MonoWhiteTaxes_W_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-18",4),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_balltap_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-12-18",5),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_122pablo_JeskaiAscendancy_WURG()
        {
            Test(
                GetDeck("modern-league-2020-12-18",6),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                null,
                null
            );
        }

        [Test]
        public void Deck08_busso9494_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-12-18",7),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_DoctorQueller_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-12-18",8),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck10_TheWillHallExp_MonoWhiteTaxes_W_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-18",9),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_BaDzIo_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-18",10),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_aspiringspike_GrixisControl_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-18",11),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_Boucha_Belcher_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-18",12),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck14_SpiderSpace_HollowOne_R()
        {
            Test(
                GetDeck("modern-league-2020-12-18",13),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(HollowOne),
                null,
                null
            );
        }

        [Test]
        public void Deck15_BSKhercules_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-18",14),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_UmekawaneikU_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-12-18",15),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck17_nazart_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-12-18",16),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Alfa_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-12-18",17),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck19_yPrincipe_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-league-2020-12-18",18),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Olioolli_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-12-18",19),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck21_fabee1_ThaliaStompy_WR()
        {
            Test(
                GetDeck("modern-league-2020-12-18",20),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(ThaliaStompy),
                null,
                null
            );
        }

        [Test]
        public void Deck22_babamm_IzzetRestoreBalance_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-18",21),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck23_starfall_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-18",22),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_bhood16_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-12-18",23),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck25_KoDiamonds_HeliodCombo_WBG()
        {
            Test(
                GetDeck("modern-league-2020-12-18",24),
                new PostZendikarRising(),
                ArchetypeColor.WBG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck26_tylerjjobrien_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-18",25),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck27_Vashezzo_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-12-18",26),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck28_SvenSveeterSven_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-league-2020-12-18",27),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck29_anderlizarrakoa_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-12-18",28),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_TuggaNaxos_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-18",29),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_Jadacant_DiceFactoryTron_C()
        {
            Test(
                GetDeck("modern-league-2020-12-18",30),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(DiceFactoryTron),
                null,
                null
            );
        }

        [Test]
        public void Deck32_bwheezy_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-12-18",31),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck33_ittoku1_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-12-18",32),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Ivc_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-12-18",33),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck35_GanYanCHN_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-12-18",34),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck36_Skrug092_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-12-18",35),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck37_Reflax_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-18",36),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck38_yumad3988_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-12-18",37),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck39_marcofabrizi_Winota_WR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-18",38),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Winota),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck40_mattingly23_BorosTaxes_WR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-18",39),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck41_Ike7_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-18",40),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck42_RAINkratos_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-12-18",41),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck43_Nerikis_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-12-18",42),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck44_Darshik_NabanWizards_WUR()
        {
            Test(
                GetDeck("modern-league-2020-12-18",43),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(NabanWizards),
                null,
                null
            );
        }

        [Test]
        public void Deck45_sepomon_Smallpox_WB()
        {
            Test(
                GetDeck("modern-league-2020-12-18",44),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(Smallpox),
                null,
                null
            );
        }

        [Test]
        public void Deck46_Nallemon_Smallpox_WBR()
        {
            Test(
                GetDeck("modern-league-2020-12-18",45),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(Smallpox),
                null,
                null
            );
        }

        [Test]
        public void Deck47_MastaHorus_IzzetLivingEnd_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-18",46),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetLivingEnd),
                null
            );
        }

        [Test]
        public void Deck48_D00mwake_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-league-2020-12-18",47),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck49_mashmalovsky_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-12-18",48),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Sciakimika_KGCAmuletTitan_G()
        {
            Test(
                GetDeck("modern-league-2020-12-18",49),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck51_tanisong1221_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-league-2020-12-18",50),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck52_SwissRolls_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-12-18",51),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck53_ryurgin_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-12-18",52),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck54_HummingBard_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-12-18",53),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck55_EdB_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-league-2020-12-18",54),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck56_aspiringspike_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-12-18",55),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck57_NorrathDecay_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-12-18",56),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck58_DethFrmAbove_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-12-18",57),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck59_Clamavus_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-12-18",58),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck60_Leviathan102_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-12-18",59),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck61_Kurusu_KikiChord_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-18",60),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck62_jvidarte_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-18",61),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck63_Kairos92_RedPrison_R()
        {
            Test(
                GetDeck("modern-league-2020-12-18",62),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(RedPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck64_BlinkmothNexus_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-12-18",63),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck65_RespectTheCat_IzzetPhoenix_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-18",64),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(IzzetPhoenix),
                null,
                null
            );
        }

        [Test]
        public void Deck66_Rostocker_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-12-18",65),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck67_liftwhenready_GiftsStorm_URG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-12-18",66),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GiftsStorm),
                null,
                ArchetypeCompanion.Jegantha
            );
        }


    }
}
