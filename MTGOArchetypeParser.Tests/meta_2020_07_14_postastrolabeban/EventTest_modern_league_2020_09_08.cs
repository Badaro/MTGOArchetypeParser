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
#01 ProfessorAnthrax: TitanShift (RG)
#02 Delpoctrol: KGCTron (G)
#03 thedoc96: Uroza (WUG)
#04 The_GingerBrute: HammerTime (WR, Lurrus)
#05 NuclearAdam: Neobrand (UG)
#06 AceTrainerBlue: Yawgmoth (BG)
#07 eneges: JundShadow (BRG)
#08 victorseiya: OrzhovMidrange (WB)
#09 crackerpack: Dredge (WBRG)
#10 Gods_Shadow: MonoWhiteTaxes (W)
#11 ajifly: Devoted (WRG)
#12 Tarrasque1: SelenyaTaxes (WG)
#13 v3sp_tv: BorosProwess (WR, Lurrus)
#14 plampkin: IzzetProwess (UR)
#15 Voltzwagon: GruulMidrange (RG)
#16 PieGonti: Elementals (WUBRG)
#17 Feyall: JundShadow (BRG)
#18 chaba_lol: HammerTime (W)
#19 Artem_Kuhtin: WhiteDevotion (W)
#20 muckymuck_dc5: MonoWhiteTaxes (W)
#21 PieGonti: SnoopGoblins (BR)
#22 abijhavs: MonoRedProwess (R)
#23 ANBKI: ETron (C)
#24 urzatheplaneswalker: BantBlink (WUG)
#25 Parrit: MonoWhiteTaxes (W)
#26 Danielstallone: Burn (WR, Lurrus)
#27 Muldrotha7912: GrixisShadow (UBR)
#28 kingoftheelves: AbzanMidrange (WBG)
#29 FedeG: PrimevalTitan (WRG)
#30 BlazingShoryuken: IzzetControl (UR)
#31 rojanosa: Faeries (UB)
#32 fradev1988: IzzetRestoreBalance (URG)
#33 junior97: RakdosMidrange (BR)
#34 eggybenny: TemurDelver (URG)
#35 Bangood: ThopterUrza (UBR)
#36 BigDadChad: HeliodCombo (WG)
#37 Rinko: EnduringIdeal (W)
#38 Selami: AdNauseam (WUB)
#39 FakiVll: AzoriusControl (WU)
#40 MrRaeb: Uroza (UG)
#41 ScarletStorms: BantControl (WUG)
#42 Sharkcaster_Mage: OboshAggro (R, Obosh)
#43 Toastxp: AmuletTitan (URG)
#44 Magric: JundMidrange (BRG)
#45 balltap: JeskaiBreach (WURG, Jegantha)
#46 TheWonderLord: GolgariMidrange (BG)
#47 toondoslav: Infect (WUG)
#48 gamemaker: Belcher (BG)
#49 N3to: GiftsStorm (UR)
#50 rastaf: Bogles (WG, Lurrus)
#51 LordMajicus: Merfolk (WU, Lurrus)
#52 Warsten: Elves (G)
#53 TheGameRoomPro: Humans (WUBRG)
#54 JohnWithaH: JundMidrange (BRG)
#55 piie: Scapeshift (URG)
#56 GoodDay: BantMidrange (WUG)
#57 wilson5434: NayaMidrange (WRG)
#58 AJOCHUM: TemurReclamation (URG)
#59 Musagete: OrzhovEldraziTaxes (WB)
#60 Usama96: SultaiControl (UBG)
#61 exoticherman: RakdosProwess (BR, Lurrus)
#62 Kotva: Angels (WR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_league_2020_09_08 : EventTest
    {
        [Test]
        public void Deck01_ProfessorAnthrax_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",0),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck02_Delpoctrol_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-09-08",1),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck03_thedoc96_Uroza_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck04_TheGingerBrute_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-08",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_NuclearAdam_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",4),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck06_AceTrainerBlue_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",5),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck07_eneges_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",6),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck08_victorseiya_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-league-2020-09-08",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_crackerpack_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck10_GodsShadow_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-09-08",9),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck11_ajifly_Devoted_WRG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Tarrasque1_SelenyaTaxes_WG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck13_v3sptv_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-08",12),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_plampkin_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-08",13),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Voltzwagon_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",14),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_PieGonti_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",15),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Feyall_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",16),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck18_chabalol_HammerTime_W()
        {
            Test(
                GetDeck("modern-league-2020-09-08",17),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck19_ArtemKuhtin_WhiteDevotion_W()
        {
            Test(
                GetDeck("modern-league-2020-09-08",18),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(WhiteDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck20_muckymuckdc5_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-09-08",19),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck21_PieGonti_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-09-08",20),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck22_abijhavs_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-09-08",21),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck23_ANBKI_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-09-08",22),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck24_urzatheplaneswalker_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",23),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Parrit_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-09-08",24),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Danielstallone_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-08",25),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_Muldrotha7912_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-09-08",26),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck28_kingoftheelves_AbzanMidrange_WBG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",27),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck29_FedeG_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",28),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck30_BlazingShoryuken_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-08",29),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_rojanosa_Faeries_UB()
        {
            Test(
                GetDeck("modern-league-2020-09-08",30),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(Faeries),
                null,
                null
            );
        }

        [Test]
        public void Deck32_fradev1988_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",31),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck33_junior97_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-09-08",32),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck34_eggybenny_TemurDelver_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",33),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Delver),
                typeof(TemurDelver),
                null
            );
        }

        [Test]
        public void Deck35_Bangood_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-09-08",34),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck36_BigDadChad_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",35),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck37_Rinko_EnduringIdeal_W()
        {
            Test(
                GetDeck("modern-league-2020-09-08",36),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(EnduringIdeal),
                null,
                null
            );
        }

        [Test]
        public void Deck38_Selami_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-09-08",37),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck39_FakiVll_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-08",38),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck40_MrRaeb_Uroza_UG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",39),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck41_ScarletStorms_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",40),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck42_SharkcasterMage_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-09-08",41),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck43_Toastxp_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",42),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck44_Magric_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",43),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck45_balltap_JeskaiBreach_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-09-08",44),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                typeof(JeskaiBreach),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck46_TheWonderLord_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",45),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck47_toondoslav_Infect_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",46),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck48_gamemaker_Belcher_BG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",47),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck49_N3to_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-08",48),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck50_rastaf_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-08",49),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck51_LordMajicus_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-08",50),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck52_Warsten_Elves_G()
        {
            Test(
                GetDeck("modern-league-2020-09-08",51),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Elves),
                null,
                null
            );
        }

        [Test]
        public void Deck53_TheGameRoomPro_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",52),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck54_JohnWithaH_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",53),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck55_piie_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",54),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck56_GoodDay_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",55),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck57_wilson5434_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",56),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck58_AJOCHUM_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",57),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck59_Musagete_OrzhovEldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-09-08",58),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck60_Usama96_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-09-08",59),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck61_exoticherman_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-08",60),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck62_Kotva_Angels_WR()
        {
            Test(
                GetDeck("modern-league-2020-09-08",61),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Angels),
                null,
                null
            );
        }


    }
}
