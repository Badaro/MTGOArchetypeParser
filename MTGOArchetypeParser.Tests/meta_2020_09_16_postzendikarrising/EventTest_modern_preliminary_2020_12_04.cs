using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 ACG88: Gruul Midrange (RG)
#02 tkcheungab: Green Tron (G)
#03 3HaLeX1: WURG Control (WURG)
#04 Sodeq: Belcher (URG)
#05 Dish: Obosh Aggro (R, Obosh)
#06 Littlemastercz: Green Tron (G)
#07 andrewsingleton80: Heliod Combo (WG)
#08 Ouranos139: Heliod Combo (WG)
#09 Eaglov: Amulet Titan (UG)
#10 Matty_Mumbles: Shadow Prowess (BR, Lurrus)
#11 ht991122: WURG Control (WURG)
#12 Lukas261997: Jund Midrange (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_04 : EventTest
    {
        [Test]
        public void Deck01_ACG88_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",0),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck02_tkcheungab_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",1),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck03_3HaLeX1_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",2),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Sodeq_Belcher_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",3),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Belcher",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Dish_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",4),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck06_Littlemastercz_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",5),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck07_andrewsingleton80_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",6),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Ouranos139_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",7),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Eaglov_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",8),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck10_MattyMumbles_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",9),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_ht991122_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",10),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Lukas261997_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",11),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}
