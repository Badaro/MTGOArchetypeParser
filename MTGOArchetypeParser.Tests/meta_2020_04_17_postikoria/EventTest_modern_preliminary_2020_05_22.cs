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
#01 fradev1988: Electro Balance (URG)
#02 DreamsOfAshiok: Eldrazi Tron (C)
#03 Gigy: Gruul Midrange (RG, Obosh)
#04 Ouranos139: Amulet Titan (URG)
#05 theBMeister: Zirda Combo (WG, Zirda)
#06 eresopacaso: Burn (WR, Lurrus)
#07 2radMTG: Orzhov Midrange (WB, Zirda)
#08 kefka27: Gruul Midrange (RG, Obosh)
#09 GrandDrou: Rakdos Prowess (BR, Lurrus)
#10 J000111: Dredge (BRG)
#11 TheNutLo: Mardu Prowess (WBR, Lurrus)
#12 Venom1: Jund Midrange (BRG, Lurrus)
#13 PlaneswalkerYami: Jund Midrange (BRG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_05_22 : EventTest
    {
        [Test]
        public void Deck01_fradev1988_ElectroBalance_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-22",0),
                "PostIkoria",
                ArchetypeColor.URG,
                "FreeSpells",
                "ElectroBalance",
                null
            );
        }

        [Test]
        public void Deck02_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-22",1),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck03_Gigy_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-22",2),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck04_Ouranos139_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-22",3),
                "PostIkoria",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck05_theBMeister_ZirdaCombo_WG_Zirda()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-22",4),
                "PostIkoria",
                ArchetypeColor.WG,
                "ZirdaCombo",
                null,
                ArchetypeCompanion.Zirda
            );
        }

        [Test]
        public void Deck06_eresopacaso_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-22",5),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_2radMTG_OrzhovMidrange_WB_Zirda()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-22",6),
                "PostIkoria",
                ArchetypeColor.WB,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Zirda
            );
        }

        [Test]
        public void Deck08_kefka27_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-22",7),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck09_GrandDrou_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-22",8),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_J000111_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-22",9),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck11_TheNutLo_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-22",10),
                "PostIkoria",
                ArchetypeColor.WBR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_Venom1_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-22",11),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_PlaneswalkerYami_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-22",12),
                "PostIkoria",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
