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
#01 __matsugan: Ad Nauseam (WUB)
#02 zumekun19850204: Bant Control (WUG)
#03 liuyuchen: Jund Midrange (BRG)
#04 toondoslav: Infect (WUG)
#05 SourceOdin: Reclaimer Titan (WRG)
#06 asnook: Rakdos Prowess (BR, Lurrus)
#07 RAINkratos: Hammer Time (W)
#08 skinnyvin: Green Tron (G)
#09 Trid0n: Humans (WUBRG)
#10 moyashi0904: Sultai Control (UBG)
#11 BERNASTORRES: Bogles (WG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_09_09 : EventTest
    {
        [Test]
        public void Deck01_matsugan_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-09",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck02_zumekun19850204_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-09",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_liuyuchen_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-09",2),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_toondoslav_Infect_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-09",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck05_SourceOdin_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-09",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck06_asnook_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-09",5),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_RAINkratos_HammerTime_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-09",6),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck08_skinnyvin_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-09",7),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck09_Trid0n_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-09",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck10_moyashi0904_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-09",9),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_BERNASTORRES_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-09",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
