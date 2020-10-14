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
#01 Metcalf23: MonoWhiteTaxes (W)
#02 Jaberwocki: JundMidrange (BRG)
#03 WorstNewbEver: ShadowProwess (BR, Lurrus)
#04 fried-liver-attack: Burn (WR)
#05 jacobricher: Humans (WUBRG)
#06 TSPJendrek: SultaiControl (UBG)
#07 Curtisaxel: UTron (U)
#08 Munich_Casual: BantSpirits (WUG)
#09 Jositoshekel: HeliodCombo (WG)
#10 NHA37: HeliodCombo (W)
#11 yamakiller: PrimevalTitan (WRG)
#12 SknerusMcKwacz: OopsAllSpells (WUBG)
#13 Parrit: MonoWhiteTaxes (W)
#14 Edel: RakdosMidrange (BR)
#15 Mlgb92: OrzhovMidrange (WB)
#16 ice_nine_: BorosPrison (WR)
#17 Rav104: IzzetProwess (UR)
#18 fingers1991: ShadowProwess (BR, Lurrus)
#19 MiguelCaster: MonoWhiteEldraziTaxes (W)
#20 shir kahn: JeskaiControl (WUR)
#21 ChironTheMage: WURGControl (WURG)
#22 GideonRavensword: Dredge (BRG)
#23 bigjc00: AmuletTitan (UBRG)
#24 fabee1: BantMidrange (WUG)
#25 Doomenstein: MonoWhiteTaxes (W)
#26 Gobern: BringToNiv (WUBRG, Yorion)
#27 Andreas_Mueller: Dredge (BRG)
#28 Elnitzo: Mill (UB, Lurrus)
#29 MHayashi: MonoRedProwess (R, Obosh)
#30 staffmat1992: BantSpirits (WUG)
#31 Johnny_Hobbs: WURGControl (WURG)
#32 thephatz: MonoWhiteEldraziTaxes (W)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_10_11 : EventTest
    {
        [Test]
        public void Deck01_Metcalf23_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",0),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Jaberwocki_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",1),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_WorstNewbEver_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",2),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_friedliverattack_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",3),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck05_jacobricher_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",4),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck06_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",5),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Curtisaxel_UTron_U()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",6),
                new PostZendikarRising(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck08_MunichCasual_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",7),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck09_Jositoshekel_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",8),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck10_NHA37_HeliodCombo_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",9),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck11_yamakiller_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",10),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck12_SknerusMcKwacz_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",11),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Parrit_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",12),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Edel_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",13),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Mlgb92_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",14),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_icenine_BorosPrison_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",15),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(BorosPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Rav104_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",16),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck18_fingers1991_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",17),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_MiguelCaster_MonoWhiteEldraziTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",18),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck20_shirkahn_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",19),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_ChironTheMage_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",20),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_GideonRavensword_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",21),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck23_bigjc00_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",22),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck24_fabee1_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",23),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Doomenstein_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",24),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Gobern_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",25),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck27_AndreasMueller_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",26),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Elnitzo_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",27),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_MHayashi_MonoRedProwess_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",28),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck30_staffmat1992_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",29),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck31_JohnnyHobbs_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",30),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck32_thephatz_MonoWhiteEldraziTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-11",31),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }


    }
}