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
#01 yamakiller: Obosh Aggro (R, Obosh)
#02 azax: Grixis Shadow (UBR)
#03 JacobofAmber: Ad Nauseam (WUB)
#04 qbturtle15: Gruul Midrange (RG)
#05 bigjc00: Amulet Titan (RG)
#06 The_nayr: Obosh Aggro (R, Obosh)
#07 DeepFryer: Rakdos Prowess (BR, Lurrus)
#08 Bedell: Amulet Titan (RG)
#09 bozo2112: Reclaimer Titan (WRG)
#10 Xwhale: Reclaimer Titan (WRG)
#11 raven0904: G Tron (G)
#12 wilson5434: Hardened Scales (G)
#13 TheMelkMan: Golos Tron (G)
#14 crackerpack: Dredge (BRG)
#15 Thrall90: Rakdos Prowess (BR, Lurrus)
#16 PTarts2win: KGC Tron (G)
#17 andrw1232: Rakdos Prowess (BR, Lurrus)
#18 fingers1991: Boros Prowess (WR, Lurrus)
#19 McWinSauce: Bant Control (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_09_08 : EventTest
    {
        [Test]
        public void Deck01_yamakiller_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",0),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck02_azax_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck03_JacobofAmber_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck04_qbturtle15_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",3),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_bigjc00_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",4),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck06_Thenayr_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",5),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck07_DeepFryer_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",6),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_Bedell_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",7),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck09_bozo2112_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck10_Xwhale_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck11_raven0904_GTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",10),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck12_wilson5434_HardenedScales_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",11),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck13_TheMelkMan_GolosTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",12),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(GolosTron),
                null
            );
        }

        [Test]
        public void Deck14_crackerpack_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",13),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Thrall90_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",14),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_PTarts2win_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",15),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck17_andrw1232_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",16),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_fingers1991_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",17),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",18),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
