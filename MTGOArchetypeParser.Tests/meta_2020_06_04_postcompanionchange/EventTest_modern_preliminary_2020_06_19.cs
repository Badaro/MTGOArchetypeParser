using FluentAssertions;
using MTGOArchetypeParser.Model;
using MTGOArchetypeParser.Metas.Modern;
using MTGOArchetypeParser.Archetypes.Modern;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_preliminary_2020_06_19 : EventTest
    {
        [Test]
        public void Deck01_Shatun_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",0),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck02_MrJACEone_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",1),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck03_qbturtle15_Ponza_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",2),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck04_staples87_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",3),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck05_PeanutBrittle_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",4),
                new PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck06_billsive_SnowControl_SnowTitan_WUG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",5),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowTitan),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck07_nolyfe_Prowess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",6),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck08_BoltTheBirds_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",7),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck09_BaronOfBacon_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",8),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck10_joetru_BringToNiv_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",9),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck11_ManavonRX_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",10),
                new PostCompanionChange(),
                ArchetypeColor.BR,
                typeof(RakdosMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_lovealienzzz_SnowControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",11),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_eggybenny_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",12),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck14_erose199423_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",13),
                new PostCompanionChange(),
                ArchetypeColor.WUR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck15_rn17_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",14),
                new PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Boin_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",15),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Jositoshekel_Bogles_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",16),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }


    }
}
