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
#01 musasabi: WURG Control (WURG)
#02 Patxi: WURG Control (WURG)
#03 NinoMtg: Bant Midrange (WUG)
#04 Lord_of_Puntlantis: Electro Balance (UR)
#05 ArchaeusDota: Uroza (URG)
#06 Ekeross: Shadow Prowess (BR, Lurrus)
#07 WhiTe TsaR: Obosh Aggro (R, Obosh)
#08 albert62: WURG Control (WURG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2021_01_13 : EventTest
    {
        [Test]
        public void Deck01_musasabi_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-13",0),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Patxi_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-13",1),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_NinoMtg_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-13",2),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck04_LordofPuntlantis_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-13",3),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "FreeSpells",
                "ElectroBalance",
                null
            );
        }

        [Test]
        public void Deck05_ArchaeusDota_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-13",4),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Ekeross_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-13",5),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_WhiTeTsaR_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-13",6),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck08_albert62_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-13",7),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
