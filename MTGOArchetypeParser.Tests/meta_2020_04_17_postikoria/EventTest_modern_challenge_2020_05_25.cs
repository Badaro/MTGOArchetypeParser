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
#01 triosk: Rakdos Prowess (BR, Lurrus)
#02 TheTunnelingCat: Eldrazi Tron (C)
#03 Patxi: Rakdos Prowess (BR, Lurrus)
#04 Toastxp: Rakdos Prowess (BR, Lurrus)
#05 _LSN_: Burn (WR, Lurrus)
#06 Venom1: Rakdos Prowess (BR, Lurrus)
#07 Laplasjan: Devoted (WG, Lurrus)
#08 robb93: Jund Midrange (BRG, Lurrus)
#09 Bullz0Eye: Eldrazi Tron (C)
#10 PRGJJAR: Dredge (BRG)
#11 Butakov: Jund Midrange (BRG, Lurrus)
#12 JOXEMI333: Green Tron (G, Jegantha)
#13 quinniac: Bogles (WG, Lurrus)
#14 OxyWithMoxy: Scapeshift (URG, Yorion)
#15 MadMaxErnst: Rakdos Prowess (BR, Lurrus)
#16 sondrak: Mill (UB, Lurrus)
#17 AutumnLily: Reclamation (UBG, Yorion)
#18 AndyAWKWARD: Scapeshift (WURG, Yorion)
#19 mtgandbagels: Amulet Titan (UG)
#20 _Stream: Boros Prowess (WR, Lurrus)
#21 zecarlonxo: Boros Prowess (WR, Lurrus)
#22 SlashMash: Humans (WUBRG, Jegantha)
#23 WhiTe TsaR: Bant Control (WUG, Yorion)
#24 MrRaeb: Uroza (UBG, Yorion)
#25 2jjm: Burn (WR, Lurrus)
#26 PlebSwagger: Rakdos Prowess (BR, Lurrus)
#27 TheSouthDakota: Jund Midrange (BRG, Lurrus)
#28 ilsecco14: Bogles (WG, Lurrus)
#29 FloorFlower: Grixis Shadow (UBR, Lurrus)
#30 Searzist: Mardu Prowess (WBR, Lurrus)
#31 PietroSas: Devoted (WG, Lurrus)
#32 NorrathDecay: Green Tron (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_challenge_2020_05_25 : EventTest
    {
        [Test]
        public void Deck01_triosk_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",0),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_TheTunnelingCat_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",1),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck03_Patxi_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",2),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Toastxp_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",3),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_LSN_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",4),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_Venom1_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",5),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",6),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_robb93_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",7),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_Bullz0Eye_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",8),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck10_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",9),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Butakov_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",10),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_JOXEMI333_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",11),
                "PostIkoria",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck13_quinniac_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",12),
                "PostIkoria",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_OxyWithMoxy_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",13),
                "PostIkoria",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck15_MadMaxErnst_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",14),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_sondrak_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",15),
                "PostIkoria",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_AutumnLily_Reclamation_UBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",16),
                "PostIkoria",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_AndyAWKWARD_Scapeshift_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",17),
                "PostIkoria",
                ArchetypeColor.WURG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_mtgandbagels_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",18),
                "PostIkoria",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck20_Stream_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",19),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_zecarlonxo_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",20),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_SlashMash_Humans_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",21),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck23_WhiTeTsaR_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",22),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck24_MrRaeb_Uroza_UBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",23),
                "PostIkoria",
                ArchetypeColor.UBG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck25_2jjm_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",24),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_PlebSwagger_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",25),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_TheSouthDakota_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",26),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_ilsecco14_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",27),
                "PostIkoria",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_FloorFlower_GrixisShadow_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",28),
                "PostIkoria",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_Searzist_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",29),
                "PostIkoria",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_PietroSas_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",30),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_NorrathDecay_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-05-25",31),
                "PostIkoria",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }


    }
}
