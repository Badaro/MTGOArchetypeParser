using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_league_2020_08_11 : EventTest
    {
        [Test]
        public void Deck01_GodsShadow_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",0),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Lannynyny_BringToNiv_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck03_cccaspar_WhiteDevotion_W()
        {
            Test(
                GetDeck("modern-league-2020-08-11",2),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(WhiteDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck04_scipios_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",3),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck05_AlphaBlade_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-08-11",4),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Jaberwocki_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",5),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck07_shivendjinn_RedDeckWins_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-08-11",6),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedDeckWins),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck08_Hetteshkane_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-08-11",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck09_ltbeast_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",8),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Nextep_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",9),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck11_didoguidotti1_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",10),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(WildernessReclamation),
                typeof(TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck12_junghans_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck13_imperatorek_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-11",12),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_SharkcasterMage_WildernessReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",13),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(WildernessReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck15_zildjian88_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",14),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck16_mrounds1216_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-08-11",15),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck17_VFS_SnowControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",16),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_MRZ_Rock_Sultai_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",17),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Rock),
                typeof(Sultai),
                null
            );
        }

        [Test]
        public void Deck19_Thekkar_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-08-11",18),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck20_ferrum0728_DeathsShadow_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-league-2020-08-11",19),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(DeathsShadow),
                typeof(MarduShadow),
                null
            );
        }

        [Test]
        public void Deck21_Bishark_BlueDevotion_U()
        {
            Test(
                GetDeck("modern-league-2020-08-11",20),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(BlueDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Simarisu_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-11",21),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck23_sultai4lyfe_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-08-11",22),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(DimirControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_DoorDie_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-08-11",23),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck25_Zpz_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-08-11",24),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck26_Volollo_Prowess_RakdosProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-11",25),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_RileyCurran_Devoted_HeliodDevoted_WBG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck28_FSkura_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",27),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SultaiControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_bobthedog_SoulSisters_HeliodSisters_W()
        {
            Test(
                GetDeck("modern-league-2020-08-11",28),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(SoulSisters),
                typeof(HeliodSisters),
                null
            );
        }

        [Test]
        public void Deck30_drVendigo_Ponza_RG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",29),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck31_IDEEEDIT_Prowess_R()
        {
            Test(
                GetDeck("modern-league-2020-08-11",30),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck32_musasabi_PrimevalTitan_KGCAmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",31),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck33_kid_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-11",32),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Storytime_Devoted_KinnanDevoted_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",33),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                typeof(KinnanDevoted),
                null
            );
        }

        [Test]
        public void Deck35_lokarionn_HardenedScales_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-11",34),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck36_l337erhosen_WhiteDevotion_W_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-11",35),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(WhiteDevotion),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck37_MinT_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-08-11",36),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck38_Sfugliatella_Burn_IncineratorBurn_WR()
        {
            Test(
                GetDeck("modern-league-2020-08-11",37),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck39_crackerpack_EnduringIdeal_W()
        {
            Test(
                GetDeck("modern-league-2020-08-11",38),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(EnduringIdeal),
                null,
                null
            );
        }

        [Test]
        public void Deck40_Esoda_SnowControl_SnowBlade_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",39),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck41_Yugornot_DeathsShadow_TraverseShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",40),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck42_ThePhatty500_Tokens_OrzhovTokens_WB()
        {
            Test(
                GetDeck("modern-league-2020-08-11",41),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(Tokens),
                typeof(OrzhovTokens),
                null
            );
        }

        [Test]
        public void Deck43_Lexmart_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",42),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck44_brainstorm39_JeskaiControl_WUR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-11",43),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(JeskaiControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck45_SebastianStueckl_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",44),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck46_SixScry_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-11",45),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck47_axisplus1_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",46),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck48_TheDogFish_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-11",47),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck49_WeGoingSizzler_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",48),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Bobthebuilder24_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-08-11",49),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck51_Waumpus_HeliodCombo_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",50),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck52_CTherapy_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-11",51),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck53_Nekonii_Elves_GolgariElves_BG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",52),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Elves),
                typeof(GolgariElves),
                null
            );
        }

        [Test]
        public void Deck54_DethFrmAbove_Tokens_WB()
        {
            Test(
                GetDeck("modern-league-2020-08-11",53),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(Tokens),
                null,
                null
            );
        }

        [Test]
        public void Deck55_Asoen_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-08-11",54),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(RakdosMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck56_Iceman76_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-08-11",55),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck57_kaktusowysmok_Merfolk_U()
        {
            Test(
                GetDeck("modern-league-2020-08-11",56),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck58_Middeterminist_WildernessReclamation_UG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",57),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(WildernessReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck59_CrusherBotBG_HammerTime_W()
        {
            Test(
                GetDeck("modern-league-2020-08-11",58),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck60_DieSense84_Rock_BG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",59),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck61_ivan229_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-11",60),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck62_danidpf_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-08-11",61),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck63_Parrit_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-08-11",62),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck64_Qernavak_DiceFactoryTron_C()
        {
            Test(
                GetDeck("modern-league-2020-08-11",63),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(DiceFactoryTron),
                null,
                null
            );
        }

        [Test]
        public void Deck65_Makaveli_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-11",64),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck66_sfitz_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-08-11",65),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck67_TheGingerBrute_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-11",66),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck68_CasperKhaos_IzzetFreeSpells_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-11",67),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck69_aspiringspike_DeathsShadow_EsperShadow_WUB()
        {
            Test(
                GetDeck("modern-league-2020-08-11",68),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(DeathsShadow),
                typeof(EsperShadow),
                null
            );
        }


    }
}
