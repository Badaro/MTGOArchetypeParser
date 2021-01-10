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
#01 HouseOfManaMTG: Amulet Titan (G)
#02 Do0mSwitch: WURG Control (WURG)
#03 masongrode: Heliod Combo (WRG)
#04 Sodeq: Dredge (BRG)
#05 PuntThenWhine: Amulet Titan (G)
#06 Shadowz2005: WURG Control (WURG)
#07 TSPJendrek: Bant Control (WUG)
#08 gazmon48: Izzet Prowess (UR)
#09 Mussie99: Sultai Control (UBG)
#10 joaoclaudioms: Hammer Time (WB, Lurrus)
#11 obeylord: Oops All Spells (WUBG)
#12 JUJUBEAN__2004: Izzet Prowess (UR)
#13 The_nayr: Shadow Prowess (BR, Lurrus)
#14 ChildOfAlara7: Sultai Control (UBG)
#15 ice_nine_: Land Destruction (WR)
#16 starfall: Obosh Aggro (R, Obosh)
#17 patheus_84: Ad Nauseam (WUB)
#18 ichi-roku: Ad Nauseam (WUB)
#19 nazart: Heliod Combo (WG)
#20 mariogomes097: Esper Shadow (WUB)
#21 CrusherBotBG: Hammer Time (W, Lurrus)
#22 FerMTG: Burn (WR)
#23 Oderus Urungus: Sultai Control (UBG)
#24 naddyeffintabs: Hammer Time (WB, Lurrus)
#25 Rosencrantz_920: Amulet Titan (G)
#26 nekomap: Rakdos Prowess (BR, Lurrus)
#27 Binolino: Reclaimer Titan (WBRG)
#28 Bullwinkkle6705: Temur Control (URG)
#29 Mcleskey: Burn (WR)
#30 Skrown: Shadow Prowess (BR, Lurrus)
#31 gottelicious: Kinnan Legends (WUG)
#32 fabee1: Mono White Taxes (W, Yorion)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2021_01_10 : EventTest
    {
        [Test]
        public void Deck01_HouseOfManaMTG_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",0),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck02_Do0mSwitch_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_masongrode_HeliodCombo_WRG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",2),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",3),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck05_PuntThenWhine_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",4),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck06_Shadowz2005_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",5),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_TSPJendrek_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",6),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_gazmon48_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",7),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Mussie99_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",8),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_joaoclaudioms_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",9),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_obeylord_OopsAllSpells_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",10),
                new PostZendikarRising(),
                ArchetypeColor.WUBG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck12_JUJUBEAN2004_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",11),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Thenayr_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",12),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_ChildOfAlara7_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",13),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_icenine_LandDestruction_WR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",14),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(LandDestruction),
                null,
                null
            );
        }

        [Test]
        public void Deck16_starfall_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",15),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck17_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",16),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck18_ichiroku_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",17),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck19_nazart_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",18),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck20_mariogomes097_EsperShadow_WUB()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",19),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck21_CrusherBotBG_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",20),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_FerMTG_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",21),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck23_OderusUrungus_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",22),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_naddyeffintabs_HammerTime_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",23),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_Rosencrantz920_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",24),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck26_nekomap_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",25),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_Binolino_ReclaimerTitan_WBRG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",26),
                new PostZendikarRising(),
                ArchetypeColor.WBRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck28_Bullwinkkle6705_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",27),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Mcleskey_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",28),
                new PostZendikarRising(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Skrown_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",29),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_gottelicious_KinnanLegends_WUG()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",30),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(KinnanLegends),
                null,
                null
            );
        }

        [Test]
        public void Deck32_fabee1_MonoWhiteTaxes_W_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2021-01-10",31),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                ArchetypeCompanion.Yorion
            );
        }


    }
}
