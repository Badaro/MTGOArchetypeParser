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
#01 Coly2: Gruul Midrange (RG, Obosh)
#02 DreamsOfAshiok: Eldrazi Tron (C)
#03 ManuGodineau: Gruul Midrange (RG, Obosh)
#04 sff_mtg: Green Tron (G, Jegantha)
#05 Toastxp: Jund Prowess (BRG, Lurrus)
#06 Olivetti: Rakdos Prowess (BR, Lurrus)
#07 eresopacaso: Eldrazi Tron (C)
#08 Gigy: Gruul Midrange (RG, Obosh)
#09 yPrincipe: WUBG Control (WUBG, Yorion)
#10 _Stream: Jund Prowess (BRG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_05_29 : EventTest
    {
        [Test]
        public void Deck01_Coly2_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-29",0),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck02_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-29",1),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck03_ManuGodineau_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-29",2),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck04_sffmtg_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-29",3),
                "PostIkoria",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck05_Toastxp_JundProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-29",4),
                "PostIkoria",
                ArchetypeColor.BRG,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_Olivetti_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-29",5),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_eresopacaso_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-29",6),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck08_Gigy_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-29",7),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck09_yPrincipe_WUBGControl_WUBG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-29",8),
                "PostIkoria",
                ArchetypeColor.WUBG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck10_Stream_JundProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-29",9),
                "PostIkoria",
                ArchetypeColor.BRG,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
