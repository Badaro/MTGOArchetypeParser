using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 SoulStrong: UBRG Shadow (UBRG)
#02 __BMJ__: Urza Oko (UBG)
#03 Cherryxman: Urza Oko (WUG)
#04 Phill_Hellmuth: Primeval Titan (UG)
#05 Mulldrifter: Eldrazi Tron (C)
#06 Volollo: Urza Oko (UBG)
#07 heqingbai2019: Titan Shift (RG)
#08 FakiVll: Jund Midrange (BRG)
#09 manunitedfanz15: Urza Oko (WUG)
#10 kasa: Amulet Titan (UG)
#11 PRGJJAR: Dredge (BRG)
#12 lSoLlAKirA: Thopter Urza (WUBRG)
#13 Violent_Outburst: Dredge (BRG)
#14 azatoyellow: Temur Control (URG)
#15 FANAttIC: Merfolk (UG)
#16 Do0mSwitch: Bant Control (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2019_12_25 : EventTest
    {
        [Test]
        public void Deck01_SoulStrong_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",0),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck02_BMJ_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",1),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Cherryxman_UrzaOko_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",2),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck04_PhillHellmuth_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",3),
                "LastOkoDays",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Mulldrifter_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",4),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck06_Volollo_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",5),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck07_heqingbai2019_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",6),
                "LastOkoDays",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck08_FakiVll_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",7),
                "LastOkoDays",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_manunitedfanz15_UrzaOko_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",8),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck10_kasa_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",9),
                "LastOkoDays",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck11_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",10),
                "LastOkoDays",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck12_lSoLlAKirA_ThopterUrza_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",11),
                "LastOkoDays",
                ArchetypeColor.WUBRG,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck13_ViolentOutburst_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",12),
                "LastOkoDays",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck14_azatoyellow_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",13),
                "LastOkoDays",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck15_FANAttIC_Merfolk_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",14),
                "LastOkoDays",
                ArchetypeColor.UG,
                "Merfolk",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Do0mSwitch_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",15),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
