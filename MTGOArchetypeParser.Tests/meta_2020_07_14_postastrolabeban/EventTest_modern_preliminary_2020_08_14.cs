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
#01 Cherryxman: KGCTron (G)
#02 audio336: AzoriusControl (WU)
#03 tibalt_of_red_sub: Mill (UB, Lurrus)
#04 Do0mSwitch: BantControl (WUG)
#05 sff_mtg: KGCTron (G)
#06 Boin: SnoopGoblins (BR)
#07 ht991122: WildernessReclamation (UBG)
#08 Je3vEs: ETron (C)
#09 tribalmaster: IzzetProwess (UR)
#10 Niedzwiedz: SnoopGoblins (BR)
#11 trader08111: ETron (C)
#12 theBMeister: GreenStompy (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_08_14 : EventTest
    {
        [Test]
        public void Deck01_Cherryxman_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-14",0),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck02_audio336_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-14",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_tibaltofredsub_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-14",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Do0mSwitch_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-14",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_sffmtg_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-14",4),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck06_Boin_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-14",5),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck07_ht991122_WildernessReclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-14",6),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Je3vEs_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-14",7),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck09_tribalmaster_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-14",8),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Niedzwiedz_Goblins_SnoopGoblins_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-14",9),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck11_trader08111_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-14",10),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck12_theBMeister_GreenStompy_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-14",11),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GreenStompy),
                null,
                null
            );
        }


    }
}
