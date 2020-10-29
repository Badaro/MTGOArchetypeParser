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
#01 llabmonkey: Bant Control (WUG)
#02 aspiringspike: Bant Blink (WUG, Yorion)
#03 Albyz: Mardu Pyromancer (WBR)
#04 Nallemon: Eight Rack (B)
#05 Proliferate: Bogles (WG)
#06 Parrit: Selenya Eldrazi Taxes (WG)
#07 Jiggywiggy: Kinnan Legends (WUG)
#08 TuggaNaxos: Infect (BG)
#09 kensportsfan: Mono Red Prowess (R)
#10 sakuragi21722749: Heliod Combo (WG)
#11 shoiwao: Heliod Devoted (WBG)
#12 Azerate218: UBRG Shadow (UBRG)
#13 SvenSveeterSven: Izzet Control (UR)
#14 Albyz: Bring To Niv (WUBRG)
#15 Carton: Esper Shadow (WUB)
#16 Bobthebuilder24: Heliod Sisters (W)
#17 waffl3haos: Orzhov Eldrazi Taxes (WB)
#18 harukispecial: Sultai Control (UBG)
#19 RyanWu: Orzhov Midrange (WB)
#20 ben1234: Temur Reclamation (URG)
#21 CodeProvider: Grishoalbrand (BR)
#22 sfitz: Thopter Urza (UBR)
#23 Wuhsa: Bring To Niv (WUBRG, Yorion)
#24 __Ghost__: Burn (WRG)
#25 Tedpanic: Azorius Control (WU)
#26 Irra0770: Jund Midrange (BRG)
#27 Mulldrifter: Dredge (WBRG)
#28 Copilot11: Izzet Control (UR)
#29 hanrahandh: Devoted Elves (WG)
#30 SickWorld: Burn (WR)
#31 Bryzem1: Izzet Prowess (UR)
#32 Metcalf23: Boros Taxes (WR, Lurrus)
#33 hizakura: Polymorph (RG)
#34 DarkKeeper: Bant Control (WUG)
#35 rodebo: U Tron (U)
#36 kogamo: Grixis Shadow (UBR)
#37 Cheerios: Simic Reclamation (UG)
#38 paynechips: KGC Tron (G)
#39 kogamo: Azorius Control (WU)
#40 brainstorm39: Jeskai Control (WUR, Yorion)
#41 Otmos: Boros Prowess (WR, Lurrus)
#42 Storytime: Kinnan Devoted (WUG)
#43 122pablo: Jeskai Ascendancy (WURG, Jegantha)
#44 JimmySetzer: Snoop Goblins (BR)
#45 fsst: Gifts Storm (UR)
#46 Tarmofir3: Jund Midrange (BRG)
#47 Polikasoll: Incinerator Burn (R)
#48 The_GingerBrute: Faeries (UB)
#49 dabigatran: Spirits (WU)
#50 Xenowan: Hardened Scales (G)
#51 TheCodyHope: Elementals (WUBRG, Kaheera)
#52 Menoti: E Tron (C)
#53 SpikeYou: Izzet Restore Balance (UR)
#54 kado222: Goryo Reanimator (BRG)
#55 CaptainFarbosa: Gruul Midrange (RG)
#56 cccaspar: White Devotion (W)
#57 kogamo: Primeval Titan (URG)
#58 Taragon: Devoted (WG, Lurrus)
#59 marcos_rocha: Infect (UG)
#60 tuhoajatane: Reclaimer Titan (WRG)
#61 Alzik: Rakdos Prowess (BR, Lurrus)
#62 MartinezDP: Bring To Niv (WUBRG, Yorion)
#63 scipios: Crabvine (UBG)
#64 SunnyOsRego: Rakdos Midrange (BR)
#65 musasabi: KGC Amulet Titan (UBRG)
#66 Widok: Ad Nauseam (WUB)
#67 MHayashi: Mono Red Prowess (R, Jegantha)
#68 Purple_Rain: Scapeshift (URG)
#69 Jidden: Thopter Urza (WU)
#70 tcgshin: Titan Shift (RG)
#71 DcNo: Humans (WUBRG)
#72 FriskiFraska: Gruul Midrange (RG)
#73 Thrall90: Golgari Midrange (BG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_league_2020_08_18 : EventTest
    {
        [Test]
        public void Deck01_llabmonkey_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_aspiringspike_BantBlink_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-18",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_Albyz_MarduPyromancer_WBR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(MarduPyromancer),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Nallemon_EightRack_B()
        {
            Test(
                GetDeck("modern-league-2020-08-18",3),
                new PostAstrolabeBan(),
                ArchetypeColor.B,
                typeof(EightRack),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Proliferate_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Parrit_SelenyaEldraziTaxes_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Jiggywiggy_KinnanLegends_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(KinnanLegends),
                null,
                null
            );
        }

        [Test]
        public void Deck08_TuggaNaxos_Infect_BG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",7),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck09_kensportsfan_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-08-18",8),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck10_sakuragi21722749_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck11_shoiwao_HeliodDevoted_WBG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck12_Azerate218_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",11),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck13_SvenSveeterSven_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Albyz_BringToNiv_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",13),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Carton_EsperShadow_WUB()
        {
            Test(
                GetDeck("modern-league-2020-08-18",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Bobthebuilder24_HeliodSisters_W()
        {
            Test(
                GetDeck("modern-league-2020-08-18",15),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(SoulSisters),
                typeof(HeliodSisters),
                null
            );
        }

        [Test]
        public void Deck17_waffl3haos_OrzhovEldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-08-18",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck18_harukispecial_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",17),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_RyanWu_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-league-2020-08-18",18),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_ben1234_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",19),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck21_CodeProvider_Grishoalbrand_BR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",20),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Grishoalbrand),
                null,
                null
            );
        }

        [Test]
        public void Deck22_sfitz_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",21),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Wuhsa_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-18",22),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck24_Ghost_Burn_WRG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",23),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Tedpanic_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-18",24),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Irra0770_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",25),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Mulldrifter_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Copilot11_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",27),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_hanrahandh_DevotedElves_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",28),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Elves),
                typeof(DevotedElves),
                null
            );
        }

        [Test]
        public void Deck30_SickWorld_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",29),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Bryzem1_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",30),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Metcalf23_BorosTaxes_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-18",31),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck33_hizakura_Polymorph_RG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",32),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Polymorph),
                null,
                null
            );
        }

        [Test]
        public void Deck34_DarkKeeper_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",33),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck35_rodebo_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-08-18",34),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck36_kogamo_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",35),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck37_Cheerios_SimicReclamation_UG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",36),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck38_paynechips_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-08-18",37),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck39_kogamo_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-18",38),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck40_brainstorm39_JeskaiControl_WUR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-18",39),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck41_Otmos_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-18",40),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck42_Storytime_KinnanDevoted_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",41),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                typeof(KinnanDevoted),
                null
            );
        }

        [Test]
        public void Deck43_122pablo_JeskaiAscendancy_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-08-18",42),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck44_JimmySetzer_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",43),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck45_fsst_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",44),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck46_Tarmofir3_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",45),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck47_Polikasoll_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-league-2020-08-18",46),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck48_TheGingerBrute_Faeries_UB()
        {
            Test(
                GetDeck("modern-league-2020-08-18",47),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(Faeries),
                null,
                null
            );
        }

        [Test]
        public void Deck49_dabigatran_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-18",48),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Xenowan_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-08-18",49),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck51_TheCodyHope_Elementals_WUBRG_Kaheera()
        {
            Test(
                GetDeck("modern-league-2020-08-18",50),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                ArchetypeCompanion.Kaheera
            );
        }

        [Test]
        public void Deck52_Menoti_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-08-18",51),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck53_SpikeYou_IzzetRestoreBalance_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",52),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck54_kado222_GoryoReanimator_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",53),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GoryoReanimator),
                null,
                null
            );
        }

        [Test]
        public void Deck55_CaptainFarbosa_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",54),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck56_cccaspar_WhiteDevotion_W()
        {
            Test(
                GetDeck("modern-league-2020-08-18",55),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(WhiteDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck57_kogamo_PrimevalTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",56),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck58_Taragon_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-18",57),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck59_marcosrocha_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",58),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck60_tuhoajatane_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",59),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck61_Alzik_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-18",60),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck62_MartinezDP_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-18",61),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck63_scipios_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",62),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck64_SunnyOsRego_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-08-18",63),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck65_musasabi_KGCAmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",64),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck66_Widok_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-08-18",65),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck67_MHayashi_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-08-18",66),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck68_PurpleRain_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",67),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck69_Jidden_ThopterUrza_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-18",68),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck70_tcgshin_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",69),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck71_DcNo_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",70),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck72_FriskiFraska_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",71),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck73_Thrall90_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-08-18",72),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
