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
#01 exoticherman: Shadow Prowess (BRG, Lurrus)
#02 kbol_: WURG Control (WURG)
#03 _Stream: Naya Prowess (WRG, Lurrus)
#04 tzio: Orzhov Midrange (WB)
#05 PieGonti: Heliod Combo (WG)
#06 Bedell: Mill (UB, Lurrus)
#07 mmapson125: Heliod Combo (WG)
#08 Gerardo94: WURG Control (WURG)
#09 Splogy: Pyro Prison (R)
#10 SanPop: Oops All Spells (WUBRG)
#11 MastaHorus: Electro End (UR)
#12 Lukas261997: Shadow Prowess (UBR, Lurrus)
#13 braingoat: Shadow Prowess (BRG, Lurrus)
#14 Redgy819: Oops All Spells (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_11_10 : EventTest
    {
        [Test]
        public void Deck01_exoticherman_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-10",0),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_kbol_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-10",1),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Stream_NayaProwess_WRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-10",2),
                new PostZendikarRising(),
                ArchetypeColor.WRG,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_tzio_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-10",3),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_PieGonti_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-10",4),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Bedell_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-10",5),
                new PostZendikarRising(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_mmapson125_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-10",6),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Gerardo94_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-10",7),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Splogy_PyroPrison_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-10",8),
                new PostZendikarRising(),
                ArchetypeColor.R,
                typeof(PyroPrison),
                null,
                null
            );
        }

        [Test]
        public void Deck10_SanPop_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-10",9),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck11_MastaHorus_ElectroEnd_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-10",10),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroEnd),
                null
            );
        }

        [Test]
        public void Deck12_Lukas261997_ShadowProwess_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-10",11),
                new PostZendikarRising(),
                ArchetypeColor.UBR,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_braingoat_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-10",12),
                new PostZendikarRising(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                typeof(ShadowProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Redgy819_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-11-10",13),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }


    }
}
