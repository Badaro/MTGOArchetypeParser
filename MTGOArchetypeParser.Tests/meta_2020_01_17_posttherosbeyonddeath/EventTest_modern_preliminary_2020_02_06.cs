using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Xuxa: Dredge (BRG)
#02 xfile: Dice Factory Tron (G)
#03 SebastianStueckl: Dredge (BRG)
#04 Cherryxman: Delver (UR)
#05 DontBanMeAgain: Jund Midrange (BRG)
#06 darthnius: Crabvine (UBG)
#07 lSoLlAKirA: Thopter Urza (UB)
#08 Iceman76: Mono Red Prowess (R)
#09 salty12ZA: Dredge (BRG)
#10 Gernardi: Grixis Shadow (UBR)
#11 JustBurn420: Slivers (WUBRG)
#12 ACG88: Crabvine (UBG)
#13 RpAngriff: Green Devotion (RG)
#14 Atticuslol: Amulet Titan (UG)
#15 jabritton: Neobrand (UG)
#16 FrancusAurelius: Gruul Midrange (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_02_06 : EventTest
    {
        [Test]
        public void Deck01_Xuxa_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-06",0),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck02_xfile_DiceFactoryTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-06",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "DiceFactoryTron",
                null
            );
        }

        [Test]
        public void Deck03_SebastianStueckl_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-06",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Cherryxman_Delver_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-06",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "Delver",
                null,
                null
            );
        }

        [Test]
        public void Deck05_DontBanMeAgain_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-06",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck06_darthnius_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-06",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck07_lSoLlAKirA_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-06",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck08_Iceman76_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-06",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck09_salty12ZA_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-06",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Gernardi_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-06",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck11_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-06",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUBRG,
                "Slivers",
                null,
                null
            );
        }

        [Test]
        public void Deck12_ACG88_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-06",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck13_RpAngriff_GreenDevotion_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-06",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "GreenDevotion",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Atticuslol_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-06",13),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck15_jabritton_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-06",14),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck16_FrancusAurelius_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-06",15),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}
