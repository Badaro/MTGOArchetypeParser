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
#01 achillies27: Gifts Storm (UR)
#02 PuntThenWhine: Amulet Titan (G)
#03 gazmon48: Green Tron (G)
#04 Leviathan102: Reclaimer Titan (WRG)
#05 yamakiller: Mill (UB, Lurrus)
#06 ArchaeusDota: Green Tron (G)
#07 Samlg01: Amulet Titan (G)
#08 lordavery: Bant Midrange (WUG)
#09 The_nayr: Obosh Aggro (R, Obosh)
#10 reiderrabbit: Shadow Prowess (BRG, Lurrus)
#11 Pupsta: Obosh Aggro (R, Obosh)
#12 medvedev: Reclaimer Titan (WRG)
#13 Sharkcaster_Mage: Reclaimer Titan (WRG)
#14 wambocombo2020: Temur Control (URG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2020_12_08 : EventTest
    {
        [Test]
        public void Deck01_achillies27_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-08",0),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck02_PuntThenWhine_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-08",1),
                "PostZendikarRising",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck03_gazmon48_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-08",2),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck04_Leviathan102_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-08",3),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck05_yamakiller_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-08",4),
                "PostZendikarRising",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_ArchaeusDota_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-08",5),
                "PostZendikarRising",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck07_Samlg01_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-08",6),
                "PostZendikarRising",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck08_lordavery_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-08",7),
                "PostZendikarRising",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Thenayr_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-08",8),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck10_reiderrabbit_ShadowProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-08",9),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                "ShadowProwess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_Pupsta_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-08",10),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck12_medvedev_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-08",11),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck13_SharkcasterMage_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-08",12),
                "PostZendikarRising",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck14_wambocombo2020_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-12-08",13),
                "PostZendikarRising",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
