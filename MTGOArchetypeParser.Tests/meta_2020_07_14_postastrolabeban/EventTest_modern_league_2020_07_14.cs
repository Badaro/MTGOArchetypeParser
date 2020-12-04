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
#01 ary31415: Orzhov Taxes (WB)
#02 TheCodyHope: Elementals (WUBRG)
#03 MHayashi: Mono Red Prowess (R, Jegantha)
#04 Czechito: Izzet Control (UR)
#05 ljex: Izzet Prowess (UR)
#06 Trellon: Orrery Tron (UG)
#07 ack93: Azorius Control (WU)
#08 Hampuse1: Dice Factory Tron (C)
#09 Novaphantom: KGC Tron (G)
#10 cftsoc3: Mono Red Prowess (R)
#11 JewishLeprechaun: Hardened Scales (G)
#12 Aeolus1295: Amulet Titan (UG)
#13 JtoJ: UBRG Control (UBRG)
#14 katobu: Merfolk (U)
#15 hugofreitas1: Gifts Storm (UR)
#16 Azuregun: E Tron (C)
#17 osmanozguney: Rakdos Midrange (BR)
#18 saccij92: Humans (WUBRG)
#19 MlckyB: Bogles (WG)
#20 Shorak123: Sultai Control (UBG)
#21 Kurusu: Kiki Chord (WURG, Yorion)
#22 jvidarte: Burn (WR)
#23 wefald: Inverter (UB)
#24 Wall_of_Bromens: Blue Living End (WU)
#25 Xenowan: Jeskai Ascendancy (WURG, Jegantha)
#26 PlaneswalkerYami: Jeskai Prowess (WUR, Lurrus)
#27 Metcalf23: Boros Taxes (WR, Lurrus)
#28 toya: Rakdos Midrange (BR, Lurrus)
#29 Skrown: Dredge (BRG)
#30 Urzza100: Bant Control (WUG, Yorion)
#31 Borjillamtg10: Snoop Goblins (BR)
#32 Juaspas: Scapeshift (URG, Yorion)
#33 doughhater: Thalia Stompy (WR)
#34 RealJoy: UBRG Shadow (UBRG)
#35 Polikasoll: Incinerator Burn (R)
#36 mashmalovsky: Ad Nauseam (WUB)
#37 TheNobodys: Thopter Urza (WUB)
#38 ScreenwriterNY: Sultai Control (UBG, Yorion)
#39 MastaHorus: Izzet Living End (UR)
#40 tarmociccio89: Izzet Phoenix (UR)
#41 Fabrice_K: Bant Control (WUG, Yorion)
#42 LordoftheLobsters: U Tron (U)
#43 leuhohms: Infect (UG)
#44 Sonkerz: Temur Delver (URG)
#45 Wuhsa: Niv To Light (WUBRG, Yorion)
#46 albert62: Jund Midrange (BRG)
#47 Bruno_Mineiro: Mono White Taxes (W)
#48 azax: Neobrand (UG)
#49 digitaldrummer: Combo Elves (G)
#50 imperatorek: Devoted (WG, Lurrus)
#51 KoDiamonds: Gruul Midrange (RG)
#52 DaniMRebel: Selenya Taxes (WG)
#53 UrbanPope: Rakdos Prowess (BR, Lurrus)
#54 Brosterman: Grixis Shadow (UBR)
#55 December18: Titan Shift (RG)
#56 Julgrahn: Restore Balance (WURG, Jegantha)
#57 kogamo: Izzet Prowess (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_league_2020_07_14 : EventTest
    {
        [Test]
        public void Deck01_ary31415_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-07-14",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck02_TheCodyHope_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-14",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck03_MHayashi_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-07-14",2),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck04_Czechito_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-14",3),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_ljex_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-14",4),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Trellon_OrreryTron_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-14",5),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(GTron),
                typeof(OrreryTron),
                null
            );
        }

        [Test]
        public void Deck07_ack93_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-14",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Hampuse1_DiceFactoryTron_C()
        {
            Test(
                GetDeck("modern-league-2020-07-14",7),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(DiceFactoryTron),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Novaphantom_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-07-14",8),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck10_cftsoc3_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-07-14",9),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck11_JewishLeprechaun_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-07-14",10),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Aeolus1295_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-14",11),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck13_JtoJ_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-14",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_katobu_Merfolk_U()
        {
            Test(
                GetDeck("modern-league-2020-07-14",13),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck15_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-14",14),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Azuregun_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-07-14",15),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck17_osmanozguney_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-14",16),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck18_saccij92_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-14",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck19_MlckyB_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-07-14",18),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Shorak123_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-07-14",19),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Kurusu_KikiChord_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-14",20),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck22_jvidarte_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-14",21),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck23_wefald_Inverter_UB()
        {
            Test(
                GetDeck("modern-league-2020-07-14",22),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(Inverter),
                null,
                null
            );
        }

        [Test]
        public void Deck24_WallofBromens_BlueLivingEnd_WU()
        {
            Test(
                GetDeck("modern-league-2020-07-14",23),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(LivingEnd),
                typeof(BlueLivingEnd),
                null
            );
        }

        [Test]
        public void Deck25_Xenowan_JeskaiAscendancy_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-07-14",24),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck26_PlaneswalkerYami_JeskaiProwess_WUR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-14",25),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_Metcalf23_BorosTaxes_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-14",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_toya_RakdosMidrange_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-14",27),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_Skrown_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-14",28),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Urzza100_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-14",29),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck31_Borjillamtg10_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-07-14",30),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck32_Juaspas_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-14",31),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck33_doughhater_ThaliaStompy_WR()
        {
            Test(
                GetDeck("modern-league-2020-07-14",32),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(ThaliaStompy),
                null,
                null
            );
        }

        [Test]
        public void Deck34_RealJoy_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-07-14",33),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck35_Polikasoll_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-league-2020-07-14",34),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck36_mashmalovsky_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-07-14",35),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck37_TheNobodys_ThopterUrza_WUB()
        {
            Test(
                GetDeck("modern-league-2020-07-14",36),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck38_ScreenwriterNY_SultaiControl_UBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-14",37),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck39_MastaHorus_IzzetLivingEnd_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-14",38),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetLivingEnd),
                null
            );
        }

        [Test]
        public void Deck40_tarmociccio89_IzzetPhoenix_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-14",39),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(IzzetPhoenix),
                null,
                null
            );
        }

        [Test]
        public void Deck41_FabriceK_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-14",40),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck42_LordoftheLobsters_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-07-14",41),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck43_leuhohms_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-14",42),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck44_Sonkerz_TemurDelver_URG()
        {
            Test(
                GetDeck("modern-league-2020-07-14",43),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Delver),
                typeof(TemurDelver),
                null
            );
        }

        [Test]
        public void Deck45_Wuhsa_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-07-14",44),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck46_albert62_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-07-14",45),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck47_BrunoMineiro_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-07-14",46),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck48_azax_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-07-14",47),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck49_digitaldrummer_ComboElves_G()
        {
            Test(
                GetDeck("modern-league-2020-07-14",48),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Elves),
                typeof(ComboElves),
                null
            );
        }

        [Test]
        public void Deck50_imperatorek_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-14",49),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck51_KoDiamonds_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-14",50),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck52_DaniMRebel_SelenyaTaxes_WG()
        {
            Test(
                GetDeck("modern-league-2020-07-14",51),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck53_UrbanPope_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-07-14",52),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck54_Brosterman_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-07-14",53),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck55_December18_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-07-14",54),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck56_Julgrahn_RestoreBalance_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-07-14",55),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(RestoreBalance),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck57_kogamo_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-07-14",56),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }


    }
}
