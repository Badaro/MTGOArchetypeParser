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
#01 Redgy819: Eldrazi Tron (C)
#02 1plus1equals3: Pyro Prison (R)
#03 Redgy: Burn (WR)
#04 mylast: Boros Prowess (WR, Lurrus)
#05 buddha715: Burn (WR, Lurrus)
#06 Gerschi: Mardu Prowess (WBR, Lurrus)
#07 kanister: Bant Control (WUG)
#08 CReactor: Green Tron (G)
#09 VampireGodric: Bant Control (WUG)
#10 BERNASTORRES: Bant Control (WUG)
#11 Beekeeper: Humans (WUBRG)
#12 trader08111: Eldrazi Tron (C)
#13 BasedCloy: Eldrazi Tron (C)
#14 Snusnumrick: Eldrazi Tron (C)
#15 Curryvore: Jeskai Blink (WUR, Yorion)
#16 predje: Gruul Midrange (RG)
#17 SIMONEFIERRO: Burn (WR)
#18 mac121711: Dredge (WBRG)
#19 MagicDevil666: Blue Tron (U)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_08_18 : EventTest
    {
        [Test]
        public void Deck01_Redgy819_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",0),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck02_1plus1equals3_PyroPrison_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",1),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(PyroPrison),
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
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck04_mylast_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Prowess),
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
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_Gerschi_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(RedAggro),
                typeof(Prowess),
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
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_CReactor_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",7),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
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
                typeof(GenericControl),
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
                typeof(GenericControl),
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
        public void Deck12_trader08111_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",11),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck13_BasedCloy_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",12),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck14_Snusnumrick_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",13),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck15_Curryvore_JeskaiBlink_WUR_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(GenericBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_predje_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",15),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
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
                typeof(RedAggro),
                typeof(Burn),
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
        public void Deck19_MagicDevil666_BlueTron_U()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-18",18),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(Tron),
                typeof(BlueTron),
                null
            );
        }


    }
}
