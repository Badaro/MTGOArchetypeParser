using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_preliminary_2020_06_12 : EventTest
    {
        [Test]
        public void Deck01_ravensfan52720_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",0),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck02_billsive_SnowControl_SnowTitan_WUG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",1),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck03_WebZone_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",2),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck04_PeanutBrittle_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",3),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck05_ecobaronen_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",4),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck06_madechai_Prowess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",5),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck07_brunocaleb_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",6),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck08_TheTunnelingCat_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",7),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck09_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",8),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck10_staples87_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",9),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck11_benjamin13_PrimevalTitan_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",10),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck12_SonicSmasher_SnowControl_SnowBlade_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",11),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck13_ilmatagatto_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",12),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Misplacedginger_SnowControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",13),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_BSKhercules_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",14),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck16_lovealienzzz_SnowControl_TemurSnow_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",15),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(TemurSnow),
                null
            );
        }

        [Test]
        public void Deck17_yamakiller_SnowControl_SnowReclamation_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",16),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_PieGonti_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-12",17),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }


    }
}
