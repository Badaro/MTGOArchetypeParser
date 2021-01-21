using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Ouranos139: Amulet Titan (URG)
#02 Toastxp: Sultai Control (UBG)
#03 fingers1991: Bant Control (WUG)
#04 Theo_Jung: Sultai Control (UBG)
#05 Samcaster-Mage: Eldrazi Tron (C)
#06 Icteridae: Eldrazi Tron (C)
#07 TubbyBatman: Izzet Prowess (UR)
#08 no_lyfe: Mono Red Prowess (R)
#09 karatedom: Goblins (BR)
#10 Mr_Sheep: Burn (WR)
#11 Motown123: Merfolk (U)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_preliminary_2020_07_02 : EventTest
    {
        [Test]
        public void Deck01_Ouranos139_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-02",0),
                "PostM21",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck02_Toastxp_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-02",1),
                "PostM21",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_fingers1991_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-02",2),
                "PostM21",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_TheoJung_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-02",3),
                "PostM21",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_SamcasterMage_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-02",4),
                "PostM21",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck06_Icteridae_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-02",5),
                "PostM21",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck07_TubbyBatman_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-02",6),
                "PostM21",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck08_nolyfe_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-02",7),
                "PostM21",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck09_karatedom_Goblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-02",8),
                "PostM21",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck10_MrSheep_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-02",9),
                "PostM21",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck11_Motown123_Merfolk_U()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-02",10),
                "PostM21",
                ArchetypeColor.U,
                "Merfolk",
                null,
                null
            );
        }


    }
}
