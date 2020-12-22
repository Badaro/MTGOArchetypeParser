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
#01 ZYX_Jerry: Belcher (URG)
#02 UmekawaneikU: Hammer Time (WB, Lurrus)
#03 Tirifolix92: Bant Spirits (WUG)
#04 talos41: Temur Midrange (URG)
#05 ArchaeusDota: Oops All Spells (WUBG)
#06 thekingofnone: WBRG Shadow (WBRG)
#07 fer_magic: Snoop Goblins (BR)
#08 Zanman: Primeval Titan (BG)
#09 StableSalmon: Gruul Midrange (RG)
#10 Parrit: Azorius Taxes (WU, Yorion)
#11 Lavaridge: Temur Control (URG)
#12 darkpride: Mono Red Prowess (R)
#13 starfall: Boros Prowess (WR, Lurrus)
#14 Metcalf23: Mono White Taxes (W, Yorion)
#15 andresambiaze: Dredge (BRG)
#16 JMAK2000: KGC Tron (G)
#17 FAdvisor82: Mill (UB, Lurrus)
#18 menglee: Bogles (WUG)
#19 claudio0907: Reclaimer Titan (WG)
#20 rafusfito: Erayo Prison (WUB)
#21 Karnesis93: Shadow Prowess (BR, Lurrus)
#22 katobu: Merfolk (WU, Lurrus)
#23 Capriccioso: Grinding Breach (WUR)
#24 random_deck: Selenya Midrange (WG)
#25 lpfan: Boros Land Destruction (WR)
#26 xJCloud: Heliod Combo (WR)
#27 Frejat: Thopter Urza (WUBR)
#28 MartinezDP: Omnath Saheeli (WURG, Yorion)
#29 HummingBard: U Tron (U)
#30 JMoney8771: Infect (UG)
#31 tcgshin: Titan Shift (RG)
#32 The_Co: Mono White Taxes (W)
#33 nahuel10: Izzet Prowess (UR)
#34 Trailovsky: Shadow Prowess (BR, Lurrus)
#35 Mudda: Boros Prowess (WR)
#36 LFC: Heliod Combo (WG)
#37 rodeo: Burn (WR)
#38 DoctorQueller: Spirits (WU)
#39 iicloudzzmagic: Humans (WUBRG)
#40 gazmon48: Obosh Aggro (R, Obosh)
#41 mashmalovsky: Ad Nauseam (WUB)
#42 KoDiamonds: Heliod Combo (WBG)
#43 pbarrrgh: Sultai Control (UBG)
#44 Blitzlion27: Mill (UB, Lurrus)
#45 mechint: Simic Control (UG)
#46 weishengzhishabi: Sultai Control (UBG)
#47 Samcaster-Mage: E Tron (C)
#48 Curtisaxel: Infect (BG)
#49 kokoko098: Jeskai Breach (WURG, Jegantha)
#50 TuggaNaxos: Devoted (WG, Lurrus)
#51 djseb: Jund Midrange (BRG)
#52 Sommertroll: Heliod Combo (WG)
#53 potatopeople1: Jeskai Control (WUR)
#54 guispiller: Gifts Storm (UR)
#55 maple049: Hardened Scales (RG)
#56 Nilsfit: Jeskai Breach (WUR, Jegantha)
#57 Ivc: Azorius Control (WU)
#58 cityofcards: Temur Midrange (URG)
#59 Prisak: Mardu Midrange (WBR)
#60 iheartpuzzles: Rakdos Midrange (BR)
#61 bbotonline: Hardened Scales (G)
#62 DInglis: Primeval Titan (UG)
#63 didoguidotti1: WURG Control (WURG)
#64 Voltzwagon: Gruul Midrange (RG)
#65 Boland: Amulet Titan (RG)
#66 TheScrubInScrubs: Elementals (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_league_2020_12_22 : EventTest
    {
        [Test]
        public void Deck01_ZYXJerry_Belcher_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",0),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck02_UmekawaneikU_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-22",1),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Tirifolix92_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",2),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck04_talos41_TemurMidrange_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",3),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_ArchaeusDota_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",4),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck06_thekingofnone_WBRGShadow_WBRG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",5),
                new PostZendikarRising(),
                ArchetypeColor.WBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck07_fermagic_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-12-22",6),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck08_Zanman_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",7),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck09_StableSalmon_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",8),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Parrit_AzoriusTaxes_WU_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-22",9),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_Lavaridge_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",10),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_darkpride_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-12-22",11),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck13_starfall_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-22",12),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Metcalf23_MonoWhiteTaxes_W_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-22",13),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck15_andresambiaze_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",14),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck16_JMAK2000_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-12-22",15),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck17_FAdvisor82_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-22",16),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_menglee_Bogles_WUG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",17),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck19_claudio0907_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",18),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck20_rafusfito_ErayoPrison_WUB()
        {
            Test(
                GetDeck("modern-league-2020-12-22",19),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(ErayoPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Karnesis93_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-22",20),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_katobu_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-22",21),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_Capriccioso_GrindingBreach_WUR()
        {
            Test(
                GetDeck("modern-league-2020-12-22",22),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck24_randomdeck_SelenyaMidrange_WG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",23),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck25_lpfan_BorosLandDestruction_WR()
        {
            Test(
                GetDeck("modern-league-2020-12-22",24),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(BorosLandDestruction),
                null,
                null
            );
        }

        [Test]
        public void Deck26_xJCloud_HeliodCombo_WR()
        {
            Test(
                GetDeck("modern-league-2020-12-22",25),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Frejat_ThopterUrza_WUBR()
        {
            Test(
                GetDeck("modern-league-2020-12-22",26),
                new PostZendikarRising(),
                ArchetypeColor.WUBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck28_MartinezDP_OmnathSaheeli_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-12-22",27),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                typeof(OmnathSaheeli),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck29_HummingBard_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-12-22",28),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck30_JMoney8771_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",29),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck31_tcgshin_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",30),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck32_TheCo_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-12-22",31),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck33_nahuel10_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-22",32),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck34_Trailovsky_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-22",33),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck35_Mudda_BorosProwess_WR()
        {
            Test(
                GetDeck("modern-league-2020-12-22",34),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck36_LFC_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",35),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck37_rodeo_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-12-22",36),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck38_DoctorQueller_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-12-22",37),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck39_iicloudzzmagic_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",38),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck40_gazmon48_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-12-22",39),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck41_mashmalovsky_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-12-22",40),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck42_KoDiamonds_HeliodCombo_WBG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",41),
                new PostZendikarRising(),
                ArchetypeColor.WBG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck43_pbarrrgh_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",42),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck44_Blitzlion27_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-22",43),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck45_mechint_SimicControl_UG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",44),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck46_weishengzhishabi_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",45),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck47_SamcasterMage_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-12-22",46),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck48_Curtisaxel_Infect_BG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",47),
                new PostZendikarRising(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck49_kokoko098_JeskaiBreach_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-12-22",48),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                typeof(JeskaiBreach),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck50_TuggaNaxos_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-12-22",49),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck51_djseb_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",50),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Sommertroll_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",51),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck53_potatopeople1_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-league-2020-12-22",52),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck54_guispiller_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-12-22",53),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck55_maple049_HardenedScales_RG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",54),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck56_Nilsfit_JeskaiBreach_WUR_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-12-22",55),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(JeskaiAscendancy),
                typeof(JeskaiBreach),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck57_Ivc_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-12-22",56),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck58_cityofcards_TemurMidrange_URG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",57),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck59_Prisak_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-league-2020-12-22",58),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck60_iheartpuzzles_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-12-22",59),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck61_bbotonline_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-12-22",60),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck62_DInglis_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",61),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck63_didoguidotti1_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",62),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck64_Voltzwagon_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",63),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck65_Boland_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",64),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck66_TheScrubInScrubs_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-12-22",65),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }


    }
}
