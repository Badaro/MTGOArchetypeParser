using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 _Batutinha_: WURG Control (WURG, Yorion)
#02 Lukas261997: UBRG Control (UBRG)
#03 LaCriaturaBB: Sultai Control (UBG)
#04 taruto1212: WURG Control (WURG)
#05 idutra: Jund Midrange (BRG)
#06 _Shatun_: Obosh Aggro (R, Obosh)
#07 BReal2: WURG Control (WURG)
#08 UmekawaneikU: Burn (WR)
#09 Jaberwocki: Jund Shadow (BRG, Lurrus)
#10 medvedev: Spirits (WU)
#11 Rosencrantz_920: Amulet Titan (G)
#12 OkoDio: Rakdos Midrange (BR)
#13 Serguei: Dredge (BRG)
#14 naddyeffintabs: Hammer Time (WR, Lurrus)
#15 WhiTe TsaR: Izzet Prowess (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_preliminary_2021_01_26 : EventTest
    {
        [Test]
        public void Deck01_Batutinha_WURGControl_WURG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-26",0),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_Lukas261997_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-26",1),
                "PostZendikarRising",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_LaCriaturaBB_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-26",2),
                "PostZendikarRising",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_taruto1212_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-26",3),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_idutra_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-26",4),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Shatun_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-26",5),
                "PostZendikarRising",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck07_BReal2_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-26",6),
                "PostZendikarRising",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_UmekawaneikU_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-26",7),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck09_Jaberwocki_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-26",8),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_medvedev_Spirits_WU()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-26",9),
                "PostZendikarRising",
                ArchetypeColor.WU,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Rosencrantz920_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-26",10),
                "PostZendikarRising",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck12_OkoDio_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-26",11),
                "PostZendikarRising",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Serguei_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-26",12),
                "PostZendikarRising",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck14_naddyeffintabs_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-26",13),
                "PostZendikarRising",
                ArchetypeColor.WR,
                "HammerTime",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_WhiTeTsaR_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2021-01-26",14),
                "PostZendikarRising",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }


    }
}
