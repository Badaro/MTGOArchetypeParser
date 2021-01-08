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
#01 AvocadoToast: Primeval Titan (BG)
#02 Just_Roll: Eldrazi Tron (C)
#03 PuntThenWhine: Amulet Titan (G)
#04 al8ert.dk: Eldrazi Tron (C)
#05 ___Frashe___: Crabvine (UBG)
#06 Nikito18: Bant Control (WUG)
#07 Graciasportanto: Eldrazi Tron (C)
#08 Kazuga: Jund Midrange (BRG)
#09 Violent_Outburst: Sultai Shadow (UBG)
#10 kefka27: Eldrazi Tron (C)
#11 zMagic4ever: Eldrazi Tron (C)
#12 Mateusf34: Eldrazi Tron (C)
#13 ApesOfWrath: Burn (WR)
#14 Chefen: Eldrazi Tron (C)
#15 GHash77: Jund Shadow (BRG)
#16 KelMasterP: Eldrazi Tron (C)
#17 C4N7O: Uroza (UG)
#18 ChillingLauge: Eldrazi Tron (C)
#19 thepensword: Izzet Control (UR)
#20 Daryl_Ayers: Amulet Titan (UG)
#21 stainerson: Gruul Midrange (RG)
#22 Beicodegeia: Gifts Storm (UR)
#23 darthnius: Crabvine (UBG)
#24 SickWorld: Mono Red Prowess (R)
#25 nsg1989: Eldrazi Tron (C)
#26 WuYuHsien: Bant Control (WUG)
#27 rileydk: Amulet Titan (UG)
#28 Nammersquats: Mono Red Prowess (R)
#29 didoguidotti1: Sultai Shadow (UBG)
#30 FranPi: Gifts Storm (UR)
#31 THEsneakyhomunculous: Uroza (UG)
#32 Salty_Steve: Green Tron (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_showcase_challenge_2020_03_01 : EventTest
    {
        [Test]
        public void Deck01_AvocadoToast_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck02_JustRoll_EldraziTron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck03_PuntThenWhine_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck04_al8ertdk_EldraziTron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck05_Frashe_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Nikito18_BantControl_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Graciasportanto_EldraziTron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck08_Kazuga_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_ViolentOutburst_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck10_kefka27_EldraziTron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck11_zMagic4ever_EldraziTron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck12_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck13_ApesOfWrath_Burn_WR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Chefen_EldraziTron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck15_GHash77_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck16_KelMasterP_EldraziTron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",15),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck17_C4N7O_Uroza_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",16),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck18_ChillingLauge_EldraziTron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",17),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck19_thepensword_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",18),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_DarylAyers_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",19),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck21_stainerson_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",20),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Beicodegeia_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",21),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck23_darthnius_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",22),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck24_SickWorld_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",23),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck25_nsg1989_EldraziTron_C()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",24),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck26_WuYuHsien_BantControl_WUG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",25),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck27_rileydk_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",26),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck28_Nammersquats_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",27),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck29_didoguidotti1_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",28),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck30_FranPi_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",29),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck31_THEsneakyhomunculous_Uroza_UG()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",30),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck32_SaltySteve_GreenTron_G()
        {
            Test(
                GetDeck("modern-showcase-challenge-2020-03-01",31),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }


    }
}