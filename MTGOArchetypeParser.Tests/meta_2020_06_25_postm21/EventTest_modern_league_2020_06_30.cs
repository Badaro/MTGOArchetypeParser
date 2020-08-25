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
#01 603Leb: ETron (C)
#02 SpiderSpace: IzzetProwess (UR)
#03 derramedefogo: GiftsStorm (UR)
#04 sublimeloudog: HardenedScales (G)
#05 JMoney8771: Infect (UG)
#06 TennTyou: BringToNiv (WUBRG)
#07 affen_burn23: TemurControl (URG)
#08 MHayashi: MonoRedProwess (R, Jegantha)
#09 TheAznYoshi: GruulMidrange (RG)
#10 GHash77: SultaiControl (UBG)
#11 yutya: TakingTurns (WUG, Yorion)
#12 Metcalf23: BorosTaxes (WR, Lurrus)
#13 Busterbrown52: Elementals (WUBRG)
#14 Planet-Blade: UBRGShadow (UBRG)
#15 TheRealBlueMTG: MonoRedProwess (R)
#16 WeareVenom: BantControl (WUG)
#17 Volollo: Humans (WUBRG)
#18 Heiring: OrzhovTokens (WB)
#19 Asoen: RakdosMidrange (BR)
#20 ContraEgo: ThopterUrza (UBR)
#21 DemianDesposito10: BorosProwess (WR, Jegantha)
#22 buralee: BantMidrange (WUG)
#23 cnofafva: AmuletTitan (UBRG)
#24 kanister: SnoopGoblins (BR)
#25 thepensword: IzzetControl (UR)
#26 paucr5: HeliodDevoted (WUG)
#27 TheMadDollMaker: BorosTaxes (WR)
#28 haubidtran: Uroza (WUG, Yorion)
#29 Cherryxman: IncineratorBurn (R)
#30 in5ano: Scapeshift (URG, Yorion)
#31 Fabrice_K: SultaiReclamation (UBG, Yorion)
#32 Jidden: ThopterUrza (WU)
#33 PizzaTurtle: Bogles (WG, Lurrus)
#34 Curtisaxel: BantSpirits (WUG)
#35 Mordeka1ser: BringToNiv (WUBRG, Yorion)
#36 sicsmoo: GTron (G)
#37 ACG88: Crabvine (UBG)
#38 Night_Owl_61: JundMidrange (BRG)
#39 mariogomes097: GrixisShadow (UBR)
#40 RodolfoSFD0: TitanShift (RG)
#41 marcofabrizi: UBRGControl (UBRG)
#42 m_stanzione: IzzetRestoreBalance (URG)
#43 nielsen333: PrimevalTitan (BRG)
#44 number1pwnr: UTron (U)
#45 meanfannypack: Devoted (WG, Lurrus)
#46 Deulotar: GolgariMidrange (BG)
#47 Magic_Rainbows: IncineratorBurn (R)
#48 Easyldur1: Dredge (BRG)
#49 Lcario: RakdosProwess (BR, Lurrus)
#50 TubbyBatman: TemurDelver (URG)
#51 FranMtg: Burn (WR)
#52 Amatox: BantBlink (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_league_2020_06_30 : EventTest
    {
        [Test]
        public void Deck01_603Leb_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-06-30",0),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck02_SpiderSpace_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-06-30",1),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck03_derramedefogo_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-06-30",2),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck04_sublimeloudog_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-06-30",3),
                new PostM21(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck05_JMoney8771_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",4),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck06_TennTyou_BringToNiv_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",5),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck07_affenburn23_TemurControl_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",6),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_MHayashi_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-06-30",7),
                new PostM21(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck09_TheAznYoshi_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",8),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_GHash77_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",9),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_yutya_TakingTurns_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-30",10),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(TakingTurns),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_Metcalf23_BorosTaxes_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-30",11),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_Busterbrown52_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",12),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck14_PlanetBlade_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",13),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck15_TheRealBlueMTG_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-06-30",14),
                new PostM21(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck16_WeareVenom_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",15),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Volollo_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",16),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Heiring_OrzhovTokens_WB()
        {
            Test(
                GetDeck("modern-league-2020-06-30",17),
                new PostM21(),
                ArchetypeColor.WB,
                typeof(Tokens),
                typeof(OrzhovTokens),
                null
            );
        }

        [Test]
        public void Deck19_Asoen_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-06-30",18),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_ContraEgo_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-06-30",19),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck21_DemianDesposito10_BorosProwess_WR_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-06-30",20),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck22_buralee_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",21),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck23_cnofafva_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",22),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck24_kanister_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-06-30",23),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck25_thepensword_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-06-30",24),
                new PostM21(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck26_paucr5_HeliodDevoted_WUG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",25),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                null
            );
        }

        [Test]
        public void Deck27_TheMadDollMaker_BorosTaxes_WR()
        {
            Test(
                GetDeck("modern-league-2020-06-30",26),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck28_haubidtran_Uroza_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-30",27),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck29_Cherryxman_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-league-2020-06-30",28),
                new PostM21(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck30_in5ano_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-30",29),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck31_FabriceK_SultaiReclamation_UBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-30",30),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck32_Jidden_ThopterUrza_WU()
        {
            Test(
                GetDeck("modern-league-2020-06-30",31),
                new PostM21(),
                ArchetypeColor.WU,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck33_PizzaTurtle_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-30",32),
                new PostM21(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck34_Curtisaxel_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",33),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck35_Mordeka1ser_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-30",34),
                new PostM21(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck36_sicsmoo_GTron_G()
        {
            Test(
                GetDeck("modern-league-2020-06-30",35),
                new PostM21(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck37_ACG88_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",36),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck38_NightOwl61_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",37),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck39_mariogomes097_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-06-30",38),
                new PostM21(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck40_RodolfoSFD0_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",39),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck41_marcofabrizi_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",40),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck42_mstanzione_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",41),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck43_nielsen333_PrimevalTitan_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",42),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck44_number1pwnr_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-06-30",43),
                new PostM21(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck45_meanfannypack_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-30",44),
                new PostM21(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck46_Deulotar_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",45),
                new PostM21(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck47_MagicRainbows_IncineratorBurn_R()
        {
            Test(
                GetDeck("modern-league-2020-06-30",46),
                new PostM21(),
                ArchetypeColor.R,
                typeof(Burn),
                typeof(IncineratorBurn),
                null
            );
        }

        [Test]
        public void Deck48_Easyldur1_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",47),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck49_Lcario_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-30",48),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck50_TubbyBatman_TemurDelver_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",49),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(Delver),
                typeof(TemurDelver),
                null
            );
        }

        [Test]
        public void Deck51_FranMtg_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-06-30",50),
                new PostM21(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Amatox_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-league-2020-06-30",51),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }


    }
}
