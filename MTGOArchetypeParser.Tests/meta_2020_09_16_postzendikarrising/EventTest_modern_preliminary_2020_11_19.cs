using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 azax: Reclaimer Titan (WG)
#02 zajad: Dredge (BRG)
#03 benchsummer: Shadow Prowess (UBRG, Lurrus)
#04 Gerardo94: WURG Control (WURG)
#05 PTarts2win: Obosh Aggro (R, Obosh)
#06 Lucabireskusku: Jeskai Control (WUR)
#07 Mcleskey: Bogles (WG, Lurrus)
#08 pokerswizard: Shadow Prowess (WBR, Lurrus)
#09 Lordzedane: Electro Balance (URG)
#10 RagingTiltMonster: Devoted (WG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_11_19 : EventTest
    {
        [Test]
        public void Deck01_azax_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-19",0),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck02_zajad_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-19",1),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck03_benchsummer_ShadowProwess_UBRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-19",2),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Gerardo94_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-19",3),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_PTarts2win_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-19",4),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck06_Lucabireskusku_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-19",5),
                "PostZendikarRising",
                ArchetypeColor.WUR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Mcleskey_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-19",6),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_pokerswizard_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-19",7),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_Lordzedane_ElectroBalance_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-19",8),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "FreeSpells",
                "ElectroBalance",
                null
            );
        }

        [Test]
        public void Deck10_RagingTiltMonster_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-19",9),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
