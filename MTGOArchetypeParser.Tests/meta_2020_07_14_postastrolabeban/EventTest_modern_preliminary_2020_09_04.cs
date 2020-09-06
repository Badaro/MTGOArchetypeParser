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
#01 albert62: JundMidrange (BRG)
#02 The_nayr: MonoRedProwess (R, Obosh)
#03 liuyuchen: JundMidrange (BRG)
#04 ImmanuelKantrolGod: BantControl (WUG)
#05 BERNASTORRES: Bogles (WG, Lurrus)
#06 Trid0n: KGCAmuletTitan (WUBRG)
#07 Somefellow: AmuletTitan (URG)
#08 Cherryxman: NayaMidrange (WRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_09_04 : EventTest
    {
        [Test]
        public void Deck01_albert62_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-04",0),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Thenayr_MonoRedProwess_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-04",1),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck03_liuyuchen_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-04",2),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_ImmanuelKantrolGod_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-04",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_BERNASTORRES_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-04",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_Trid0n_KGCAmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-04",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck07_Somefellow_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-04",6),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck08_Cherryxman_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-04",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}