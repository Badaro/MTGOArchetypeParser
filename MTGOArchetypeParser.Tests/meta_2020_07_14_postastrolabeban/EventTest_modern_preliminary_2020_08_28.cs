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
#01 Gerschi: Mardu Prowess (WBR, Lurrus)
#02 __matsugan: Ad Nauseam (WUB)
#03 BERNASTORRES: KGC Tron (G)
#04 trader08111: Jund Midrange (BRG)
#05 Capriccioso: Reclaimer Titan (WRG)
#06 Milled_: Dredge (BRG)
#07 McWinSauce: Bant Control (WUG)
#08 cftsoc3: Bant Blink (WUG)
#09 frakom: Boros Prowess (WR, Lurrus)
#10 ecobaronen: Bant Control (WUG)
#11 Capitano_CL: Bant Control (WUG)
#12 PRGJJAR: Dredge (BRG)
#13 amdean: Gruul Midrange (RG)
#14 Xwhale: Rakdos Prowess (BR, Lurrus)
#15 andrw1232: Rakdos Prowess (BR, Lurrus)
#16 BananOlaf: Obosh Aggro (R, Obosh)
#17 Snusnumrick: E Tron (C)
#18 hodortimebaby: Golgari Midrange (BG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_08_28 : EventTest
    {
        [Test]
        public void Deck01_Gerschi_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-28",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_matsugan_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-28",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck03_BERNASTORRES_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-28",2),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck04_trader08111_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-28",3),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Capriccioso_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-28",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck06_Milled_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-28",5),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck07_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-28",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_cftsoc3_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-28",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck09_frakom_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-28",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_ecobaronen_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-28",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_CapitanoCL_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-28",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-28",11),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck13_amdean_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-28",12),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Xwhale_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-28",13),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_andrw1232_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-28",14),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_BananOlaf_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-28",15),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck17_Snusnumrick_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-28",16),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck18_hodortimebaby_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-28",17),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
