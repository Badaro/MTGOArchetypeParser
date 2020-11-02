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
#01 SlitherBlade: Temur Control (URG, Yorion)
#02 yamakiller: Crabvine (UBG)
#03 Cherryxman: Abzan Eldrazi Taxes (WBG)
#04 Voltzwagon: Gruul Midrange (RG)
#05 IrishSoda: Naya Landfall (WRG, Jegantha)
#06 POC: Infect (BG)
#07 Gionax: Boros Land Destruction (WR)
#08 matiaskm: Devoted (WG, Lurrus)
#09 Lillia: Amulet Titan (URG)
#10 shoktroopa: U Tron (UB)
#11 yeaux: Heliod Combo (W)
#12 Martin_Dominguez: Heliod Devoted (WG)
#13 anamika: Naya Midrange (WRG)
#14 Vertyx13: KGC Tron (G)
#15 JUJUBEAN__2004: UBRG Control (UBRG)
#16 DrPP: Mono Red Prowess (R)
#17 Munich_Casual: Jund Midrange (BRG, Lurrus)
#18 Masror: Azorius Taxes (WU, Yorion)
#19 Tirifolix92: Bant Midrange (WUG)
#20 yneves: Neobrand (UG)
#21 Cheeseinat0r: Rakdos Midrange (BR)
#22 Amplumnox: Burn (WR)
#23 charliegwa: Jeskai Control (WUR)
#24 Bellstriker: Izzet Prowess (UR)
#25 Cherryxman: Selective Oracle (WU)
#26 lucajak: Reclaimer Titan (WRG)
#27 BernardoDG: Jund Midrange (BRG)
#28 DottorXavier: Mill (UB)
#29 wolfgangfraueneder: Izzet Control (UR)
#30 debei: Shadow Prowess (BR, Lurrus)
#31 ruthl3ss: Boros Midrange (WR)
#32 Misplacedginger: WURG Control (WURG)
#33 Stdlr: Mono Red Prowess (R, Jegantha)
#34 meanfannypack: Orzhov Eldrazi Taxes (WB)
#35 DoctorQueller: Bant Spirits (WUG)
#36 Wuhsa: Niv To Light (WUBRG)
#37 Curtisaxel: Heliod Combo (WG)
#38 FedeG: Humans (WUBRG)
#39 _EzMud1: Izzet Restore Balance (URG)
#40 Hybrid7: Gifts Storm (UR, Jegantha)
#41 Sonkerz: Temur Control (URG)
#42 pepeteam: Scapeshift (URG)
#43 JCuff: Dredge (BRG)
#44 Chandrian: Grixis Control (UBR, Lurrus)
#45 blitzkrieg1986: Hammer Time (W)
#46 rubenelvas: Ad Nauseam (WUB)
#47 Kaziku: Oops All Spells (WUBRG)
#48 Eyedea90: Izzet Restore Balance (UR)
#49 amane0201: Valakut Field (UBRG)
#50 603Leb: Omnath Saheeli (WURG, Jegantha)
#51 Qoiet: Rakdos Midrange (BR)
#52 OnDutyMedic: Snoop Goblins (BR)
#53 FAdvisor82: Dice Factory Tron (G)
#54 Mateusf34: E Tron (C)
#55 Zxrogue: Reclaimer Titan (WURG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_10_30 : EventTest
    {
        [Test]
        public void Deck01_SlitherBlade_TemurControl_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-30",0),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_yamakiller_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",1),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Cherryxman_AbzanEldraziTaxes_WBG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",2),
                new PostZendikarRising(),
                ArchetypeColor.WBG,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Voltzwagon_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",3),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_IrishSoda_NayaLandfall_WRG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-30",4),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(NayaLandfall),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck06_POC_Infect_BG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",5),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Gionax_BorosLandDestruction_WR()
        {
            Test(
                GetDeck("modern-league-2020-10-30",6),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(BorosLandDestruction),
                null,
                null
            );
        }

        [Test]
        public void Deck08_matiaskm_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-30",7),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_Lillia_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",8),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck10_shoktroopa_UTron_UB()
        {
            Test(
                GetDeck("modern-league-2020-10-30",9),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck11_yeaux_HeliodCombo_W()
        {
            Test(
                GetDeck("modern-league-2020-10-30",10),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck12_MartinDominguez_HeliodDevoted_WG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",11),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck13_anamika_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",12),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Vertyx13_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-10-30",13),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck15_JUJUBEAN2004_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",14),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_DrPP_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-10-30",15),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck17_MunichCasual_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-30",16),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_Masror_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-10-30",17),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_Tirifolix92_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",18),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_yneves_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",19),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Cheeseinat0r_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-10-30",20),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Amplumnox_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-10-30",21),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck23_charliegwa_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-10-30",22),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Bellstriker_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-30",23),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Cherryxman_SelectiveOracle_WU()
        {
            Test(
                GetDeck("modern-league-2020-10-30",24),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(SelectiveOracle),
                null,
                null
            );
        }

        [Test]
        public void Deck26_lucajak_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",25),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck27_BernardoDG_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",26),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck28_DottorXavier_Mill_UB()
        {
            Test(
                GetDeck("modern-league-2020-10-30",27),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck29_wolfgangfraueneder_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-30",28),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_debei_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-30",29),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_ruthl3ss_BorosMidrange_WR()
        {
            Test(
                GetDeck("modern-league-2020-10-30",30),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Misplacedginger_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",31),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Stdlr_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-30",32),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck34_meanfannypack_OrzhovEldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-10-30",33),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck35_DoctorQueller_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",34),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck36_Wuhsa_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",35),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck37_Curtisaxel_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",36),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck38_FedeG_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",37),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck39_EzMud1_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",38),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck40_Hybrid7_GiftsStorm_UR_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-30",39),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck41_Sonkerz_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",40),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck42_pepeteam_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",41),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck43_JCuff_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",42),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck44_Chandrian_GrixisControl_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-10-30",43),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck45_blitzkrieg1986_HammerTime_W()
        {
            Test(
                GetDeck("modern-league-2020-10-30",44),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck46_rubenelvas_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-10-30",45),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck47_Kaziku_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",46),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck48_Eyedea90_IzzetRestoreBalance_UR()
        {
            Test(
                GetDeck("modern-league-2020-10-30",47),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck49_amane0201_ValakutField_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",48),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(ValakutField),
                null,
                null
            );
        }

        [Test]
        public void Deck50_603Leb_OmnathSaheeli_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-10-30",49),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck51_Qoiet_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-10-30",50),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck52_OnDutyMedic_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-10-30",51),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck53_FAdvisor82_DiceFactoryTron_G()
        {
            Test(
                GetDeck("modern-league-2020-10-30",52),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(DiceFactoryTron),
                null,
                null
            );
        }

        [Test]
        public void Deck54_Mateusf34_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-10-30",53),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck55_Zxrogue_ReclaimerTitan_WURG()
        {
            Test(
                GetDeck("modern-league-2020-10-30",54),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }


    }
}
