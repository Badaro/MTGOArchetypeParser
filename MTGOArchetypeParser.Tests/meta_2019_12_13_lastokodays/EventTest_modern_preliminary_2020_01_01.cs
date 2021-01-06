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
#01 Physicaltuna: Grixis Shadow (UBR)
#02 Tyerube1618: Green Tron (G)
#03 kanister: Simic Control (UG)
#04 Toastxp: Simic Control (UG)
#05 __matsugan: Neobrand (UG)
#06 indomie: Simic Control (UG)
#07 hourai_tokido: Grixis Shadow (UBR)
#08 r453r: Sultai Midrange (UBG)
#09 SoulStrong: Simic Control (UG)
#10 PieGonti: WUBG Prowess (WUBG)
#11 Phill_Hellmuth: Primeval Titan (UG)
#12 122pablo: Ascendancy Combo (WURG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2020_01_01 : EventTest
    {
        [Test]
        public void Deck01_Physicaltuna_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-01",0),
                new LastOkoDays(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Tyerube1618_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-01",1),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck03_kanister_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-01",2),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Toastxp_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-01",3),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-01",4),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck06_indomie_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-01",5),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_houraitokido_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-01",6),
                new LastOkoDays(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck08_r453r_SultaiMidrange_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-01",7),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_SoulStrong_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-01",8),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_PieGonti_WUBGProwess_WUBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-01",9),
                new LastOkoDays(),
                ArchetypeColor.WUBG,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck11_PhillHellmuth_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-01",10),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck12_122pablo_AscendancyCombo_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-01",11),
                new LastOkoDays(),
                ArchetypeColor.WURG,
                typeof(AscendancyCombo),
                null,
                null
            );
        }


    }
}
