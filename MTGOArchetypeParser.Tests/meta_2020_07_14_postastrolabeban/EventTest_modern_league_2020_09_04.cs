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
#01 raven0904: GTron (G)
#02 __BMJ__: JundShadow (BRG)
#03 cccaspar: WhiteDevotion (W)
#04 Ritzulz: AdNauseam (WUB)
#05 Wooday: Infect (UG)
#06 Fulgence: NayaMidrange (WRG)
#07 Dlihchtarw: RakdosMidrange (BR)
#08 liftwhenready: Dredge (BRG)
#09 Kuhb: HeliodCombo (WG)
#10 saidin.raken: Scapeshift (URG)
#11 WingedHussar: Neobrand (UG)
#12 Ganksyou: AzoriusControl (WU)
#13 number1pwnr: ThaliaStompy (WR)
#14 forenmagra: SaheeliToLight (WUBRG)
#15 wynn1006: IzzetProwess (UR)
#16 Coutinho13: TitanShift (RG)
#17 Parrit: MonoWhiteTaxes (W)
#18 Ryan_39: SimicReclamation (UG)
#19 tousey: Slivers (WUBRG)
#20 TheAznYoshi: GruulMidrange (RG)
#21 Teston: GiftsStorm (UR)
#22 AlphaBlade: ETron (C)
#23 Sebstrika: Mill (UB)
#24 Dwarshadow: RakdosProwess (BR, Lurrus)
#25 Toastxp: AzoriusControl (WU)
#26 hermanomlg: GolgariMidrange (BG)
#27 DarkKeeper: BantControl (WUG)
#28 Planet-Blade: GrixisShadow (UBR)
#29 ColoradoRalphy: Humans (WUBRG)
#30 TheBigMoke: SultaiReclamation (UBG)
#31 TheOneCoff: ValakutField (URG)
#32 nietzreznor: MonoRedProwess (R, Obosh)
#33 Bangood: ThopterUrza (UBR)
#34 pumpkinwavy: PrimevalTitan (WRG)
#35 603Leb: GolgariElves (BG)
#36 MTGBullent: HeliodCombo (WG)
#37 rojanosa: BushwhackerZoo (WRG)
#38 Frejat: TitanVial (WRG)
#39 Daryl_Ayers: AmuletTitan (UBRG)
#40 chancery: Polymorph (RG)
#41 sicsmoo: ValakutField (BRG)
#42 Chub_Toad_: Uroza (WUG)
#43 apple_Neosky: Merfolk (WU, Lurrus)
#44 DaniMRebel: Bogles (WG)
#45 ProfGOak: ThingAscension (UR)
#46 Iceman76: SnoopGoblins (BR)
#47 Xurikk: AzoriusTaxes (WU)
#48 Ceinos: SnoopGoblins (BRG)
#49 aqualog: BorosProwess (WR, Lurrus)
#50 kingoftheelves: AbzanMidrange (WBG)
#51 gazurmah: JundMidrange (BRG)
#52 Conor_man11: EightRack (B)
#53 Danielstallone: Burn (WR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_league_2020_09_04 : EventTest
    {
        [Test]
        public void Deck01_raven0904_GTron_G()
        {
            Test(
                GetDeck("modern-league-2020-09-04",0),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck02_BMJ_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",1),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck03_cccaspar_WhiteDevotion_W()
        {
            Test(
                GetDeck("modern-league-2020-09-04",2),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(WhiteDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Ritzulz_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-09-04",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Wooday_Infect_UG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",4),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Fulgence_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Dlihchtarw_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-league-2020-09-04",6),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_liftwhenready_Dredge_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",7),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Kuhb_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck10_saidinraken_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",9),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck11_WingedHussar_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",10),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Ganksyou_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-04",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_number1pwnr_ThaliaStompy_WR()
        {
            Test(
                GetDeck("modern-league-2020-09-04",12),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(ThaliaStompy),
                null,
                null
            );
        }

        [Test]
        public void Deck14_forenmagra_SaheeliToLight_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",13),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(SaheeliCombo),
                typeof(SaheeliToLight),
                null
            );
        }

        [Test]
        public void Deck15_wynn1006_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-04",14),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Coutinho13_TitanShift_RG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",15),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck17_Parrit_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-league-2020-09-04",16),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Ryan39_SimicReclamation_UG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",17),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck19_tousey_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",18),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck20_TheAznYoshi_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",19),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Teston_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-04",20),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck22_AlphaBlade_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-09-04",21),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Sebstrika_Mill_UB()
        {
            Test(
                GetDeck("modern-league-2020-09-04",22),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Dwarshadow_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-04",23),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_Toastxp_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-04",24),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck26_hermanomlg_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",25),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck27_DarkKeeper_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck28_PlanetBlade_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-09-04",27),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck29_ColoradoRalphy_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",28),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck30_TheBigMoke_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",29),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck31_TheOneCoff_ValakutField_URG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",30),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(ValakutField),
                null,
                null
            );
        }

        [Test]
        public void Deck32_nietzreznor_MonoRedProwess_R_Obosh()
        {
            Test(
                GetDeck("modern-league-2020-09-04",31),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck33_Bangood_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-league-2020-09-04",32),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck34_pumpkinwavy_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",33),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck35_603Leb_GolgariElves_BG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",34),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Elves),
                typeof(GolgariElves),
                null
            );
        }

        [Test]
        public void Deck36_MTGBullent_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",35),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck37_rojanosa_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",36),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck38_Frejat_TitanVial_WRG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",37),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(TitanVial),
                null,
                null
            );
        }

        [Test]
        public void Deck39_DarylAyers_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",38),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck40_chancery_Polymorph_RG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",39),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Polymorph),
                null,
                null
            );
        }

        [Test]
        public void Deck41_sicsmoo_ValakutField_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",40),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(ValakutField),
                null,
                null
            );
        }

        [Test]
        public void Deck42_ChubToad_Uroza_WUG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",41),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck43_appleNeosky_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-04",42),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck44_DaniMRebel_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",43),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck45_ProfGOak_ThingAscension_UR()
        {
            Test(
                GetDeck("modern-league-2020-09-04",44),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(ThingAscension),
                null,
                null
            );
        }

        [Test]
        public void Deck46_Iceman76_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-league-2020-09-04",45),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck47_Xurikk_AzoriusTaxes_WU()
        {
            Test(
                GetDeck("modern-league-2020-09-04",46),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck48_Ceinos_SnoopGoblins_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",47),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck49_aqualog_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-04",48),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck50_kingoftheelves_AbzanMidrange_WBG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",49),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck51_gazurmah_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-09-04",50),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck52_Conorman11_EightRack_B()
        {
            Test(
                GetDeck("modern-league-2020-09-04",51),
                new PostAstrolabeBan(),
                ArchetypeColor.B,
                typeof(EightRack),
                null,
                null
            );
        }

        [Test]
        public void Deck53_Danielstallone_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-09-04",52),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
