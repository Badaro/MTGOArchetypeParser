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
#01 Erik157751: ETron (C)
#02 Metcalf23: SelenyaTaxes (WG, Yorion)
#03 pbarrrgh: SultaiReclamation (UBG)
#04 AlexFromTheNorth: BushwhackerZoo (WRG)
#05 zachattack23: TemurReclamation (URG)
#06 Avixy: Devoted (WG, Lurrus)
#07 vagner_mtg: GrixisShadow (UBR)
#08 PietroSas: Merfolk (U)
#09 Somniloquist_: JundShadow (BRG)
#10 forenmagra: SaheeliToLight (WUBRG)
#11 Snipers_are_bums: BringToNiv (WUBRG)
#12 Ingalsarm: Uroza (URG)
#13 LordoftheLobsters: WURGControl (WURG, Yorion)
#14 mtgmonte: UBRGShadow (UBRG)
#15 didoguidotti1: BantControl (WUG)
#16 robb93: AdNauseam (WUB)
#17 fenix4444: KGCTron (G)
#18 YBLime: ThopterUrza (WUBR)
#19 aspiringspike: GrixisLurrus (UBR)
#20 shine0905: GyrudaStompy (BRG, Gyruda)
#21 MHayashi: RedDeckWins (WR, Jegantha)
#22 Granham: JundMidrange (BRG)
#23 abombdiggity: Slivers (WUBRG)
#24 milikin: GruulMidrange (RG)
#25 Jidden: ThopterUrza (WU)
#26 saccij92: Humans (WUBRG)
#27 Karstinen: Bogles (WG, Lurrus)
#28 KAKOLOLO: BushwhackerZoo (RG)
#29 Darthtaneon: BushwhackerZoo (RG)
#30 edward40hands: GolgariMidrange (BG)
#31 Gods_Shadow: GrixisControl (UBR)
#32 thepensword: MonoRedProwess (R)
#33 vasko19: IzzetRestoreBalance (URG)
#34 Ftzz: SultaiReclamation (UBG)
#35 Juaspas: PrimevalTitan (BRG)
#36 MrRaeb: Uroza (UBG, Yorion)
#37 jessy_samek: Dredge (BRG)
#38 Yumas2: AmuletTitan (WURG)
#39 Rock_Star: RakdosProwess (BR, Lurrus)
#40 NorrathDecay: Burn (WR)
#41 bozo2112: Crabvine (UBG)
#42 yutya: BantControl (WUG, Yorion)
#43 _kg: Yawgmoth (BG)
#44 Metcalf23: BorosTaxes (WR)
#45 derramedefogo: GiftsStorm (UR)
#46 Zeekery: ThingAscension (WUR, Lurrus)
#47 in5ano: Scapeshift (URG, Yorion)
#48 cjucjujp: HardenedScales (BG, Lurrus)
#49 Pollu: AdNauseam (WUB)
#50 Gleiciano: TitanShift (RG)
#51 SvenSveeterSven: IzzetControl (UR)
#52 Papelucho10: Infect (UG)
#53 Yanti: Bogles (WU, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_league_2020_06_23 : EventTest
    {
        [Test]
        public void Deck01_Erik157751_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-06-23",0),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Metcalf23_SelenyaTaxes_WG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-23",1),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_pbarrrgh_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",2),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck04_AlexFromTheNorth_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",3),
                new PostCompanionChange(),
                ArchetypeColor.WRG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck05_zachattack23_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",4),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Avixy_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-23",5),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_vagnermtg_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-06-23",6),
                new PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck08_PietroSas_Merfolk_U()
        {
            Test(
                GetDeck("modern-league-2020-06-23",7),
                new PostCompanionChange(),
                ArchetypeColor.U,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Somniloquist_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",8),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck10_forenmagra_SaheeliToLight_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",9),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(SaheeliCombo),
                typeof(SaheeliToLight),
                null
            );
        }

        [Test]
        public void Deck11_Snipersarebums_BringToNiv_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",10),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Ingalsarm_Uroza_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",11),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck13_LordoftheLobsters_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-23",12),
                new PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck14_mtgmonte_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",13),
                new PostCompanionChange(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck15_didoguidotti1_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",14),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_robb93_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-06-23",15),
                new PostCompanionChange(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck17_fenix4444_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-06-23",16),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck18_YBLime_ThopterUrza_WUBR()
        {
            Test(
                GetDeck("modern-league-2020-06-23",17),
                new PostCompanionChange(),
                ArchetypeColor.WUBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck19_aspiringspike_GrixisLurrus_UBR()
        {
            Test(
                GetDeck("modern-league-2020-06-23",18),
                new PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(GrixisLurrus),
                null,
                null
            );
        }

        [Test]
        public void Deck20_shine0905_GyrudaStompy_BRG_Gyruda()
        {
            Test(
                GetDeck("modern-league-2020-06-23",19),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(GyrudaStompy),
                null,
                ArchetypeCompanion.Gyruda
            );
        }

        [Test]
        public void Deck21_MHayashi_RedDeckWins_WR_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-06-23",20),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(RedDeckWins),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck22_Granham_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",21),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck23_abombdiggity_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",22),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck24_milikin_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",23),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Jidden_ThopterUrza_WU()
        {
            Test(
                GetDeck("modern-league-2020-06-23",24),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck26_saccij92_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",25),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Karstinen_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-23",26),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_KAKOLOLO_BushwhackerZoo_RG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",27),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Darthtaneon_BushwhackerZoo_RG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",28),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck30_edward40hands_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",29),
                new PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck31_GodsShadow_GrixisControl_UBR()
        {
            Test(
                GetDeck("modern-league-2020-06-23",30),
                new PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck32_thepensword_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-06-23",31),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck33_vasko19_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",32),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck34_Ftzz_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",33),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck35_Juaspas_PrimevalTitan_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",34),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck36_MrRaeb_Uroza_UBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-23",35),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck37_jessysamek_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",36),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck38_Yumas2_AmuletTitan_WURG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",37),
                new PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck39_RockStar_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-23",38),
                new PostCompanionChange(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck40_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-06-23",39),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck41_bozo2112_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",40),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck42_yutya_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-23",41),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck43_kg_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",42),
                new PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck44_Metcalf23_BorosTaxes_WR()
        {
            Test(
                GetDeck("modern-league-2020-06-23",43),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck45_derramedefogo_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-06-23",44),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck46_Zeekery_ThingAscension_WUR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-23",45),
                new PostCompanionChange(),
                ArchetypeColor.WUR,
                typeof(ThingAscension),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck47_in5ano_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-23",46),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck48_cjucjujp_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-23",47),
                new PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck49_Pollu_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-06-23",48),
                new PostCompanionChange(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck50_Gleiciano_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",49),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck51_SvenSveeterSven_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-06-23",50),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Papelucho10_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-06-23",51),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck53_Yanti_Bogles_WU_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-23",52),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
