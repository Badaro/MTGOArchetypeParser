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
#02 CReactor: BorosProwess (WR, Lurrus)
#03 Yooisa: Infect (UG)
#04 Toastxp: ReclaimerTitan (WRG, Yorion)
#05 JustBurn420: Slivers (WUBRG)
#06 Beltan3: AdNauseam (WUB)
#07 Trid0n: KGCAmuletTitan (WUBRG)
#08 niftylegos: Burn (WR)
#09 IntegralHDK: BorosProwess (WR, Lurrus)
#10 Do0mSwitch: BantControl (WUG)
#11 SebastianStueckl: KGCAmuletTitan (WUBRG)
#12 ilsecco14: Neobrand (UG)
#13 Zar0s: AmuletTitan (URG)
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
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_CReactor_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Yooisa_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Toastxp_ReclaimerTitan_WRG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck05_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Beltan3_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Trid0n_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck08_niftylegos_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck09_IntegralHDK_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_Do0mSwitch_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_SebastianStueckl_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck12_ilsecco14_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",11),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Zar0s_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-05",12),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }


    }
}
