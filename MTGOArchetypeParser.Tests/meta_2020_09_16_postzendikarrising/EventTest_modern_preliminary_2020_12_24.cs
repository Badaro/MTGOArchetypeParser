using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Pilz_753: Jeskai Control (WUR)
#02 nathansteuer: Rakdos Midrange (BR)
#03 Shadowz2005: Izzet Prowess (UR)
#04 sandydogmtg: Infect (UG)
#05 bomberboss: Mardu Midrange (WBR)
#06 bolov0: Rakdos Midrange (BR)
#07 Xwhale: Reclaimer Titan (WRG)
#08 pokerswizard: Green Tron (G)
#09 bmac668: Izzet Prowess (UR)
#10 Mistakenn: Amulet Titan (RG)
#11 MastaHorus: Electro End (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_24 : EventTest
    {
        [Test]
        public void Deck01_Pilz753_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-24",0),
                "PostZendikarRising",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_nathansteuer_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-24",1),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Shadowz2005_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-24",2),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck04_sandydogmtg_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-24",3),
                "PostZendikarRising",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck05_bomberboss_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-24",4),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck06_bolov0_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-24",5),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Xwhale_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-24",6),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck08_pokerswizard_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-24",7),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck09_bmac668_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-24",8),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck10_Mistakenn_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-24",9),
                "PostZendikarRising",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck11_MastaHorus_ElectroEnd_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-24",10),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "FreeSpells",
                "ElectroEnd",
                null
            );
        }


    }
}
