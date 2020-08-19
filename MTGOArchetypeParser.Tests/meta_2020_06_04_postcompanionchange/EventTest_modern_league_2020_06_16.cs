using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_league_2020_06_16 : EventTest
    {
        [Test]
        public void Deck01_Metcalf23_DeathAndTaxes_WR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-16",0),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(DeathAndTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_Manacymbal_KinnanUrza_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-16",1),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(KinnanUrza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_jessysamek_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",2),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Heisenberg666_Burn_WRG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",3),
                new PostCompanionChange(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck05_dch97e_Spirits_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",4),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck06_3HaLeX1_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-06-16",5),
                new PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck07_Thefan_BantBlink_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-16",6),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(BantBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_camr0n1_IzzetPhoenix_UR()
        {
            Test(
                GetDeck("modern-league-2020-06-16",7),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(IzzetPhoenix),
                null,
                null
            );
        }

        [Test]
        public void Deck09_KowV2_Uroza_UBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-16",8),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck10_gyyby297_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-league-2020-06-16",9),
                new PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck11_sneakyrobot_Infect_WG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",10),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck12_TuggaNaxos_SnowControl_SnowTurns_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",11),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowTurns),
                null
            );
        }

        [Test]
        public void Deck13_Simarisu_DeathsShadow_OrzhovShadow_WB()
        {
            Test(
                GetDeck("modern-league-2020-06-16",12),
                new PostCompanionChange(),
                ArchetypeColor.WB,
                typeof(DeathsShadow),
                typeof(OrzhovShadow),
                null
            );
        }

        [Test]
        public void Deck14_Rossello_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-06-16",13),
                new PostCompanionChange(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck15_osmanozguney_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",14),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck16_cjucjujp_BushwhackerZoo_RG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",15),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck17_kai2000_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-16",16),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_Praxifi_Winota_WRG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",17),
                new PostCompanionChange(),
                ArchetypeColor.WRG,
                typeof(Winota),
                null,
                null
            );
        }

        [Test]
        public void Deck19_miki665_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",18),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Nideon_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-06-16",19),
                new PostCompanionChange(),
                ArchetypeColor.WB,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck21_tuckerde_PrimevalTitan_AmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",20),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck22_Wuhsa_BringToNiv_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",21),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck23_iuriper_Merfolk_UB()
        {
            Test(
                GetDeck("modern-league-2020-06-16",22),
                new PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck24_DemianDesposito10_Prowess_R()
        {
            Test(
                GetDeck("modern-league-2020-06-16",23),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Kurusu_KikiChord_WBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-16",24),
                new PostCompanionChange(),
                ArchetypeColor.WBRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck26_shine0905_GyrudaStompy_BRG_Gyruda()
        {
            Test(
                GetDeck("modern-league-2020-06-16",25),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(GyrudaStompy),
                null,
                ArchetypeCompanion.Gyruda
            );
        }

        [Test]
        public void Deck27_waru_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-16",26),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_GameNight_Winota_WRG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",27),
                new PostCompanionChange(),
                ArchetypeColor.WRG,
                typeof(Winota),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Gabriel0288_PrimevalTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",28),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Kaipa_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-16",29),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_FatChocobo_Goblins_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",30),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck32_crexalbo_TwiddleStorm_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",31),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(TwiddleStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck33_pbarrrgh_SnowControl_SnowReclamation_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-16",32),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck34_cesar189350_JeskaiControl_JeskaiFlash_WUR()
        {
            Test(
                GetDeck("modern-league-2020-06-16",33),
                new PostCompanionChange(),
                ArchetypeColor.WUR,
                typeof(JeskaiControl),
                typeof(JeskaiFlash),
                null
            );
        }

        [Test]
        public void Deck35_Miqa_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-06-16",34),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck36_Jidden_ThopterUrza_WU()
        {
            Test(
                GetDeck("modern-league-2020-06-16",35),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck37_teagantime_SnowControl_SnowTitan_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-16",36),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck38_Tarrasque1_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",37),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck39_FreshKale_GTron_GolosTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-06-16",38),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(GolosTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck40_FreedMania_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",39),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck41_mashmalovsky_Smallpox_WB()
        {
            Test(
                GetDeck("modern-league-2020-06-16",40),
                new PostCompanionChange(),
                ArchetypeColor.WB,
                typeof(Smallpox),
                null,
                null
            );
        }

        [Test]
        public void Deck42_sendoh007_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-16",41),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck43_JRDC14_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-16",42),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowShift),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck44_ScreenwriterNY_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",43),
                new PostCompanionChange(),
                ArchetypeColor.WRG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck45_martindoktor_AzoriusControl_Miracles_WU()
        {
            Test(
                GetDeck("modern-league-2020-06-16",44),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(Miracles),
                null
            );
        }

        [Test]
        public void Deck46_bamzing_Ponza_RG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",45),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck47_TheWonderLord_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",46),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck48_Munin40_Rock_BG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",47),
                new PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck49_qbturtle15_Ponza_RG_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-06-16",48),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck50_fsst_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-06-16",49),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck51_JMoney8771_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",50),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck52_122pablo_JeskaiAscendancy_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-06-16",51),
                new PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck53_maple049_HardenedScales_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-16",52),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck54_drRobotGranata_PrimevalTitan_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",53),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck55_MHayashi_RedDeckWins_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-06-16",54),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(RedDeckWins),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck56_erose199423_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-league-2020-06-16",55),
                new PostCompanionChange(),
                ArchetypeColor.WUR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck57_daifuku_SnowControl_TemurSnow_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",56),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(TemurSnow),
                null
            );
        }

        [Test]
        public void Deck58_abijhavs_Prowess_R()
        {
            Test(
                GetDeck("modern-league-2020-06-16",57),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck59_MlckyB_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",58),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }


    }
}
