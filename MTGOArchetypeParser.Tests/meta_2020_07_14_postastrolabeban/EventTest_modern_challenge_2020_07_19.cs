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
#01 Toastxp: SuicideShadow (BRG, Lurrus)
#02 cws: GiftsStorm (UR)
#03 _goblinlackey: KGCTron (G)
#04 Edel: Jund (BRG)
#05 Traft: AdNauseam (WUB)
#06 Danker: AzoriusStoneblade (WU)
#07 nahuel10: SnowReclamation (WUG)
#08 pokerswizard: Jund (BRG)
#09 kanister: TemurReclamation (URG)
#10 skuttlespike: Ponza (RG)
#11 no_lyfe: Prowess (R)
#12 Shorak123: SnowReclamation (UBG)
#13 Chefen: SnoopGoblins (BR)
#14 echecetmat35: TitanShift (URG)
#15 bntrusty14: Devoted (WG, Lurrus)
#16 Gigy: Ponza (RG)
#17 Redgy819: ETron (C)
#18 Misplacedginger: Jund (BRG)
#19 Skrown: ETron (C)
#20 Jokersrwild: SnoopGoblins (BR)
#21 soultaker06: SnoopGoblins (BR)
#22 MZBlazer: IzzetProwess (UR)
#23 MrRaeb: SultaiSnow (UBG)
#24 kthanakit26: Burn (WR)
#25 crazybaloth: EldraziTaxes (W)
#26 MasterA: SnoopGoblins (BRG)
#27 Vonducky: Prowess (WR)
#28 azatoyellow: RedDeckWins (R, Jegantha)
#29 bobjackson: KGCTron (G)
#30 EricSlashGreg: AdNauseam (WUB)
#31 Mikebrav: Humans (WUBRG, Yorion)
#32 Zar0s: Ponza (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_challenge_2020_07_19 : EventTest
    {
        [Test]
        public void Deck01_Toastxp_DeathsShadow_SuicideShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",0),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_cws_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck03_goblinlackey_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",2),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck04_Edel_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",3),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Traft_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Danker_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_nahuel10_SnowControl_SnowReclamation_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck08_pokerswizard_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",7),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_kanister_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",8),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck10_skuttlespike_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",9),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck11_nolyfe_Prowess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",10),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Shorak123_SnowControl_SnowReclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",11),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Chefen_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",12),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck14_echecetmat35_PrimevalTitan_TitanShift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",13),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck15_bntrusty14_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_Gigy_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",15),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Redgy819_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",16),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Misplacedginger_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",17),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Skrown_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",18),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Jokersrwild_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",19),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck21_soultaker06_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",20),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck22_MZBlazer_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",21),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck23_MrRaeb_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",22),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck24_kthanakit26_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",23),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck25_crazybaloth_DeathAndTaxes_EldraziTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",24),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck26_MasterA_Goblins_SnoopGoblins_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",25),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck27_Vonducky_Prowess_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck28_azatoyellow_RedDeckWins_R_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",27),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedDeckWins),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck29_bobjackson_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",28),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck30_EricSlashGreg_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",29),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Mikebrav_Humans_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",30),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck32_Zar0s_Ponza_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",31),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
