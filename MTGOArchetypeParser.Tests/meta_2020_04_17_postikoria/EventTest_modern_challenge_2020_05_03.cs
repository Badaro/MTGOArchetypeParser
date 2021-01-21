using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 pepeteam: Amulet Titan (URG)
#02 Shorak123: Reclamation (UBG)
#03 Laplasjan: Devoted (WG, Lurrus)
#04 Edel: Abzan Midrange (WBG, Lurrus)
#05 Callad0: Primeval Titan (UG)
#06 MHayashi: Boros Prowess (WR, Lurrus)
#07 BlueLips: Bant Control (WUG, Yorion)
#08 pizzaslinger: Eldrazi Tron (C)
#09 dejoyjoe: Sultai Control (UBG, Yorion)
#10 Misplacedginger: Uroza (URG, Yorion)
#11 xakx47x: Devoted (WG, Lurrus)
#12 signblindman: Gruul Midrange (RG, Obosh)
#13 Jenara19: Burn (WR, Lurrus)
#14 rofelos: Bant Midrange (WUG, Yorion)
#15 SebastianStueckl: Gruul Midrange (RG)
#16 TSPJendrek: Dimir Control (UB, Lurrus)
#17 RCMerriam: Orzhov Midrange (WB, Lurrus)
#18 abisbocci: Jund Midrange (BRG, Lurrus)
#19 HeyNongMan: Rakdos Prowess (BR, Lurrus)
#20 Yamada: Devoted (WG, Lurrus)
#21 yneves: WURG Blink (WURG, Yorion)
#22 LORiWWA: WURG Control (WURG, Yorion)
#23 2jjm: Burn (WR, Lurrus)
#24 MaxMagicer: Burn (WR, Lurrus)
#25 mechint: Uroza (URG, Yorion)
#26 cicciogire: Uroza (URG, Yorion)
#27 johnyvolta: Kiki Chord (WURG, Yorion)
#28 Darkiundsa: WURG Control (WURG, Yorion)
#29 122pablo: Ascendancy Combo (WURG, Jegantha)
#30 shellington5385: Boros Prowess (WR, Lurrus)
#31 SunofNothing: Uroza (URG, Yorion)
#32 Wolfie98: Primeval Titan (BG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_challenge_2020_05_03 : EventTest
    {
        [Test]
        public void Deck01_pepeteam_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",0),
                "PostIkoria",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck02_Shorak123_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",1),
                "PostIkoria",
                ArchetypeColor.UBG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",2),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Edel_AbzanMidrange_WBG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",3),
                "PostIkoria",
                ArchetypeColor.WBG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Callad0_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",4),
                "PostIkoria",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck06_MHayashi_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",5),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_BlueLips_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",6),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_pizzaslinger_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",7),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck09_dejoyjoe_SultaiControl_UBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",8),
                "PostIkoria",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck10_Misplacedginger_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",9),
                "PostIkoria",
                ArchetypeColor.URG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_xakx47x_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",10),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_signblindman_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",11),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck13_Jenara19_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",12),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_rofelos_BantMidrange_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",13),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck15_SebastianStueckl_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",14),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck16_TSPJendrek_DimirControl_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",15),
                "PostIkoria",
                ArchetypeColor.UB,
                "GenericControl",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_RCMerriam_OrzhovMidrange_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",16),
                "PostIkoria",
                ArchetypeColor.WB,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_abisbocci_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",17),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_HeyNongMan_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",18),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_Yamada_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",19),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_yneves_WURGBlink_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",20),
                "PostIkoria",
                ArchetypeColor.WURG,
                "GenericBlink",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck22_LORiWWA_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",21),
                "PostIkoria",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck23_2jjm_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",22),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_MaxMagicer_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",23),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_mechint_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",24),
                "PostIkoria",
                ArchetypeColor.URG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck26_cicciogire_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",25),
                "PostIkoria",
                ArchetypeColor.URG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck27_johnyvolta_KikiChord_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",26),
                "PostIkoria",
                ArchetypeColor.WURG,
                "KikiChord",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck28_Darkiundsa_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",27),
                "PostIkoria",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck29_122pablo_AscendancyCombo_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",28),
                "PostIkoria",
                ArchetypeColor.WURG,
                "AscendancyCombo",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck30_shellington5385_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",29),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_SunofNothing_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",30),
                "PostIkoria",
                ArchetypeColor.URG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck32_Wolfie98_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",31),
                "PostIkoria",
                ArchetypeColor.BG,
                "PrimevalTitan",
                null,
                null
            );
        }


    }
}
