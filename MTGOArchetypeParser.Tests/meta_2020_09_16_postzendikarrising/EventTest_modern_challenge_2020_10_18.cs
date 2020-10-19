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
#01 NHA37: HeliodCombo (W)
#02 FreakNightmare: OopsAllSpells (WUBRG)
#03 The_nayr: MonoRedProwess (R, Jegantha)
#04 TwistedWombat: SaheeliCombo (WURG, Jegantha)
#05 Sodeq: Dredge (BRG)
#06 MoxSquirrel: Mill (UB, Lurrus)
#07 cicciogire: WURGControl (WURG)
#08 exoticherman: JundShadow (BRG)
#09 stayrospet: ShadowProwess (BR, Lurrus)
#10 seasonofmists: AbzanEldraziTaxes (WBG)
#11 HouseOfManaMTG: AmuletTitan (UBRG)
#12 DarkestMage: MonoWhiteTaxes (W)
#13 last7stand: KGCTron (G)
#14 PTarts2win: WURGControl (WURG)
#15 Gobern: SaheeliCombo (WURG, Jegantha)
#16 AstralPlane: SaheeliCombo (WURG, Jegantha)
#17 DaniMRebel: Spirits (WU)
#18 Xwhale: PrimevalTitan (WRG)
#19 MIkepick7: ETron (C)
#20 Humpaa: HeliodCombo (WG)
#21 POOBMASTER: ShadowProwess (BR, Lurrus)
#22 daibloXSC: IzzetControl (UR)
#23 NuBlkAu: RakdosShadow (BR)
#24 pbarrrgh: SultaiReclamation (UBG)
#25 eclipse4343: AzoriusControl (WU)
#26 Moniz0801: AmuletTitan (UBRG)
#27 yamakiller: MonoRedProwess (R, Obosh)
#28 Metcalf23: MonoWhiteTaxes (W)
#29 staffmat1992: Dredge (BRG)
#30 Oderus Urungus: Humans (WUBRG)
#31 fabee1: MonoWhiteTaxes (W)
#32 quinniac: MonoRedProwess (R, Obosh)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_10_18 : EventTest
    {
        [Test]
        public void Deck01_NHA37_HeliodCombo_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",0),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck02_FreakNightmare_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",1),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Thenayr_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",2),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck04_TwistedWombat_SaheeliCombo_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",3),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck05_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",4),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck06_MoxSquirrel_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",5),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_cicciogire_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",6),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_exoticherman_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",7),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck09_stayrospet_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",8),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_seasonofmists_AbzanEldraziTaxes_WBG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",9),
                new PostZendikarRising(),
                ArchetypeColor.WBG,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck11_HouseOfManaMTG_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",10),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck12_DarkestMage_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",11),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck13_last7stand_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",12),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck14_PTarts2win_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",13),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Gobern_SaheeliCombo_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",14),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck16_AstralPlane_SaheeliCombo_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",15),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(SaheeliCombo),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck17_DaniMRebel_Spirits_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",16),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Xwhale_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",17),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck19_MIkepick7_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",18),
                new PostZendikarRising(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Humpaa_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",19),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck21_POOBMASTER_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",20),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_daibloXSC_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",21),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_NuBlkAu_RakdosShadow_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",22),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck24_pbarrrgh_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",23),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck25_eclipse4343_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",24),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Moniz0801_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",25),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck27_yamakiller_MonoRedProwess_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",26),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck28_Metcalf23_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",27),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck29_staffmat1992_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",28),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck30_OderusUrungus_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",29),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck31_fabee1_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",30),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck32_quinniac_MonoRedProwess_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-10-18",31),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Obosh
            );
        }


    }
}
