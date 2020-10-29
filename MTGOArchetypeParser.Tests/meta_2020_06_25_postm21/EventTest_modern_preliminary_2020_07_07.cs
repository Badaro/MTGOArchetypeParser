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
#01 Drakanar: Merfolk (UG)
#02 Toastxp: Sultai Control (UBG)
#03 pbarrrgh: Temur Control (URG)
#04 qbturtle15: Gruul Midrange (RG, Obosh)
#05 Samcaster-Mage: E Tron (C)
#06 Daniel_Garcia: Orzhov Shadow (WB)
#07 RpAngriff: Snoop Goblins (BR)
#08 Binolino: Amulet Titan (URG)
#09 WadeB: E Tron (C)
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
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Toastxp_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-07",1),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_pbarrrgh_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-07",2),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_qbturtle15_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-07",3),
                new PostM21(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck05_SamcasterMage_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-07",4),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck06_DanielGarcia_OrzhovShadow_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-07",5),
                new PostM21(),
                ArchetypeColor.WB,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck07_RpAngriff_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-07",6),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck08_Binolino_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-07",7),
                new PostM21(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck09_WadeB_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-07",8),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck10_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-07",9),
                new PostM21(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_GideonRavensword_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-07",10),
                new PostM21(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }


    }
}
