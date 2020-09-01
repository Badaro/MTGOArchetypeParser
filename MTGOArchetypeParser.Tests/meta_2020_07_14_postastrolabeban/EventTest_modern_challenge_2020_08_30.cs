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
#01 hcook725: Uroza (WUG)
#02 DreamsOfAshiok: RakdosProwess (BR, Lurrus)
#03 bigjc00: AmuletTitan (URG)
#04 _goblinlackey: MarduProwess (WBR, Lurrus)
#05 yamakiller: MonoRedProwess (R, Obosh)
#06 SpiderSpace: Humans (WUBRG)
#07 qbturtle15: GruulMidrange (RG)
#08 Jack_Kashtan: AdNauseam (WUB)
#09 FreedMania: KGCAmuletTitan (UBRG)
#10 BigPanda_559: Burn (WR)
#11 SpicyLeche: JundShadow (BRG, Lurrus)
#12 exoticherman: MarduProwess (WBR, Lurrus)
#13 trader08111: IzzetProwess (UR)
#14 Fluorspar: Humans (WUBRG)
#15 crazybaloth: Humans (WUBRG)
#16 Trellon: UTron (U)
#17 blastoids: BantControl (WUG)
#18 PvtEnormous: BantControl (WUG)
#19 Day_man: TemurReclamation (URG)
#20 Midguy: KGCTron (G)
#21 Lord_of_Puntlantis: IzzetRestoreBalance (URG)
#22 FloorFlower: GruulMidrange (RG)
#23 raven0904: GTron (G)
#24 Corrado: RakdosProwess (BR, Lurrus)
#25 FestiFan: TemurReclamation (URG)
#26 scipios: Crabvine (UBG)
#27 cws: GiftsStorm (UR)
#28 hoveydw: JundShadow (BRG)
#29 benchsummer: UBRGShadow (UBRG)
#30 HouseOfManaMTG: Dredge (WBRG)
#31 patheus_84: AdNauseam (WUB)
#32 ReturnToDust: TitanVial (WRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_challenge_2020_08_30 : EventTest
    {
        [Test]
        public void Deck01_hcook725_Uroza_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck02_DreamsOfAshiok_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",1),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_bigjc00_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",2),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck04_goblinlackey_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_yamakiller_MonoRedProwess_R_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",4),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck06_SpiderSpace_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck07_qbturtle15_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",6),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_JackKashtan_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck09_FreedMania_KGCAmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",8),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck10_BigPanda559_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck11_SpicyLeche_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",10),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_exoticherman_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",11),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_trader08111_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Fluorspar_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",13),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck15_crazybaloth_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Trellon_UTron_U()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",15),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck17_blastoids_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_PvtEnormous_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Dayman_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",18),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Midguy_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",19),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck21_LordofPuntlantis_IzzetRestoreBalance_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",20),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(IzzetFreeSpells),
                typeof(IzzetRestoreBalance),
                null
            );
        }

        [Test]
        public void Deck22_FloorFlower_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",21),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck23_raven0904_GTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",22),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Corrado_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",23),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_FestiFan_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",24),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck26_scipios_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",25),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck27_cws_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",26),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck28_hoveydw_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",27),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck29_benchsummer_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",28),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck30_HouseOfManaMTG_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",29),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck31_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",30),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck32_ReturnToDust_TitanVial_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-08-30",31),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(TitanVial),
                null,
                null
            );
        }


    }
}