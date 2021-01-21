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
#01 BERNASTORRES: Bogles (WG, Lurrus)
#02 CReactor: Boros Prowess (WR, Lurrus)
#03 Yooisa: Infect (UG)
#04 Toastxp: Reclaimer Titan (WRG, Yorion)
#05 JustBurn420: Slivers (WUBRG)
#06 Beltan3: Ad Nauseam (WUB)
#07 Trid0n: Amulet Titan (UG)
#08 niftylegos: Burn (WR)
#09 IntegralHDK: Boros Prowess (WR, Lurrus)
#10 Do0mSwitch: Bant Control (WUG)
#11 SebastianStueckl: Amulet Titan (UG)
#12 ilsecco14: Neobrand (UG)
#13 Zar0s: Amulet Titan (URG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_09_05 : EventTest
    {
        [Test]
        public void Deck01_BERNASTORRES_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",0),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_CReactor_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",1),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Yooisa_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",2),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Toastxp_ReclaimerTitan_WRG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",3),
                "PostAstrolabeBan",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck05_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",4),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Slivers",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Beltan3_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",5),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Trid0n_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",6),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck08_niftylegos_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",7),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck09_IntegralHDK_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",8),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Do0mSwitch_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",9),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_SebastianStueckl_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",10),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck12_ilsecco14_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",11),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Zar0s_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",12),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }


    }
}
