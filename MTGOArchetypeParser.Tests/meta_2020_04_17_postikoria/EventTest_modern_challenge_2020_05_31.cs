using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 leclairandy: Bant Control (WUG, Yorion)
#02 Sonic_Smasher: Gruul Midrange (RG, Obosh)
#03 AndyAWKWARD: Scapeshift (WURG, Yorion)
#04 July0: Bogles (WG, Lurrus)
#05 Lordzedane: Gruul Midrange (RG, Obosh)
#06 fingers1991: Rakdos Prowess (BR, Lurrus)
#07 Misplacedginger: Jund Prowess (BRG, Lurrus)
#08 3minem: Rakdos Prowess (BR, Lurrus)
#09 Thrall90: Jund Midrange (BRG, Lurrus)
#10 exoticherman: Jund Shadow (BRG, Lurrus)
#11 Hoey07: Scapeshift (WURG, Yorion)
#12 PRGJJAR: Dredge (BRG)
#13 shadow_PT: Rakdos Prowess (BR, Lurrus)
#14 MikeEgan: Jund Midrange (BRG, Lurrus)
#15 Traft: Ad Nauseam (WUB)
#16 MadMaxErnst: Rakdos Prowess (BR, Lurrus)
#17 Sharkcaster_Mage: Devoted (WG, Lurrus)
#18 Game_Night: Green Tron (G, Jegantha)
#19 BanjoCaveman: Mardu Prowess (WBR, Lurrus)
#20 ManuGodineau: Gruul Midrange (RG, Obosh)
#21 Magicofplayer1: Jeskai Control (WUR, Yorion)
#22 SunofNothing: Jund Shadow (BRG, Lurrus)
#23 yamakiller: Green Tron (G, Jegantha)
#24 Solodin: Scapeshift (URG, Yorion)
#25 2jjm: Burn (WR, Lurrus)
#26 sendoh007: Gruul Midrange (RG, Obosh)
#27 Capitano_CL: Boros Prowess (WR, Lurrus)
#28 remf: Gruul Midrange (RG, Obosh)
#29 indianpancake: Rakdos Prowess (BR, Lurrus)
#30 SourEggnog: Jund Midrange (BRG, Lurrus)
#31 RENDGT: WURG Control (WURG, Yorion)
#32 bobthedog: Bant Blink (WUG, Yorion)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_challenge_2020_05_31 : EventTest
    {
        [Test]
        public void Deck01_leclairandy_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",0),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_SonicSmasher_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",1),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck03_AndyAWKWARD_Scapeshift_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",2),
                "PostIkoria",
                ArchetypeColor.WURG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_July0_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",3),
                "PostIkoria",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Lordzedane_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",4),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck06_fingers1991_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",5),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Misplacedginger_JundProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",6),
                "PostIkoria",
                ArchetypeColor.BRG,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_3minem_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",7),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_Thrall90_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",8),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_exoticherman_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",9),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_Hoey07_Scapeshift_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",10),
                "PostIkoria",
                ArchetypeColor.WURG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",11),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck13_shadowPT_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",12),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_MikeEgan_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",13),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_Traft_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",14),
                "PostIkoria",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck16_MadMaxErnst_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",15),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_SharkcasterMage_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",16),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_GameNight_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",17),
                "PostIkoria",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck19_BanjoCaveman_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",18),
                "PostIkoria",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_ManuGodineau_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",19),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck21_Magicofplayer1_JeskaiControl_WUR_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",20),
                "PostIkoria",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck22_SunofNothing_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",21),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_yamakiller_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",22),
                "PostIkoria",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck24_Solodin_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",23),
                "PostIkoria",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck25_2jjm_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",24),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_sendoh007_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",25),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck27_CapitanoCL_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",26),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_remf_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",27),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck29_indianpancake_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",28),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_SourEggnog_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",29),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_RENDGT_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",30),
                "PostIkoria",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck32_bobthedog_BantBlink_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-31",31),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericBlink",
                null,
                ArchetypeCompanion.Yorion
            );
        }


    }
}
