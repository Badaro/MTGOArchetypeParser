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
#01 ArchaeusDota: KGC Tron (G)
#02 CrusherBotBG: Hammer Time (W)
#03 DreamsOfAshiok: E Tron (C)
#04 brandon__logan: Gruul Midrange (RG)
#05 tpc2000: Gifts Storm (UR)
#06 Ganksyou: Azorius Control (WU)
#07 JustBurn420: Slivers (WUBRG)
#08 osmanozguney: Faeries (UB)
#09 henryys: Burn (WR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_showcase_last_chance_2020_08_12 : EventTest
    {
        [Test]
        public void Deck01_ArchaeusDota_KGCTron_G()
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
        public void Deck04_brandonlogan_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-12",3),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
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
        public void Deck06_Ganksyou_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-12",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
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
