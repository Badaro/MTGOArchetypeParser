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
#01 Bruno_Mineiro: Jund (BRG)
#02 darklingseven: Humans (WUBRG)
#03 Tarrasque1: Elementals (WUBRG)
#04 DokeshiCS: WildernessReclamation (UG)
#05 polinasgiuleppe: JeskaiStoneblade (WUR)
#06 thedoc96: Dredge (WBRG)
#07 JRDC14: MarduMidrange (WBR)
#08 nahuel10: Ponza (RG)
#09 Kk-: EldraziTaxes (WB)
#10 didoguidotti1: SnowBlade (WUG)
#11 Vektor27: IzzetProwess (UR)
#12 Yugornot: Burn (WR)
#13 aqualog: Prowess (WR)
#14 kogamo: Jund (BRG)
#15 Janh: AzoriusControl (WU)
#16 Simbal: GrixisShadow (UBR)
#17 Beicodegeia: GiftsStorm (UR)
#18 wingsfan24: TemurReclamation (URG)
#19 Vagabond87: ETron (C)
#20 _kg: Yawgmoth (BG)
#21 Capitano_CL: RedDeckWins (R, Obosh)
#22 deathandcatmix: DeathAndTaxes (W)
#23 Mr_Sheep: RakdosMidrange (BR)
#24 NJGB1: TraverseShadow (UBRG)
#25 psychoemotion: Bogles (WG)
#26 PeanutBrittle: HardenedScales (G)
#27 MatiCheto: KGCTron (G)
#28 willpulliam: AmuletTitan (URG)
#29 Jenara19: NayaMidrange (WRG)
#30 ShowTime_: RedPrison (R)
#31 GoblinK1ng: Goblins (BRG)
#32 MercSavage: AzoriusStoneblade (WU)
#33 Trellon: UTron (U)
#34 Albyz: IzzetRestoreBalance (URG)
#35 Qernavak: UTron (U)
#36 Galanator: IzzetBreach (UR)
#37 tuhoajatane: BantControl (WUG)
#38 buddha715: AdNauseam (WUB)
#39 bkorbsquare07: Prowess (R)
#40 RuudMaarten: GreenStompy (G)
#41 PvtEnormous: Scapeshift (URG)
#42 Wuhsa: BringToNiv (WUBRG, Yorion)
#43 _Joseph_: TitanShift (RG)
#44 Rinbo: DeathAndTaxes (W)
#45 DrDub: Merfolk (U)
#46 TISH: EldraziTaxes (W)
#47 XxShuicunexX: Infect (UG)
#48 KIMCHIMAN: SnoopGoblins (BRG)
#49 osmanozguney: SnoopGoblins (BR)
#50 UrbanPope: RakdosProwess (BR, Lurrus)
#51 PieGonti: SuicideShadow (BRG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_league_2020_07_31 : EventTest
    {
        [Test]
        public void Deck01_BrunoMineiro_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-31",0),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck02_darklingseven_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-31",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Tarrasque1_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-31",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck04_DokeshiCS_WildernessReclamation_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-31",3),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(WildernessReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck05_polinasgiuleppe_JeskaiControl_JeskaiStoneblade_WUR()
        {
            Test(
                GetDeck("modern-league-2020-07-31",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(JeskaiControl),
                typeof(JeskaiStoneblade),
                null
            );
        }

        [Test]
        public void Deck06_thedoc96_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-31",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck07_JRDC14_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-league-2020-07-31",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(MarduMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_nahuel10_Ponza_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-31",7),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Kk_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-07-31",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck10_didoguidotti1_SnowControl_SnowBlade_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-31",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck11_Vektor27_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-31",10),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck12_Yugornot_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-31",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck13_aqualog_Prowess_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-31",12),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck14_kogamo_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-31",13),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck15_Janh_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-31",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Simbal_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-07-31",15),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck17_Beicodegeia_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-31",16),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck18_wingsfan24_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-31",17),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(WildernessReclamation),
                typeof(TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck19_Vagabond87_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-07-31",18),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck20_kg_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-07-31",19),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck21_CapitanoCL_RedDeckWins_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-07-31",20),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedDeckWins),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck22_deathandcatmix_DeathAndTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-07-31",21),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck23_MrSheep_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-31",22),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(RakdosMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck24_NJGB1_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-31",23),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck25_psychoemotion_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-07-31",24),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck26_PeanutBrittle_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-07-31",25),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck27_MatiCheto_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-07-31",26),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck28_willpulliam_PrimevalTitan_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-31",27),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck29_Jenara19_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-league-2020-07-31",28),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(NayaMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck30_ShowTime_RedPrison_R()
        {
            Test(
                GetDeck("modern-league-2020-07-31",29),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck31_GoblinK1ng_Goblins_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-31",30),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck32_MercSavage_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-31",31),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck33_Trellon_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-07-31",32),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Albyz_IzzetFreeSpells_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-31",33),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck35_Qernavak_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-07-31",34),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck36_Galanator_IzzetControl_IzzetBreach_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-31",35),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                typeof(IzzetBreach),
                null
            );
        }

        [Test]
        public void Deck37_tuhoajatane_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-31",36),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck38_buddha715_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-07-31",37),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck39_bkorbsquare07_Prowess_R()
        {
            Test(
                GetDeck("modern-league-2020-07-31",38),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck40_RuudMaarten_GreenStompy_G()
        {
            Test(
                GetDeck("modern-league-2020-07-31",39),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GreenStompy),
                null,
                null
            );
        }

        [Test]
        public void Deck41_PvtEnormous_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-31",40),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck42_Wuhsa_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-31",41),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck43_Joseph_PrimevalTitan_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-31",42),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck44_Rinbo_DeathAndTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-07-31",43),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck45_DrDub_Merfolk_U()
        {
            Test(
                GetDeck("modern-league-2020-07-31",44),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck46_TISH_DeathAndTaxes_EldraziTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-07-31",45),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck47_XxShuicunexX_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-31",46),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck48_KIMCHIMAN_Goblins_SnoopGoblins_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-31",47),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck49_osmanozguney_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-31",48),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck50_UrbanPope_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-31",49),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck51_PieGonti_DeathsShadow_SuicideShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-31",50),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(DeathsShadow),
                typeof(SuicideShadow),
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
