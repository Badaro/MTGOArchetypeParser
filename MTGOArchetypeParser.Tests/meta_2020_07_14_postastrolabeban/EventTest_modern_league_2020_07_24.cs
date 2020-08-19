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
    public class EventTest_modern_league_2020_07_24 : EventTest
    {
        [Test]
        public void Deck01_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-24",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_Makaveli_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-24",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_BaDzIo_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-07-24",2),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck04_kensportsfan_Prowess_R()
        {
            Test(
                GetDeck("modern-league-2020-07-24",3),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck05_carlosalmeida_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck06_GHash77_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Ladon_SaheeliCombo_SnowSaheeli_WURG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(SnowSaheeli),
                null
            );
        }

        [Test]
        public void Deck08_Beicodegeia_RedDeckWins_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-07-24",7),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedDeckWins),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck09_aspiringspike_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",8),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck10_TurmolL_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",9),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_DylanMTG_IzzetFreeSpells_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",10),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck12_LHaxLover_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",11),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck13_PhantasmalBear_AzoriusTempo_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-24",12),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusTempo),
                null,
                null
            );
        }

        [Test]
        public void Deck14_ContraEgo_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",13),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Nilsfit_SnowControl_SnowReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",14),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck16_DeadEyeEneMy_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",15),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck17_SharkcasterMage_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-07-24",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck18_cnofafva_PrimevalTitan_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck19_ShogunHelios_Crabvine_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Automaton_Elves_GolgariElves_BG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",19),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Elves),
                typeof(GolgariElves),
                null
            );
        }

        [Test]
        public void Deck21_Lcario_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",20),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck22_Predicted_Yawgmoth_WBG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",21),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Janh_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",22),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Bosseidon_Burn_IncineratorBurn_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",23),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck25_603Leb_PrimevalTitan_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",24),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck26_Albyz_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",25),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck27_1nfundibulum_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-07-24",26),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Zebrah_DeathAndTaxes_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-24",27),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(DeathAndTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_GodsShadow_GrixisControl_UBR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",28),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GrixisControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Baufos_SimicControl_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",29),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(SimicControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_JimmySetzer_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",30),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck32_gobboboy_ToothAndNail_G()
        {
            Test(
                GetDeck("modern-league-2020-07-24",31),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(ToothAndNail),
                null,
                null
            );
        }

        [Test]
        public void Deck33_mwapl_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",32),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck34_Werepigs_DeathsShadow_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",33),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(DeathsShadow),
                typeof(MarduShadow),
                null
            );
        }

        [Test]
        public void Deck35_vitto_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",34),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck36_junghans_Devoted_WRG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",35),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck37_VFS_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-07-24",36),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(DimirControl),
                null,
                null
            );
        }

        [Test]
        public void Deck38_katuo079595_DeathsShadow_TraverseShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",37),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck39_SebastianStueckl_Goblins_SnoopGoblins_WBR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",38),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck40_Archgaze_CrematorEvolution_WRG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",39),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(CrematorEvolution),
                null,
                null
            );
        }

        [Test]
        public void Deck41_Trellon_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-07-24",40),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck42_Wuhsa_BringToNiv_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",41),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck43_Marxelo_Tokens_WB()
        {
            Test(
                GetDeck("modern-league-2020-07-24",42),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(Tokens),
                null,
                null
            );
        }

        [Test]
        public void Deck44_esatheking_Prowess_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",43),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck45_DenmarkDan_PrimevalTitan_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",44),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck46_Thrall90_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",45),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck47_HouseOfManaMTG_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-07-24",46),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck48_Polikasoll_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",47),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck49_Chaughey_Delver_JeskaiDelver_WUR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",48),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(Delver),
                typeof(JeskaiDelver),
                null
            );
        }

        [Test]
        public void Deck50_Mussie99_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-24",49),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck51_Ingles_Burn_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-league-2020-07-24",50),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck52_cws_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-24",51),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck53_MrRaeb_Ponza_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",52),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck54_BlueLips_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",53),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck55_KOKI12_AzoriusTempo_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-24",54),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusTempo),
                null,
                null
            );
        }

        [Test]
        public void Deck56_SpiderSpace_DeathAndTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-07-24",55),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck57_MadRamon_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-24",56),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(WildernessReclamation),
                typeof(TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck58_FabriceK_SnowControl_SnowReclamation_UG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-24",57),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck59_DreamsOfAshiok_Prowess_RakdosProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-24",58),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck60_GulDukat_Prowess_GruulProwess_RG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-07-24",59),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Prowess),
                typeof(GruulProwess),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck61_penach010_Devoted_HeliodDevoted_WRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-24",60),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck62_brainstorm39_JeskaiControl_WUR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-24",61),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(JeskaiControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }


    }
}
