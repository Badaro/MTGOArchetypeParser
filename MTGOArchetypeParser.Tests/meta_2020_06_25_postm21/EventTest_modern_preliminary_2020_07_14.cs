using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_preliminary_2020_07_14 : EventTest
    {
        [Test]
        public void Deck01_pepeteam_PrimevalTitan_AmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-14",0),
                new PostM21(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck02_osmanozguney_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-14",1),
                new PostM21(),
                ArchetypeColor.BR,
                typeof(RakdosMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_azatoyellow_Prowess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-14",2),
                new PostM21(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck04_ACG88_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-14",3),
                new PostM21(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck05_WingedHussar_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-14",4),
                new PostM21(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck06_bubbsei_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-14",5),
                new PostM21(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_LickNsticK_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-14",6),
                new PostM21(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck08_RicardoMSLan_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-14",7),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck09_PizzaRolls_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-14",8),
                new PostM21(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }


    }
}
