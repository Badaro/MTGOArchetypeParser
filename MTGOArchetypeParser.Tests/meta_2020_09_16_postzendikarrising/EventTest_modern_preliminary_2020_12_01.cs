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
#01 Do0mSwitch: WURG Control (WURG)
#02 eresopacaso: Green Tron (G)
#03 ArchaeusDota: Green Tron (G)
#04 _Shatun_: Obosh Aggro (R, Obosh)
#05 Lukas261997: Jund Midrange (BRG)
#06 xfile: Shadow Prowess (BR, Lurrus)
#07 exoticherman: Shadow Prowess (BR, Lurrus)
#08 WhiTe TsaR: WURG Control (WURG)
#09 mariogomes097: Hammer Time (W, Lurrus)
#10 alemilan19: Heliod Combo (WG)
#11 mashmalovsky: Ad Nauseam (WUB)
#12 MZBlazer: Heliod Combo (WG)
#13 MaxCapone: Belcher (URG)
#14 Oderus Urungus: Obosh Aggro (R, Obosh)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_01 : EventTest
    {
        [Test]
        public void Deck01_Do0mSwitch_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-01",0),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_eresopacaso_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-01",1),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck03_ArchaeusDota_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-01",2),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck04_Shatun_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-01",3),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck05_Lukas261997_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-01",4),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck06_xfile_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-01",5),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_exoticherman_ShadowProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-01",6),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_WhiTeTsaR_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-01",7),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck09_mariogomes097_HammerTime_W_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-01",8),
                "PostZendikarRising",
                ArchetypeColor.W,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_alemilan19_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-01",9),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck11_mashmalovsky_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-01",10),
                "PostZendikarRising",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck12_MZBlazer_HeliodCombo_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-01",11),
                "PostZendikarRising",
                ArchetypeColor.WG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck13_MaxCapone_Belcher_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-01",12),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "Belcher",
                null,
                null
            );
        }

        [Test]
        public void Deck14_OderusUrungus_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-01",13),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }


    }
}
