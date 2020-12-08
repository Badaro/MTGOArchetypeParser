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
#01 Metcalf23: Boros Taxes (WR, Yorion)
#02 Manacymbal: Kinnan Legends (URG, Yorion)
#03 jessy_samek: Dredge (BRG)
#04 Heisenberg666: Burn (WRG)
#05 dch97e: Bant Spirits (WUG)
#06 3HaLeX1: Grixis Shadow (UBR)
#07 Thefan: Bant Blink (WUG, Yorion)
#08 camr0n_1: Izzet Phoenix (UR)
#09 KowV2: Uroza (UBG, Yorion)
#10 gyyby297: Thopter Urza (UB)
#11 sneaky robot: Infect (WG)
#12 TuggaNaxos: Temur Midrange (URG)
#13 Simarisu: Orzhov Shadow (WB)
#14 Rossello: Ad Nauseam (WUB)
#15 osmanozguney: Sultai Control (UBG)
#16 cjucjujp: Bushwhacker Zoo (RG)
#17 kai2000: Niv To Light (WUBRG, Yorion)
#18 Praxifi: Winota (WRG)
#19 miki665: Humans (WUBRG)
#20 Nideon: Orzhov Taxes (WB)
#21 tucker_de: Amulet Titan (UG)
#22 Wuhsa: Niv To Light (WUBRG)
#23 iuriper: Merfolk (U)
#24 DemianDesposito10: Mono Red Prowess (R)
#25 Kurusu: Kiki Chord (WBRG, Yorion)
#26 shine0905: Titan Stompy (BRG, Gyruda)
#27 w_aru: Merfolk (WU, Lurrus)
#28 Game_Night: Winota (WRG)
#29 Gabriel0288: Primeval Titan (UG)
#30 Kaipa: Burn (WR, Lurrus)
#31 Fat_Chocobo: Goblins (BRG)
#32 crexalbo: Twiddle Storm (UG)
#33 pbarrrgh: Temur Control (URG, Yorion)
#34 cesar189350: Jeskai Control (WUR)
#35 Miqa: E Tron (C)
#36 Jidden: Thopter Urza (WU)
#37 teagantime: Bant Control (WUG, Yorion)
#38 Tarrasque1: Elementals (WUBRG)
#39 FreshKale: Golos Tron (G, Jegantha)
#40 FreedMania: Bant Control (WUG)
#41 mashmalovsky: Smallpox (WB)
#42 sendoh007: Devoted (WG, Lurrus)
#43 JRDC14: Scapeshift (URG, Yorion)
#44 ScreenwriterNY: Bushwhacker Zoo (WRG)
#45 martindoktor: Azorius Control (WU)
#46 bamzing: Gruul Midrange (RG)
#47 TheWonderLord: Jund Midrange (BRG)
#48 Munin40: Golgari Midrange (BG)
#49 qbturtle15: Gruul Midrange (RG, Obosh)
#50 fsst: Gifts Storm (UR)
#51 JMoney8771: Infect (UG)
#52 122pablo: Jeskai Ascendancy (WURG, Jegantha)
#53 maple049: Hardened Scales (WG, Lurrus)
#54 drRobotGranata: Titan Shift (RG)
#55 MHayashi: Mono Red Prowess (R, Jegantha)
#56 erose199423: Thopter Urza (WU)
#57 daifuku: Temur Midrange (URG)
#58 abijhavs: Mono Red Prowess (R)
#59 MlckyB: Bogles (WG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_league_2020_06_16 : EventTest
    {
        [Test]
        public void Deck01_Metcalf23_BorosTaxes_WR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-16",0),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_Manacymbal_KinnanLegends_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-16",1),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(KinnanLegends),
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
        public void Deck05_dch97e_BantSpirits_WUG()
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
        public void Deck06_3HaLeX1_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-06-16",5),
                new PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
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
                typeof(GenericBlink),
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
        public void Deck12_TuggaNaxos_TemurMidrange_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",11),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Simarisu_OrzhovShadow_WB()
        {
            Test(
                GetDeck("modern-league-2020-06-16",12),
                new PostCompanionChange(),
                ArchetypeColor.WB,
                typeof(GenericShadow),
                null,
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
        public void Deck15_osmanozguney_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",14),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
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
                typeof(Zoo),
                typeof(BushwhackerZoo),
                null
            );
        }

        [Test]
        public void Deck17_kai2000_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-16",16),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
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
        public void Deck20_Nideon_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-06-16",19),
                new PostCompanionChange(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck21_tuckerde_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",20),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck22_Wuhsa_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",21),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck23_iuriper_Merfolk_U()
        {
            Test(
                GetDeck("modern-league-2020-06-16",22),
                new PostCompanionChange(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck24_DemianDesposito10_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-06-16",23),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(GenericProwess),
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
        public void Deck26_shine0905_TitanStompy_BRG_Gyruda()
        {
            Test(
                GetDeck("modern-league-2020-06-16",25),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(TitanStompy),
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
        public void Deck29_Gabriel0288_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",28),
                new PostCompanionChange(),
                ArchetypeColor.UG,
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
        public void Deck32_crexalbo_TwiddleStorm_UG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",31),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(TwiddleStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck33_pbarrrgh_TemurControl_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-16",32),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck34_cesar189350_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-06-16",33),
                new PostCompanionChange(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
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
        public void Deck37_teagantime_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-16",36),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
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
        public void Deck39_FreshKale_GolosTron_G_Jegantha()
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
        public void Deck40_FreedMania_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",39),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
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
        public void Deck43_JRDC14_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-16",42),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
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
                typeof(Zoo),
                typeof(BushwhackerZoo),
                null
            );
        }

        [Test]
        public void Deck45_martindoktor_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-06-16",44),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck46_bamzing_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",45),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck47_TheWonderLord_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",46),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck48_Munin40_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",47),
                new PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck49_qbturtle15_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-06-16",48),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
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
        public void Deck54_drRobotGranata_TitanShift_RG()
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
        public void Deck55_MHayashi_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-06-16",54),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck56_erose199423_ThopterUrza_WU()
        {
            Test(
                GetDeck("modern-league-2020-06-16",55),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck57_daifuku_TemurMidrange_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-16",56),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck58_abijhavs_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-06-16",57),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(GenericProwess),
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
