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
#01 karn_90: Rakdos Prowess (BR, Lurrus)
#02 in5ano: Scapeshift (URG, Yorion)
#03 ZYURYO: WUBG Control (WUBG, Yorion)
#04 Gigy: Gruul Midrange (RG, Obosh)
#05 TonySilence: Amulet Titan (UG)
#06 Ouranos139: Amulet Titan (UG)
#07 il_matagatto: Humans (WUBRG, Jegantha)
#08 LORiWWA: Eldrazi Tron (C)
#09 MissTrigger: Eldrazi Tron (C)
#10 ilsecco14: Golgari Midrange (BG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_06_03 : EventTest
    {
        [Test]
        public void Deck01_karn90_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-03",0),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_in5ano_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-03",1),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_ZYURYO_WUBGControl_WUBG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-03",2),
                new PostIkoria(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_Gigy_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-03",3),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck05_TonySilence_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-03",4),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck06_Ouranos139_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-03",5),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck07_ilmatagatto_Humans_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-03",6),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck08_LORiWWA_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-03",7),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck09_MissTrigger_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-03",8),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck10_ilsecco14_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-03",9),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
