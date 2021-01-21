using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 BSK_hercules: Sultai Control (UBG)
#02 Mulldrifter: Shadow Prowess (WBR, Lurrus)
#03 Lord_of_Puntlantis: Electro Balance (UR)
#04 kthanakit26: Shadow Prowess (BR, Lurrus)
#05 katoriarch123: WURG Control (WURG)
#06 Artem_Kuhtin: Reclaimer Titan (WRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_11 : EventTest
    {
        [Test]
        public void Deck01_BSKhercules_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-11",0),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Mulldrifter_ShadowProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-11",1),
                "PostZendikarRising",
                ArchetypeColor.WBR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_LordofPuntlantis_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-11",2),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "FreeSpells",
                "ElectroBalance",
                null
            );
        }

        [Test]
        public void Deck04_kthanakit26_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-11",3),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_katoriarch123_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-11",4),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_ArtemKuhtin_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-11",5),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }


    }
}
