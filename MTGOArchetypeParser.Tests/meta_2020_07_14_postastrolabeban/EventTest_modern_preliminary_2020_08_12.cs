using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_08_12 : EventTest
    {
        [Test]
        public void Deck01_JRDC14_Rock_Sultai_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-12",0),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(Rock),
                typeof(Sultai),
                null
            );
        }

        [Test]
        public void Deck02_Snusnumrick_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-12",1),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck03_iwanteatebi_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-12",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck04_komattaman_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-12",3),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Delthar_Infect_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-12",4),
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
                GetDeck("modern-preliminary-2020-08-12",5),
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
                GetDeck("modern-preliminary-2020-08-12",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_v3sptv_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-12",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck09_kthanakit26_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-12",8),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck10_ACG88_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-12",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Kazuga_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-12",10),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck12_SebastianStueckl_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-12",11),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }


    }
}
