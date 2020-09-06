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
#01 The_nayr: MonoRedProwess (R, Obosh)
#02 TSPJendrek: SultaiControl (UBG)
#03 D00mwake: AmuletTitan (URG)
#04 AceTrainerBlue: Yawgmoth (BG)
#05 fingers1991: BorosProwess (WR, Lurrus)
#06 maxxattack: AdNauseam (WUB)
#07 Hyeri0418: Crabvine (UBG)
#08 AstralPlane: MonoRedProwess (R, Jegantha)
#09 fling5133: KGCTron (G)
#10 MaxMagicer: Scapeshift (URG, Yorion)
#11 cws: GiftsStorm (UR)
#12 PTarts2win: KGCTron (G)
#13 HotBread: IzzetProwess (UR)
#14 frozenian: IzzetProwess (UR)
#15 klien7: Burn (WR)
#16 TwistedWombat: RakdosProwess (BR, Lurrus)
#17 calheiros: KGCAmuletTitan (UBRG)
#18 zecriah: KGCTron (G)
#19 1yo2yo: BantControl (WUG)
#20 scipios: Crabvine (UBG)
#21 tylerjjobrien: BringToNiv (WUBRG, Yorion)
#22 DamonXWind: IzzetProwess (UR)
#23 Gigy: NayaMidrange (WRG)
#24 NobodyKnowsImADog: KGCTron (G)
#25 azax: GrixisShadow (UBR)
#26 _Stream: IzzetProwess (UR)
#27 KIMCHIMAN: SnoopGoblins (BR)
#28 WareHouseGames: KGCTron (G)
#29 aspiringspike: SultaiControl (UBG)
#30 Toastxp: PrimevalTitan (WRG)
#31 mot88: ThaliaStompy (WR)
#32 SebastianStueckl: Bogles (WG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_challenge_2020_09_06 : EventTest
    {
        [Test]
        public void Deck01_Thenayr_MonoRedProwess_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",0),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck02_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_D00mwake_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",2),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck04_AceTrainerBlue_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",3),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Yawgmoth),
                null,
                null
            );
        }

        [Test]
        public void Deck05_fingers1991_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_maxxattack_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Hyeri0418_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",6),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck08_AstralPlane_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",7),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck09_fling5133_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",8),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck10_MaxMagicer_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",9),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_cws_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",10),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck12_PTarts2win_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",11),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck13_HotBread_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck14_frozenian_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",13),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck15_klien7_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck16_TwistedWombat_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",15),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_calheiros_KGCAmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",16),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck18_zecriah_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",17),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck19_1yo2yo_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",18),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_scipios_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",19),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck21_tylerjjobrien_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",20),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck22_DamonXWind_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",21),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Gigy_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",22),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck24_NobodyKnowsImADog_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",23),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck25_azax_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",24),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Stream_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",25),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck27_KIMCHIMAN_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",26),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck28_WareHouseGames_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",27),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck29_aspiringspike_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",28),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Toastxp_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",29),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck31_mot88_ThaliaStompy_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",30),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(ThaliaStompy),
                null,
                null
            );
        }

        [Test]
        public void Deck32_SebastianStueckl_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-06",31),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
