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
#01 JRDC14: SultaiMidrange (UBG)
#02 Snusnumrick: ETron (C)
#03 iwanteatebi: IzzetProwess (UR)
#04 komattaman: GruulMidrange (RG)
#05 Delthar: Infect (BG)
#06 Beenew: Burn (WR)
#07 katoriarch123: BantControl (WUG)
#08 v3sp_tv: Elementals (WUBRG)
#09 kthanakit26: IzzetProwess (UR)
#10 ACG88: BantMidrange (WUG)
#11 Kazuga: Dredge (WBRG)
#12 SebastianStueckl: GruulMidrange (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_08_07 : EventTest
    {
        [Test]
        public void Deck01_JRDC14_SultaiMidrange_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-07",0),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Snusnumrick_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-07",1),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck03_iwanteatebi_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-07",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck04_komattaman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-07",3),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Delthar_Infect_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-07",4),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Beenew_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-07",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck07_katoriarch123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-07",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_v3sptv_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-07",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck09_kthanakit26_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-07",8),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck10_ACG88_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-07",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Kazuga_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-07",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck12_SebastianStueckl_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-07",11),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
