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
#01 Redgy819: ETron (C)
#02 1plus1equals3: RedPrison (R)
#03 Redgy: Burn (WR)
#04 mylast: Prowess (WR, Lurrus)
#05 buddha715: Burn (WR, Lurrus)
#06 Gerschi: RakdosProwess (WBR, Lurrus)
#07 kanister: BantControl (WUG)
#08 CReactor: KGCTron (G)
#09 VampireGodric: BantControl (WUG)
#10 BERNASTORRES: BantControl (WUG)
#11 Beekeeper: Humans (WUBRG)
#12 trader08111: ETron (C)
#13 BasedCloy: ETron (C)
#14 Snusnumrick: ETron (C)
#15 Curryvore: JeskaiBlink (WUR, Yorion)
#16 predje: Ponza (RG)
#17 SIMONEFIERRO: Burn (WR)
#18 mac121711: Dredge (WBRG)
#19 MagicDevil666: UTron (U)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_08_18 : EventTest
    {
        [Test]
        public void Deck01_Redgy819_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",0),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck02_1plus1equals3_RedPrison_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",1),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(RedPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Redgy_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck04_mylast_Prowess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Prowess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_buddha715_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_Gerschi_Prowess_RakdosProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_kanister_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_CReactor_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",7),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck09_VampireGodric_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_BERNASTORRES_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Beekeeper_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck12_trader08111_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",11),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck13_BasedCloy_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",12),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Snusnumrick_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",13),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Curryvore_AzoriousBlink_JeskaiBlink_WUR_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(AzoriousBlink),
                typeof(JeskaiBlink),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_predje_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",15),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck17_SIMONEFIERRO_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck18_mac121711_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck19_MagicDevil666_UTron_U()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",18),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }


    }
}
