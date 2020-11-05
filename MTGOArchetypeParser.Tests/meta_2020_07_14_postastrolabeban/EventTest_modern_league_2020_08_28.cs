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
#01 BaronOfBacon: Hammer Time (WR, Lurrus)
#02 B1gDan: Jund Shadow (BRG, Lurrus)
#03 Bordas99: Gruul Midrange (RG)
#04 fede1: Rakdos Midrange (BR)
#05 hugofreitas1: Gifts Storm (UR)
#06 tcgshin: Titan Shift (RG)
#07 Bruno_Mineiro: Jund Midrange (BRG)
#08 Esqpoe: Eight Rack (B)
#09 Srobmin: Mono Red Prowess (R, Jegantha)
#10 Mordeka1ser: Niv To Light (WUBRG, Yorion)
#11 AngledLuffa: Bant Midrange (WUG)
#12 DrSpectacles: Humans (WUBRG)
#13 Butakov: Yawgmoth (BG)
#14 Rosie54: Snoop Goblins (BR)
#15 kaktusowysmok: Merfolk (WU, Lurrus)
#16 DoctorQueller: Spirits (WU)
#17 junghans: Heliod Combo (WG)
#18 brainstorm39: Jeskai Control (WUR, Yorion)
#19 Leyline_of_the_Cat: Bant Spirits (WUG)
#20 SeeFour: Lantern (UBRG)
#21 jaximus5: Primeval Titan (URG)
#22 Ikashy: Dredge (BRG)
#23 Mistakenn: Living End (BRG)
#24 MaliciousMac: Bant Control (WUG)
#25 xzeroxx: Izzet Prowess (UR)
#26 chris 0815: Snoop Goblins (BR)
#27 TheRedDawn2: Burn (WR)
#28 122pablo: Jeskai Ascendancy (WURG, Jegantha)
#29 thedoc96: Rakdos Prowess (BR, Lurrus)
#30 NeryNeto: Temur Delver (URG)
#31 MlckyB: Bogles (WG)
#32 wowqqqa: KGC Tron (G)
#33 sydneydude: Boros Prowess (WR, Lurrus)
#34 PuntThenWhine: KGC Amulet Titan (WUBRG)
#35 Frozon: Hardened Scales (G)
#36 603Leb: Valakut Field (URG)
#37 Kumpanen: Grixis Shadow (UBR)
#38 Diotima: Mono White Eldrazi Taxes (W)
#39 lewisyo: Ad Nauseam (WUB)
#40 GHash77: Neobrand (UG)
#41 Antoine57437: Abzan Company (WBG)
#42 GrilledCheese: Reclaimer Titan (WRG)
#43 abijhavs: Mono Red Prowess (R)
#44 Parrit: Mono White Taxes (W)
#45 mechrataal: Jund Shadow (BRG)
#46 Alcander: Azorius Control (WU)
#47 kogamo: Valakut Field (BRG)
#48 MrSeri: Heliod Combo (WG)
#49 ferrum0728: Mardu Shadow (WBR)
#50 yPrincipe: E Tron (C)
#51 Ingalsarm: Temur Reclamation (URG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_league_2020_08_28 : EventTest
    {
        [Test]
        public void Deck01_BaronOfBacon_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-28",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_B1gDan_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-28",1),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Bordas99_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",2),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_fede1_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-08-28",3),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_hugofreitas1_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-28",4),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck06_tcgshin_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",5),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck07_BrunoMineiro_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",6),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Esqpoe_EightRack_B()
        {
            Test(
                GetDeck("modern-league-2020-08-28",7),
                new PostAstrolabeBan(),
                ArchetypeColor.B,
                typeof(EightRack),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Srobmin_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-08-28",8),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck10_Mordeka1ser_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-28",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_AngledLuffa_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_DrSpectacles_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Butakov_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",12),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Rosie54_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-08-28",13),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck15_kaktusowysmok_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-28",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_DoctorQueller_Spirits_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-28",15),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck17_junghans_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck18_brainstorm39_JeskaiControl_WUR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-28",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_LeylineoftheCat_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",18),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck20_SeeFour_Lantern_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",19),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(Lantern),
                null,
                null
            );
        }

        [Test]
        public void Deck21_jaximus5_PrimevalTitan_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",20),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Ikashy_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",21),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Mistakenn_LivingEnd_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",22),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(LivingEnd),
                null,
                null
            );
        }

        [Test]
        public void Deck24_MaliciousMac_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",23),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck25_xzeroxx_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-28",24),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck26_chris0815_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-08-28",25),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck27_TheRedDawn2_Burn_WR()
        {
            Test(
                GetDeck("modern-league-2020-08-28",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck28_122pablo_JeskaiAscendancy_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-08-28",27),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck29_thedoc96_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-28",28),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_NeryNeto_TemurDelver_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",29),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Delver),
                typeof(TemurDelver),
                null
            );
        }

        [Test]
        public void Deck31_MlckyB_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",30),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck32_wowqqqa_KGCTron_G()
        {
            Test(
                GetDeck("modern-league-2020-08-28",31),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck33_sydneydude_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-28",32),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck34_PuntThenWhine_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",33),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck35_Frozon_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-08-28",34),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck36_603Leb_ValakutField_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",35),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(ValakutField),
                null,
                null
            );
        }

        [Test]
        public void Deck37_Kumpanen_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-08-28",36),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck38_Diotima_MonoWhiteEldraziTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-08-28",37),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck39_lewisyo_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-08-28",38),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck40_GHash77_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",39),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck41_Antoine57437_AbzanCompany_WBG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",40),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(AbzanCompany),
                null,
                null
            );
        }

        [Test]
        public void Deck42_GrilledCheese_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",41),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck43_abijhavs_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-08-28",42),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck44_Parrit_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-08-28",43),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck45_mechrataal_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",44),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck46_Alcander_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-28",45),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck47_kogamo_ValakutField_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",46),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(ValakutField),
                null,
                null
            );
        }

        [Test]
        public void Deck48_MrSeri_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",47),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck49_ferrum0728_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-league-2020-08-28",48),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck50_yPrincipe_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-08-28",49),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck51_Ingalsarm_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-28",50),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
