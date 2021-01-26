using FluentAssertions;
using MTGOArchetypeParser.Model;
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
#07 nahuel10: Reclamation (WUG)
#08 pokerswizard: Jund Midrange (BRG)
#09 kanister: Reclamation (URG)
#10 skuttlespike: Gruul Midrange (RG)
#11 no_lyfe: Mono Red Prowess (R)
#12 Shorak123: Reclamation (UBG)
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
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_cws_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",1),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck03_goblinlackey_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",2),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck04_Edel_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",3),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Traft_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",4),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Danker_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",5),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_nahuel10_Reclamation_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",6),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck08_pokerswizard_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",7),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_kanister_Reclamation_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",8),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck10_skuttlespike_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",9),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck11_nolyfe_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",10),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck12_Shorak123_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",11),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Chefen_Goblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",12),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck14_echecetmat35_TitanShift_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",13),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck15_bntrusty14_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",14),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",15),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck17_Redgy819_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",16),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck18_Misplacedginger_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",17),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck19_Skrown_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",18),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck20_Jokersrwild_Goblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",19),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck21_soultaker06_Goblins_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",20),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck22_MZBlazer_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",21),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck23_MrRaeb_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",22),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck24_kthanakit26_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",23),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck25_crazybaloth_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",24),
                "PostAstrolabeBan",
                ArchetypeColor.W,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck26_MasterA_Goblins_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",25),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck27_Vonducky_BorosProwess_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",26),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck28_azatoyellow_MonoRedProwess_R_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",27),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck29_bobjackson_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",28),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck30_EricSlashGreg_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",29),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck31_Mikebrav_Humans_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",30),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck32_Zar0s_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-07-19",31),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}
