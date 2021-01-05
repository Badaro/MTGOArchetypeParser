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
#01 pepeteam: Amulet Titan (UG)
#02 Shorak123: Sultai Control (UBG)
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
#21 yneves: Bant Blink (WUG, Yorion)
#22 LORiWWA: Bant Control (WUG, Yorion)
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
        public void Deck01_pepeteam_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",0),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck02_Shorak123_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",1),
                new PostIkoria(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",2),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Edel_AbzanMidrange_WBG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",3),
                new PostIkoria(),
                ArchetypeColor.WBG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Callad0_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",4),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck06_MHayashi_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",5),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_BlueLips_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",6),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_pizzaslinger_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",7),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck09_dejoyjoe_SultaiControl_UBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",8),
                new PostIkoria(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck10_Misplacedginger_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",9),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck11_xakx47x_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",10),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_signblindman_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",11),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck13_Jenara19_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",12),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_rofelos_BantMidrange_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",13),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck15_SebastianStueckl_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",14),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck16_TSPJendrek_DimirControl_UB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",15),
                new PostIkoria(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_RCMerriam_OrzhovMidrange_WB_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",16),
                new PostIkoria(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_abisbocci_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",17),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_HeyNongMan_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",18),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_Yamada_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",19),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_yneves_BantBlink_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",20),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck22_LORiWWA_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",21),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck23_2jjm_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",22),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_MaxMagicer_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",23),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_mechint_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",24),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck26_cicciogire_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",25),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck27_johnyvolta_KikiChord_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",26),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck28_Darkiundsa_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",27),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck29_122pablo_AscendancyCombo_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",28),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(AscendancyCombo),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck30_shellington5385_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",29),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck31_SunofNothing_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",30),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck32_Wolfie98_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-03",31),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }


    }
}
