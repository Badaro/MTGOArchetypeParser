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
#01 SoulStrong: Sultai Shadow (UBG)
#02 __BMJ__: Sultai Control (UBG)
#03 Cherryxman: Simic Control (UG)
#04 Phill_Hellmuth: Primeval Titan (UG)
#05 Mulldrifter: Eldrazi Tron (C)
#06 Volollo: Simic Control (UG)
#07 heqingbai2019: Titan Shift (RG)
#08 FakiVll: Jund Midrange (BRG)
#09 manunitedfanz15: Simic Control (UG)
#10 kasa: Amulet Titan (UG)
#11 PRGJJAR: Dredge (BRG)
#12 lSoLlAKirA: Thopter Urza (WUBRG)
#13 Violent_Outburst: Dredge (RG)
#14 azatoyellow: Temur Control (URG)
#15 FANAttIC: Merfolk (UG)
#16 Do0mSwitch: Bant Control (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_03_lastokodays
{
    public class EventTest_modern_preliminary_2019_12_25 : EventTest
    {
        [Test]
        public void Deck01_SoulStrong_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",0),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck02_BMJ_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",1),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Cherryxman_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",2),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_PhillHellmuth_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",3),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Mulldrifter_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",4),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck06_Volollo_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",5),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_heqingbai2019_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",6),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck08_FakiVll_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",7),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_manunitedfanz15_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",8),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_kasa_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",9),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck11_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",10),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck12_lSoLlAKirA_ThopterUrza_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",11),
                new LastOkoDays(),
                ArchetypeColor.WUBRG,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck13_ViolentOutburst_Dredge_RG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",12),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck14_azatoyellow_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",13),
                new LastOkoDays(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_FANAttIC_Merfolk_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",14),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Do0mSwitch_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-25",15),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
