using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_league_2020_07_03 : EventTest
    {
        [Test]
        public void Deck01_Batutinha_SnowControl_SnowReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",0),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck02_mechint_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-07-03",1),
                new PostM21(),
                ArchetypeColor.UB,
                typeof(DimirControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_NevarMore_Prowess_R()
        {
            Test(
                GetDeck("modern-league-2020-07-03",2),
                new PostM21(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Drakanar_Merfolk_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",3),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck05_robedarcourt_DeathAndTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-07-03",4),
                new PostM21(),
                ArchetypeColor.WB,
                typeof(DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck06_marcofabrizi_SnowControl_WUBG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",5),
                new PostM21(),
                ArchetypeColor.WUBG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_titoWii96_SnowControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-03",6),
                new PostM21(),
                ArchetypeColor.WURG,
                typeof(SnowControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_MrSheep_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",7),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Tarrasque1_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",8),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck10_didoguidotti1_SnowControl_SnowShift_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-03",9),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowShift),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_daniventrue_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",10),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck12_MHayashi_RedDeckWins_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-07-03",11),
                new PostM21(),
                ArchetypeColor.R,
                typeof(RedDeckWins),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck13_kogamo_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",12),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck14_ScreenwriterNY_PrimevalTitan_AmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",13),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck15_Maratiam_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-07-03",14),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck16_mrounds1216_Elves_GolgariElves_BG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",15),
                new PostM21(),
                ArchetypeColor.BG,
                typeof(Elves),
                typeof(GolgariElves),
                null
            );
        }

        [Test]
        public void Deck17_npercario_IzzetFreeSpells_IzzetRestoreBalance_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",16),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck18_Weasley_SnowControl_SnowReclamation_UBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-03",17),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_CHILLEDADED_PrimevalTitan_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",18),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck20_GRDONKIN_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-07-03",19),
                new PostM21(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck21_sicsmoo_GTron_G()
        {
            Test(
                GetDeck("modern-league-2020-07-03",20),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Nilsfit_Devoted_HeliodDevoted_WUG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",21),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck23_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",22),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Wirmaleff_Mill_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",23),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck25_DoubleB33_SoulSisters_HeliodSisters_W()
        {
            Test(
                GetDeck("modern-league-2020-07-03",24),
                new PostM21(),
                ArchetypeColor.W,
                typeof(SoulSisters),
                typeof(HeliodSisters),
                null
            );
        }

        [Test]
        public void Deck26_Blkspds_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",25),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck27_L3D91_Ponza_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",26),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck28_saccij92_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",27),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck29_HNSDMPF_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-07-03",28),
                new PostM21(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck30_thepensword_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",29),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_rojanosa_Tokens_OrzhovTokens_WB()
        {
            Test(
                GetDeck("modern-league-2020-07-03",30),
                new PostM21(),
                ArchetypeColor.WB,
                typeof(Tokens),
                typeof(OrzhovTokens),
                null
            );
        }

        [Test]
        public void Deck32_Jiggywiggy_KinnanUrza_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-03",31),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(KinnanUrza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck33_aspiringspike_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",32),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                null,
                null
            );
        }

        [Test]
        public void Deck34_penips_DeathAndTaxes_EldraziTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-07-03",33),
                new PostM21(),
                ArchetypeColor.W,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck35_BrunoMineiro_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",34),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck36_122pablo_JeskaiAscendancy_WURG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",35),
                new PostM21(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                null,
                null
            );
        }

        [Test]
        public void Deck37_B4nn3D22_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",36),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck38_NagatoBoran_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",37),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck39_Cherryxman_Delver_GrixisDelver_UBR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",38),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(Delver),
                typeof(GrixisDelver),
                null
            );
        }

        [Test]
        public void Deck40_Morrys_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",39),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck41_Zxrogue_DeathAndTaxes_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-03",40),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(DeathAndTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck42_Draken44_Uroza_UBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-03",41),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck43_Wuhsa_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-03",42),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck44_RadioactiveTortoise_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",43),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck45_lopi_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",44),
                new PostM21(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck46_TubbyBatman_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",45),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck47_TrueHero_SnowControl_SnowTurns_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",46),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowTurns),
                null
            );
        }

        [Test]
        public void Deck48_MadMaxErnst_SnowControl_SultaiSnow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",47),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck49_Trellon_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-07-03",48),
                new PostM21(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Ryan39_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-03",49),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck51_Kurusu_KikiChord_WBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-03",50),
                new PostM21(),
                ArchetypeColor.WBRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck52_Rosie54_DeathAndTaxes_CatsAndTaxes_WG()
        {
            Test(
                GetDeck("modern-league-2020-07-03",51),
                new PostM21(),
                ArchetypeColor.WG,
                typeof(DeathAndTaxes),
                typeof(CatsAndTaxes),
                null
            );
        }


    }
}
