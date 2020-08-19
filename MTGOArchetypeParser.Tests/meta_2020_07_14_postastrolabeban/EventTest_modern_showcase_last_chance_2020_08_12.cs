using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_showcase_last_chance_2020_08_12 : EventTest
    {
        [Test]
        public void Deck01_ArchaeusDota_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-12",0),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck02_CrusherBotBG_HammerTime_W()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-12",1),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck03_DreamsOfAshiok_ETron_C()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-12",2),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck04_brandonlogan_Ponza_RG()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-12",3),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck05_tpc2000_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-12",4),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Ganksyou_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-12",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck07_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-12",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck08_osmanozguney_Faeries_UB()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-12",7),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(Faeries),
                null,
                null
            );
        }

        [Test]
        public void Deck09_henryys_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-12",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
