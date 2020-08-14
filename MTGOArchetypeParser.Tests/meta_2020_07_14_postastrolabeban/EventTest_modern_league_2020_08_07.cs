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
    public class EventTest_modern_league_2020_08_07 : EventTest
    {
        [Test]
        public void Deck01_Capipf95_Burn_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck01_Capipf95_Burn_WR(),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck02_yneves_Ponza_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck02_yneves_Ponza_RG(),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck03_RRozanski_RakdosMidrange_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck03_RRozanski_RakdosMidrange_BR(),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(RakdosMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Kzrds_Prowess_IzzetProwess_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck04_Kzrds_Prowess_IzzetProwess_UR(),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck05_bozo2112_Goblins_SnoopGoblins_BR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck05_bozo2112_Goblins_SnoopGoblins_BR(),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck06_derramedefogo_GiftsStorm_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck06_derramedefogo_GiftsStorm_UR(),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck07_manuchao_TemurControl_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck07_manuchao_TemurControl_URG(),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(TemurControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Tsius_Dredge_WBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck08_Tsius_Dredge_WBRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck09_CrusherBotBG_HammerTime_W()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck09_CrusherBotBG_HammerTime_W(),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Zebrah_Humans_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck10_Zebrah_Humans_WUBRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck11_Kurusu_KikiChord_WRG_Yorion(),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_markchalice_Prowess_R()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck12_markchalice_Prowess_R(),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck13_azax_Neobrand_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck13_azax_Neobrand_UG(),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Kk_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck14_Kk_DeathAndTaxes_EldraziTaxes_WB(),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck15_GoblinK1ng_Goblins_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck15_GoblinK1ng_Goblins_BRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Karhusaatana_Bogles_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck16_Karhusaatana_Bogles_WG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Cantergiani_DeathAndTaxes_EldraziTaxes_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck17_Cantergiani_DeathAndTaxes_EldraziTaxes_WG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck18_Parrit_HardenedScales_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck18_Parrit_HardenedScales_G(),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck19_tylerjjobrien_BringToNiv_WUBRG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck19_tylerjjobrien_BringToNiv_WUBRG_Yorion(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck20_armstrong36_Rock_WBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck20_armstrong36_Rock_WBG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck21_osmanozguney_Smallpox_B()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck21_osmanozguney_Smallpox_B(),
                new PostAstrolabeBan(),
                ArchetypeColor.B,
                typeof(Smallpox),
                null,
                null
            );
        }

        [Test]
        public void Deck22_bigjc00_PrimevalTitan_AmuletTitan_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck22_bigjc00_PrimevalTitan_AmuletTitan_URG(),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck23_danichad_Rock_Jund_BRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck23_danichad_Rock_Jund_BRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck24_DaSneakyPete_AdNauseam_WUB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck24_DaSneakyPete_AdNauseam_WUB(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Cygnus_Tokens_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck25_Cygnus_Tokens_WB(),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(Tokens),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Do0mSwitch_SnowControl_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck26_Do0mSwitch_SnowControl_WUG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Chaughey_Delver_JeskaiDelver_WUR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck27_Chaughey_Delver_JeskaiDelver_WUR(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(Delver),
                typeof(JeskaiDelver),
                null
            );
        }

        [Test]
        public void Deck28_sydneydude_Prowess_WR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck28_sydneydude_Prowess_WR(),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Automaton_Elves_GolgariElves_BG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck29_Automaton_Elves_GolgariElves_BG(),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Elves),
                typeof(GolgariElves),
                null
            );
        }

        [Test]
        public void Deck30_MartinezDP_SnowControl_SnowTitan_UG_Yorion()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck30_MartinezDP_SnowControl_SnowTitan_UG_Yorion(),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(SnowControl),
                typeof(SnowTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck31_Mathieu23_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck31_Mathieu23_AzoriusControl_AzoriusStoneblade_WU(),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck32_konoyubitomare15_HeliodCombo_WG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck32_konoyubitomare15_HeliodCombo_WG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck33_SpicyLeche_Crabvine_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck33_SpicyLeche_Crabvine_UBG(),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck34_hkavery_BantControl_WURG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck34_hkavery_BantControl_WURG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck35_Delthar_Infect_BG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck35_Delthar_Infect_BG(),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck36_fpawlusz_TitanVial_WRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck36_fpawlusz_TitanVial_WRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(TitanVial),
                null,
                null
            );
        }

        [Test]
        public void Deck37_toya_RakdosMidrange_BR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck37_toya_RakdosMidrange_BR_Lurrus(),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(RakdosMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck38_brancusi_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck38_brancusi_DeathsShadow_GrixisShadow_UBR(),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck39_HannoLee_TemurSuperfriends_URG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck39_HannoLee_TemurSuperfriends_URG(),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(TemurSuperfriends),
                null,
                null
            );
        }

        [Test]
        public void Deck40_EladWin_JeskaiControl_JeskaiStoneblade_WUR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck40_EladWin_JeskaiControl_JeskaiStoneblade_WUR(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(JeskaiControl),
                typeof(JeskaiStoneblade),
                null
            );
        }

        [Test]
        public void Deck41_Darzyn_BantMidrange_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck41_Darzyn_BantMidrange_WUG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck42_asihtos_PrimevalTitan_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck42_asihtos_PrimevalTitan_UBRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck43_bobthyllama2_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck43_bobthyllama2_Prowess_RakdosProwess_BR_Lurrus(),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck44_sepomon_Smallpox_WB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck44_sepomon_Smallpox_WB(),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(Smallpox),
                null,
                null
            );
        }

        [Test]
        public void Deck45_Drakanar_Merfolk_UG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck45_Drakanar_Merfolk_UG(),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck46_ocelot823_AzoriusTempo_WU()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck46_ocelot823_AzoriusTempo_WU(),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusTempo),
                null,
                null
            );
        }

        [Test]
        public void Deck47_voodookick_WildernessReclamation_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck47_voodookick_WildernessReclamation_UBG(),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(WildernessReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck48_Galanator_DimirControl_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck48_Galanator_DimirControl_UB(),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(DimirControl),
                null,
                null
            );
        }

        [Test]
        public void Deck49_jmeyer2030_IzzetControl_IzzetBreach_UR()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck49_jmeyer2030_IzzetControl_IzzetBreach_UR(),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetControl),
                typeof(IzzetBreach),
                null
            );
        }

        [Test]
        public void Deck50_MagicDevil666_UTron_UB()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck50_MagicDevil666_UTron_UB(),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck51_MrJayngles_RedPrison_RG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck51_MrJayngles_RedPrison_RG(),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(RedPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Nis2a_DeathAndTaxes_EldraziTaxes_W()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck52_Nis2a_DeathAndTaxes_EldraziTaxes_W(),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck53_TheDogFish_Merfolk_WU_Lurrus()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck53_TheDogFish_Merfolk_WU_Lurrus(),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck54_shivendjinn_RedDeckWins_R_Obosh()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck54_shivendjinn_RedDeckWins_R_Obosh(),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedDeckWins),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck55_AngledLuffa_Lantern_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck55_AngledLuffa_Lantern_UBG(),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Lantern),
                null,
                null
            );
        }

        [Test]
        public void Deck56_AbelMolto_Burn_WRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck56_AbelMolto_Burn_WRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck57_cntrlfreak_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck57_cntrlfreak_DeathsShadow_TraverseShadow_UBRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck58_GriselDad_ETron_C()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck58_GriselDad_ETron_C(),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck59_JMAK2000_GTron_KGCTron_G()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck59_JMAK2000_GTron_KGCTron_G(),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck60_Luzur_SnowControl_SultaiSnow_UBG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck60_Luzur_SnowControl_SultaiSnow_UBG(),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck61_SlayItWithRoses_Elementals_WUBRG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck61_SlayItWithRoses_Elementals_WUBRG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck62_Logic_BantBlink_WUG()
        {
            Test(
                new MTGOArchetypeParser.Tests.SampleData.meta_2020_07_14_postastrolabeban.modern_league_2020_08_07.Deck62_Logic_BantBlink_WUG(),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantBlink),
                null,
                null
            );
        }


    }
}
