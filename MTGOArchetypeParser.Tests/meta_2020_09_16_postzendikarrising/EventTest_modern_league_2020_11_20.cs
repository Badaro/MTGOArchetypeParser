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
#01 Wirmaleff: Mill (UB)
#02 Ely_Silva: Burn (WRG)
#03 6argamel: Mono White Taxes (W, Yorion)
#04 GideonRavensword: Dredge (BRG)
#05 Diotima: U Tron (U)
#06 soggymeatball: KGC Tron (G)
#07 Beicodegeia: Gifts Storm (UR)
#08 llabmonkey: Obosh Aggro (R, Obosh)
#09 osk4: Niv To Light (WUBRG, Yorion)
#10 daibloXSC: WUBG Control (WUBG)
#11 nahuel10: Izzet Prowess (UR)
#12 TuralyonMap: Spirits (WU)
#13 toondoslav: Infect (UG)
#14 StreexIT: Neobrand (UG)
#15 ContraEgo: Thopter Urza (UBR)
#16 TheWonderLord: Humans (WUBRG)
#17 Karstinen: Mono White Taxes (W)
#18 Foxantes: E Tron (C)
#19 GabeGiulio98: Heliod Combo (WG)
#20 nmontaquila: Hammer Time (W, Lurrus)
#21 Giaws: Grixis Shadow (UBR)
#22 leclairandy: Shadow Prowess (BR, Lurrus)
#23 blavantasian: Ad Nauseam (WUB)
#24 BSK_hercules: Sultai Control (UBG)
#25 Voltzwagon: Gruul Midrange (RG)
#26 StreexIT: Bant Spirits (WUG)
#27 Lucabireskusku: Jeskai Control (WUR)
#28 barczek: Dimir Control (UB)
#29 Erik157751: Crabvine (UBG)
#30 twinlesstwin: Izzet Control (UR)
#31 oskiyaa: Devoted (WG)
#32 TheWonderLord: Elves (G)
#33 TheWonderLord: Snoop Goblins (BR)
#34 Diatomic: Izzet Control (UR)
#35 Javipv: Reclaimer Titan (WURG)
#36 pbarrrgh: WURG Control (WURG)
#37 HNSDMPF: Hardened Scales (G)
#38 ZYX_Jerry: Oops All Spells (WUBRG)
#39 Tabaqui1987: Jund Shadow (BRG)
#40 SpiderSpace: Mono White Taxes (W, Yorion)
#41 LinXiao: Bant Midrange (WUG)
#42 rojanosa: Faeries (UB)
#43 Leviathan102: Amulet Titan (URG)
#44 603Leb: Selenya Taxes (WG, Yorion)
#45 bhood16: Jund Midrange (BRG)
#46 Borjillamtg10: Rakdos Midrange (BR)
#47 Lollosauro: Titan Stompy (BRG, Gyruda)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_11_20 : EventTest
    {
        [Test]
        public void Deck01_Wirmaleff_Mill_UB()
        {
            Test(
                GetDeck("modern-league-2020-11-20",0),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck02_ElySilva_Burn_WRG()
        {
            Test(
                GetDeck("modern-league-2020-11-20",1),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck03_6argamel_MonoWhiteTaxes_W_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-20",2),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_GideonRavensword_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-11-20",3),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Diotima_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-11-20",4),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck06_soggymeatball_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-11-20",5),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck07_Beicodegeia_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-20",6),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck08_llabmonkey_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-11-20",7),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck09_osk4_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-20",8),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck10_daibloXSC_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-league-2020-11-20",9),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_nahuel10_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-20",10),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck12_TuralyonMap_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-11-20",11),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck13_toondoslav_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-11-20",12),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck14_StreexIT_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-11-20",13),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck15_ContraEgo_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-11-20",14),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck16_TheWonderLord_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-20",15),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Karstinen_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-11-20",16),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Foxantes_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-11-20",17),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck19_GabeGiulio98_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-11-20",18),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck20_nmontaquila_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-20",19),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_Giaws_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-11-20",20),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck22_leclairandy_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-11-20",21),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_blavantasian_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-11-20",22),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck24_BSKhercules_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-11-20",23),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Voltzwagon_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-11-20",24),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck26_StreexIT_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-11-20",25),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck27_Lucabireskusku_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-11-20",26),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck28_barczek_DimirControl_UB()
        {
            Test(
                GetDeck("modern-league-2020-11-20",27),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Erik157751_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-league-2020-11-20",28),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck30_twinlesstwin_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-20",29),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_oskiyaa_Devoted_WG()
        {
            Test(
                GetDeck("modern-league-2020-11-20",30),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck32_TheWonderLord_Elves_G()
        {
            Test(
                GetDeck("modern-league-2020-11-20",31),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Elves),
                null,
                null
            );
        }

        [Test]
        public void Deck33_TheWonderLord_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-11-20",32),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck34_Diatomic_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-11-20",33),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck35_Javipv_ReclaimerTitan_WURG()
        {
            Test(
                GetDeck("modern-league-2020-11-20",34),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck36_pbarrrgh_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-11-20",35),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck37_HNSDMPF_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-11-20",36),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck38_ZYXJerry_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-11-20",37),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck39_Tabaqui1987_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-11-20",38),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck40_SpiderSpace_MonoWhiteTaxes_W_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-20",39),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck41_LinXiao_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-11-20",40),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck42_rojanosa_Faeries_UB()
        {
            Test(
                GetDeck("modern-league-2020-11-20",41),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Faeries),
                null,
                null
            );
        }

        [Test]
        public void Deck43_Leviathan102_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-11-20",42),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck44_603Leb_SelenyaTaxes_WG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-11-20",43),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck45_bhood16_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-11-20",44),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck46_Borjillamtg10_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-11-20",45),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck47_Lollosauro_TitanStompy_BRG_Gyruda()
        {
            Test(
                GetDeck("modern-league-2020-11-20",46),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(TitanStompy),
                null,
                ArchetypeCompanion.Gyruda
            );
        }


    }
}
