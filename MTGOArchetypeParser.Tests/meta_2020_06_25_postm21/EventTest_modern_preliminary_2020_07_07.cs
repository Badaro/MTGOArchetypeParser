using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Drakanar: Merfolk (UG)
#02 Toastxp: Sultai Control (UBG)
#03 pbarrrgh: Temur Control (URG)
#04 qbturtle15: Gruul Midrange (RG, Obosh)
#05 Samcaster-Mage: Eldrazi Tron (C)
#06 Daniel_Garcia: Orzhov Shadow (WB)
#07 RpAngriff: Goblins (BR)
#08 Binolino: Amulet Titan (URG)
#09 WadeB: Eldrazi Tron (C)
#10 McWinSauce: Bant Control (WUG)
#11 GideonRavensword: Ad Nauseam (WUB)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_preliminary_2020_07_07 : EventTest
    {
        [Test]
        public void Deck01_Drakanar_Merfolk_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-07",0),
                "PostM21",
                ArchetypeColor.UG,
                "Merfolk",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Toastxp_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-07",1),
                "PostM21",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_pbarrrgh_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-07",2),
                "PostM21",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_qbturtle15_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-07",3),
                "PostM21",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck05_SamcasterMage_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-07",4),
                "PostM21",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck06_DanielGarcia_OrzhovShadow_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-07",5),
                "PostM21",
                ArchetypeColor.WB,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck07_RpAngriff_Goblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-07",6),
                "PostM21",
                ArchetypeColor.BR,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Binolino_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-07",7),
                "PostM21",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck09_WadeB_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-07",8),
                "PostM21",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck10_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-07",9),
                "PostM21",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_GideonRavensword_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-07",10),
                "PostM21",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }


    }
}
