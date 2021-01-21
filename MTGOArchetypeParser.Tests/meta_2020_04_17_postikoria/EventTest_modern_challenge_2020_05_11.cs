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
#01 Saviall: Green Tron (G)
#02 Sodeq: Ad Nauseam (WUB)
#03 ilsecco14: Neobrand (UG)
#04 Namkrew___Lacsap: Primeval Titan (UG)
#05 Laplasjan: Devoted (WG, Lurrus)
#06 ponchonater55: Boros Prowess (WR, Lurrus)
#07 tzirkel: Boros Prowess (WR, Lurrus)
#08 KIMCHIMAN: Boros Prowess (WR, Lurrus)
#09 Never_DidntHaveIt: Jund Shadow (BRG, Lurrus)
#10 audio336: Boros Prowess (WR, Lurrus)
#11 Gobern: Reclamation (UBG)
#12 12Days: Gruul Midrange (RG, Obosh)
#13 zarbo: Jund Midrange (BRG, Lurrus)
#14 SebastianStueckl: Green Tron (RG, Jegantha)
#15 pizzaslinger: Eldrazi Tron (C)
#16 patheus_84: Ad Nauseam (WUB)
#17 Vallejo97: Scapeshift (URG, Yorion)
#18 Felo: Burn (WR, Lurrus)
#19 Tiemuuu: Izzet Control (UR)
#20 MATTHEWFOULKES: Uroza (UBG, Yorion)
#21 signblindman: Gruul Midrange (RG, Obosh)
#22 2jjm: Burn (WR, Lurrus)
#23 MiamiKidz: Amulet Titan (UG)
#24 ACG88: Gruul Midrange (RG, Obosh)
#25 ack_s: Hammer Time (WR, Lurrus)
#26 Bullz0Eye: Eldrazi Tron (C)
#27 eminemberry: Burn (WR, Lurrus)
#28 Sharkcaster_Mage: Primeval Titan (UG)
#29 RandomOctopus: Eldrazi Tron (C)
#30 2radMTG: Amulet Titan (UG)
#31 SknerusMcKwacz: Boros Prowess (WR, Lurrus)
#32 Heibing: Titan Shift (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_challenge_2020_05_11 : EventTest
    {
        [Test]
        public void Deck01_Saviall_GreenTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",0),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck02_Sodeq_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",1),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck03_ilsecco14_Neobrand_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",2),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck04_NamkrewLacsap_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",3),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",4),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_ponchonater55_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",5),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_tzirkel_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",6),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_KIMCHIMAN_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",7),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_NeverDidntHaveIt_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",8),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_audio336_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",9),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_Gobern_Reclamation_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",10),
                new PostIkoria(),
                ArchetypeColor.UBG,
                typeof(Reclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck12_12Days_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",11),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck13_zarbo_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",12),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_SebastianStueckl_GreenTron_RG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",13),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck15_pizzaslinger_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",14),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck16_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",15),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Vallejo97_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",16),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_Felo_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",17),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",18),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_MATTHEWFOULKES_Uroza_UBG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",19),
                new PostIkoria(),
                ArchetypeColor.UBG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck21_signblindman_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",20),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck22_2jjm_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",21),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_MiamiKidz_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",22),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck24_ACG88_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",23),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck25_acks_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",24),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_Bullz0Eye_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",25),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck27_eminemberry_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",26),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_SharkcasterMage_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",27),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck29_RandomOctopus_EldraziTron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",28),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck30_2radMTG_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",29),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck31_SknerusMcKwacz_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",30),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck32_Heibing_TitanShift_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-05-11",31),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }


    }
}
