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
#01 Lucabireskusku: WURG Control (WURG)
#02 Tarrasque1: Mono White Taxes (W)
#03 sleightofhand94: Amulet Titan (G)
#04 NuBlkAu: Temur Control (URG)
#05 Sodeq: Dredge (BRG)
#06 mariogomes097: Devoted (WG, Lurrus)
#07 Curtisaxel: Blue Tron (UR)
#08 eclipse4343: Azorius Control (WU)
#09 Chris_Concarnage: Obosh Aggro (R, Obosh)
#10 Condescend: WURG Control (WURG)
#11 azax: Reclaimer Titan (WRG)
#12 ATGerwaz: Mill (UB, Lurrus)
#13 Xwhale: Reclaimer Titan (WRG)
#14 Lord_of_Puntlantis: Electro Balance (UR)
#15 KlashBack: Izzet Control (UR)
#16 DaniMRebel: Shadow Prowess (BR, Lurrus)
#17 pbarrrgh: Sultai Control (UBG)
#18 Tweedel: Obosh Aggro (R, Obosh)
#19 Vivitrix: Dredge (BRG)
#20 SoulStrong: Rogues (UB, Lurrus)
#21 Simarisu: Izzet Prowess (UR)
#22 N3to: Gifts Storm (UR)
#23 apriolo1: Heliod Combo (WG)
#24 joker10289: Jeskai Control (WUR)
#25 NorrathDecay: Green Tron (G)
#26 kanister: Bant Blink (WUG)
#27 CrusherBotBG: Hammer Time (W, Lurrus)
#28 __BMJ__: Shadow Prowess (BR, Lurrus)
#29 kevilynn: Spirits (WUG)
#30 Ryan100495: Dredge (BRG)
#31 oskiyaa: Shadow Prowess (BR, Lurrus)
#32 t_k_h_r: Ad Nauseam (WUB)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_12_13 : EventTest
    {
        [Test]
        public void Deck01_Lucabireskusku_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",0),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Tarrasque1_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",1),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck03_sleightofhand94_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",2),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck04_NuBlkAu_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",3),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",4),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck06_mariogomes097_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",5),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Curtisaxel_BlueTron_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",6),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(Tron),
                typeof(BlueTron),
                null
            );
        }

        [Test]
        public void Deck08_eclipse4343_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",7),
                new PostZendikarRising(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_ChrisConcarnage_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",8),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck10_Condescend_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",9),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_azax_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",10),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck12_ATGerwaz_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",11),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_Xwhale_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",12),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck14_LordofPuntlantis_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",13),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck15_KlashBack_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",14),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_DaniMRebel_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",15),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_pbarrrgh_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",16),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Tweedel_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",17),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck19_Vivitrix_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",18),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck20_SoulStrong_Rogues_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",19),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Rogues),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_Simarisu_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",20),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck22_N3to_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",21),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck23_apriolo1_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",22),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck24_joker10289_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",23),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck25_NorrathDecay_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",24),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck26_kanister_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",25),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck27_CrusherBotBG_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",26),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_BMJ_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",27),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_kevilynn_Spirits_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",28),
                new PostZendikarRising(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Ryan100495_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",29),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck31_oskiyaa_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",30),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_tkhr_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-12-13",31),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }


    }
}
