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
#05 bigjc00: Amulet Titan (URG)
#06 The_nayr: Obosh Aggro (R, Obosh)
#07 DeepFryer: Rakdos Prowess (BR, Lurrus)
#08 Bedell: Amulet Titan (RG)
#09 bozo2112: Reclaimer Titan (WRG)
#10 Xwhale: Reclaimer Titan (WRG)
#11 raven0904: Green Tron (G)
#12 wilson5434: Hardened Scales (G)
#13 TheMelkMan: Green Tron (G)
#14 crackerpack: Dredge (WBRG)
#15 Thrall90: Rakdos Prowess (BR, Lurrus)
#16 PTarts2win: Green Tron (G)
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
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck02_azax_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",1),
                "PostAstrolabeBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck03_JacobofAmber_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",2),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck04_qbturtle15_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",3),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck05_bigjc00_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",4),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck06_Thenayr_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",5),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck07_DeepFryer_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",6),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_Bedell_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",7),
                "PostAstrolabeBan",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck09_bozo2112_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",8),
                "PostAstrolabeBan",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck10_Xwhale_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",9),
                "PostAstrolabeBan",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck11_raven0904_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",10),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck12_wilson5434_HardenedScales_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",11),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "HardenedScales",
                null,
                null
            );
        }

        [Test]
        public void Deck13_TheMelkMan_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",12),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck14_crackerpack_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",13),
                "PostAstrolabeBan",
                ArchetypeColor.WBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Thrall90_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",14),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_PTarts2win_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",15),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck17_andrw1232_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",16),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_fingers1991_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",17),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-08",18),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
