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
#01 Gerschi: MarduProwess (WBR, Lurrus)
#02 __matsugan: AdNauseam (WUB)
#03 BERNASTORRES: KGCTron (G)
#04 trader08111: JundMidrange (BRG)
#05 Capriccioso: PrimevalTitan (WRG)
#06 Milled_: Dredge (WBRG)
#07 McWinSauce: BantControl (WUG)
#08 cftsoc3: BantBlink (WUG)
#09 frakom: BorosProwess (WR, Lurrus)
#10 ecobaronen: BantControl (WUG)
#11 Capitano_CL: BantControl (WUG)
#12 PRGJJAR: Dredge (BRG)
#13 amdean: GruulMidrange (RG)
#14 Xwhale: RakdosProwess (BR, Lurrus)
#15 andrw1232: RakdosProwess (BR, Lurrus)
#16 BananOlaf: OboshAggro (R, Obosh)
#17 Snusnumrick: ETron (C)
#18 hodortimebaby: GolgariMidrange (BG)
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
                typeof(GTron),
                typeof(KGCTron),
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
        public void Deck05_Capriccioso_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-28",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Milled_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-28",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
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
                typeof(ETron),
                null,
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
