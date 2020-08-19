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
    public class EventTest_modern_preliminary_2020_07_15 : EventTest
    {
        [Test]
        public void Deck01_ImmanuelKantrolGod_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-15",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_INF_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-15",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck03_BSKhercules_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-15",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck04_johnsmith3373_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-15",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck05_MiamiKidz_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-15",4),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck06_Shorak123_SnowControl_SnowReclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-15",5),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck07_siomomi_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-15",6),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck08_GoonLord_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-15",7),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck09_ZYURYO_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-15",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                null,
                null
            );
        }


    }
}
