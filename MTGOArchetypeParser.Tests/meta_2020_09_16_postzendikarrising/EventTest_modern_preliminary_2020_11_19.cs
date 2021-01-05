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
#01 azax: Reclaimer Titan (WG)
#02 zajad: Dredge (BRG)
#03 benchsummer: Shadow Prowess (BRG, Lurrus)
#04 Gerardo94: WURG Control (WURG)
#05 PTarts2win: Obosh Aggro (R, Obosh)
#06 Lucabireskusku: Jeskai Control (WUR)
#07 Mcleskey: Bogles (WG, Lurrus)
#08 pokerswizard: Shadow Prowess (WBR, Lurrus)
#09 Lordzedane: Electro Balance (UR)
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
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck02_zajad_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-19",1),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck03_benchsummer_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-19",2),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Gerardo94_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-19",3),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_PTarts2win_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-19",4),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck06_Lucabireskusku_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-19",5),
                new PostZendikarRising(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Mcleskey_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-19",6),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_pokerswizard_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-19",7),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(ShadowProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_Lordzedane_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-19",8),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck10_RagingTiltMonster_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-19",9),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
