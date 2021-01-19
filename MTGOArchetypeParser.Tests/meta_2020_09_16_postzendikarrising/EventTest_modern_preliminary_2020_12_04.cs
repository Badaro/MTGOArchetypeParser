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
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_tkcheungab_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",1),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck03_3HaLeX1_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",2),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Sodeq_Belcher_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",3),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Belcher),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Dish_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",4),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck06_Littlemastercz_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",5),
                new PostZendikarRising(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck07_andrewsingleton80_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",6),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Ouranos139_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",7),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Eaglov_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",8),
                new PostZendikarRising(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck10_MattyMumbles_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",9),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_ht991122_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",10),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Lukas261997_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-04",11),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
