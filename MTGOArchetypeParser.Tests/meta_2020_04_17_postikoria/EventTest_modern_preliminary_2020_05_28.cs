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
#01 karatedom: Boros Prowess (WR, Lurrus)
#02 Icteridae: Devoted (WUG)
#03 runn3runn3r: Scapeshift (WURG, Yorion)
#04 AvocadoToast: Gruul Midrange (RG, Obosh)
#05 _LSN_: Burn (WR, Lurrus)
#06 CharlieStyle: Burn (WR, Lurrus)
#07 Mikebrav: Humans (WUBRG, Yorion)
#08 Misplacedginger: Scapeshift (WURG, Yorion)
#09 yamakiller: Green Tron (G, Jegantha)
#10 Lord_of_Puntlantis: Electro Balance (UR)
#11 PietroSas: Devoted (WG, Lurrus)
#12 sandydogmtg: Boros Prowess (WR, Lurrus)
#13 Capitano_CL: Rakdos Prowess (BR, Lurrus)
#14 Moopatroopa7: Gruul Midrange (RG, Obosh)
#15 bigjc00: Amulet Titan (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_05_28 : EventTest
    {
        [Test]
        public void Deck01_karatedom_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-28",0),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_Icteridae_Devoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-28",1),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck03_runn3runn3r_Scapeshift_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-28",2),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_AvocadoToast_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-28",3),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck05_LSN_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-28",4),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_CharlieStyle_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-28",5),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Mikebrav_Humans_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-28",6),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_Misplacedginger_Scapeshift_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-28",7),
                new PostIkoria(),
                ArchetypeColor.WURG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck09_yamakiller_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-28",8),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck10_LordofPuntlantis_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-28",9),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck11_PietroSas_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-28",10),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_sandydogmtg_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-28",11),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_CapitanoCL_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-28",12),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Moopatroopa7_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-28",13),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck15_bigjc00_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-28",14),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }


    }
}
