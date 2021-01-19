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
#01 Toastxp: Jund Shadow (BRG, Lurrus)
#02 cws: Gifts Storm (UR)
#03 _goblinlackey: Green Tron (G)
#04 Edel: Jund Midrange (BRG)
#05 Traft: Ad Nauseam (WUB)
#06 Danker: Azorius Control (WU)
#07 nahuel10: Bant Control (WUG)
#08 pokerswizard: Jund Midrange (BRG)
#09 kanister: Temur Control (URG)
#10 skuttlespike: Gruul Midrange (RG)
#11 no_lyfe: Mono Red Prowess (R)
#12 Shorak123: Sultai Control (UBG)
#13 Chefen: Goblins (BR)
#14 echecetmat35: Titan Shift (UG)
#15 bntrusty14: Devoted (WG, Lurrus)
#16 Gigy: Gruul Midrange (RG)
#17 Redgy819: Eldrazi Tron (C)
#18 Misplacedginger: Jund Midrange (BRG)
#19 Skrown: Eldrazi Tron (C)
#20 Jokersrwild: Goblins (BR)
#21 soultaker06: Goblins (BR)
#22 MZBlazer: Izzet Prowess (UR)
#23 MrRaeb: Sultai Control (UBG)
#24 kthanakit26: Burn (WR)
#25 crazybaloth: Mono White Taxes (W)
#26 MasterA: Goblins (BRG)
#27 Vonducky: Boros Prowess (WR)
#28 azatoyellow: Mono Red Prowess (R, Jegantha)
#29 bobjackson: Green Tron (G)
#30 EricSlashGreg: Ad Nauseam (WUB)
#31 Mikebrav: Humans (WUBRG, Yorion)
#32 Zar0s: Gruul Midrange (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_challenge_2020_07_19 : EventTest
    {
        [Test]
        public void Deck01_Toastxp_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",0),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Shadow),
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
        public void Deck03_goblinlackey_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",2),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck04_Edel_JundMidrange_BRG()
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
        public void Deck06_Danker_AzoriusControl_WU()
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
        public void Deck07_nahuel10_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_pokerswizard_JundMidrange_BRG()
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
        public void Deck09_kanister_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",8),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_skuttlespike_GruulMidrange_RG()
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
        public void Deck11_nolyfe_MonoRedProwess_R()
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
        public void Deck12_Shorak123_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",11),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Chefen_Goblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",12),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck14_echecetmat35_TitanShift_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",13),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
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
        public void Deck16_Gigy_GruulMidrange_RG()
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
        public void Deck17_Redgy819_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",16),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck18_Misplacedginger_JundMidrange_BRG()
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
        public void Deck19_Skrown_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",18),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck20_Jokersrwild_Goblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",19),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck21_soultaker06_Goblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",20),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck22_MZBlazer_IzzetProwess_UR()
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
        public void Deck23_MrRaeb_SultaiControl_UBG()
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
        public void Deck25_crazybaloth_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",24),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck26_MasterA_Goblins_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",25),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Vonducky_BorosProwess_WR()
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
        public void Deck28_azatoyellow_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",27),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck29_bobjackson_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",28),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
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
        public void Deck32_Zar0s_GruulMidrange_RG()
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
