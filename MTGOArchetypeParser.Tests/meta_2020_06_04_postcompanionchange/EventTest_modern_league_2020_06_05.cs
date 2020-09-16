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
#01 Never_DidntHaveIt: BorosProwess (WR)
#02 Musagete: Devoted (WG, Lurrus)
#03 carlosalmeida: GruulMidrange (RG)
#04 Lucabireskusku: Inverter (UB)
#05 K4rl1991: HardenedScales (G)
#06 asmitchler: UBRGShadow (UBRG)
#07 crazeyr15: BringToNiv (WUBRG, Jegantha)
#08 hugofreitas1: GiftsStorm (URG)
#09 retiredcapivara: Dredge (BRG)
#10 Urzza100: BantControl (WUG, Yorion)
#11 didoguidotti1: GrixisShadow (UBR, Lurrus)
#12 Papelucho10: Infect (UG)
#13 SvenSvenSven: IzzetControl (UR)
#14 MaliciousMac: WURGControl (WURG, Yorion)
#15 Mussie99: AzoriusControl (WU)
#16 il_matagatto: Humans (WUBRG)
#17 Nightblue: Burn (WR)
#18 lSoLlAKirA: HeliodDevoted (WBG, Yorion)
#19 Lcario: MarduShadow (WBR)
#20 wambocombo2020: JundSmallpox (BRG, Lurrus)
#21 Metcalf23: BorosTaxes (WR, Lurrus)
#22 DreamsOfAshiok: RakdosMidrange (BR)
#23 Celldweller: SultaiReclamation (UBG, Yorion)
#24 llabmonkey: Scapeshift (URG, Yorion)
#25 mashmalovsky: OrzhovEldraziTaxes (WB)
#26 timewalkinonsunshine: TakingTurns (URG, Yorion)
#27 RandomOctopus: Uroza (WUG, Yorion)
#28 iuriper: SultaiReclamation (UBG)
#29 Aristocrats: Aristocrats (WB, Lurrus)
#30 pbarrrgh: BantControl (WUG, Yorion)
#31 DavidDPanda: ETron (C)
#32 HypnoticaL: RakdosProwess (BR, Lurrus)
#33 liu123: Bogles (WG, Lurrus)
#34 Boin: GolgariMidrange (BG, Lurrus)
#35 _qfortier: TakingTurns (URG)
#36 nahuel10: WUBGControl (WUBG, Yorion)
#37 DeeBoFour20: GTron (G, Jegantha)
#38 fpawlusz: KGCAmuletTitan (WUBRG)
#39 WeareVenom: BantControl (WUG)
#40 ary31415: JundMidrange (BRG)
#41 JouNick: JundShadow (BRG, Lurrus)
#42 Flight24White: Neobrand (UG)
#43 Wuhsa: BringToNiv (WUBRG, Jegantha)
#44 stefanocanclini: AdNauseam (WUB)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_league_2020_06_05 : EventTest
    {
        [Test]
        public void Deck01_NeverDidntHaveIt_BorosProwess_WR()
        {
            Test(
                GetDeck("modern-league-2020-06-05",0),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Musagete_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-05",1),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_carlosalmeida_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-06-05",2),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Lucabireskusku_Inverter_UB()
        {
            Test(
                GetDeck("modern-league-2020-06-05",3),
                new PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(Inverter),
                null,
                null
            );
        }

        [Test]
        public void Deck05_K4rl1991_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-06-05",4),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck06_asmitchler_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-05",5),
                new PostCompanionChange(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck07_crazeyr15_BringToNiv_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-06-05",6),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck08_hugofreitas1_GiftsStorm_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-05",7),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck09_retiredcapivara_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-05",8),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Urzza100_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-05",9),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_didoguidotti1_GrixisShadow_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-05",10),
                new PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_Papelucho10_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-06-05",11),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck13_SvenSvenSven_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-league-2020-06-05",12),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_MaliciousMac_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-05",13),
                new PostCompanionChange(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck15_Mussie99_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-06-05",14),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_ilmatagatto_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-05",15),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Nightblue_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-06-05",16),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck18_lSoLlAKirA_HeliodDevoted_WBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-05",17),
                new PostCompanionChange(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                typeof(HeliodDevoted),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_Lcario_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-league-2020-06-05",18),
                new PostCompanionChange(),
                ArchetypeColor.WBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck20_wambocombo2020_JundSmallpox_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-05",19),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(JundSmallpox),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_Metcalf23_BorosTaxes_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-05",20),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_DreamsOfAshiok_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-06-05",21),
                new PostCompanionChange(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Celldweller_SultaiReclamation_UBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-05",22),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck24_llabmonkey_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-05",23),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck25_mashmalovsky_OrzhovEldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-06-05",24),
                new PostCompanionChange(),
                ArchetypeColor.WB,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck26_timewalkinonsunshine_TakingTurns_URG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-05",25),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(TakingTurns),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck27_RandomOctopus_Uroza_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-05",26),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck28_iuriper_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-06-05",27),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Aristocrats_Aristocrats_WB_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-05",28),
                new PostCompanionChange(),
                ArchetypeColor.WB,
                typeof(Aristocrats),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_pbarrrgh_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-05",29),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck31_DavidDPanda_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-06-05",30),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck32_HypnoticaL_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-05",31),
                new PostCompanionChange(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck33_liu123_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-05",32),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck34_Boin_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-05",33),
                new PostCompanionChange(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck35_qfortier_TakingTurns_URG()
        {
            Test(
                GetDeck("modern-league-2020-06-05",34),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(TakingTurns),
                null,
                null
            );
        }

        [Test]
        public void Deck36_nahuel10_WUBGControl_WUBG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-06-05",35),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck37_DeeBoFour20_GTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-06-05",36),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck38_fpawlusz_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-06-05",37),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck39_WeareVenom_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-06-05",38),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck40_ary31415_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-06-05",39),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck41_JouNick_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-06-05",40),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck42_Flight24White_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-06-05",41),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck43_Wuhsa_BringToNiv_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-06-05",42),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck44_stefanocanclini_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-06-05",43),
                new PostCompanionChange(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }


    }
}
