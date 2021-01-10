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
#01 albert62: Jund Midrange (BRG)
#02 The_nayr: Obosh Aggro (R, Obosh)
#03 liuyuchen: Jund Midrange (BRG)
#04 ImmanuelKantrolGod: Bant Control (WUG)
#05 BERNASTORRES: Bogles (WG, Lurrus)
#06 Trid0n: Amulet Titan (UG)
#07 Somefellow: Amulet Titan (URG)
#08 Cherryxman: Naya Midrange (WRG)
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
        public void Deck02_Thenayr_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-04",1),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(OboshAggro),
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
        public void Deck06_Trid0n_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-09-04",5),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
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
