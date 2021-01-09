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
#01 Shadowz2005: Mono Red Prowess (R)
#02 Icteridae: Eldrazi Tron (G)
#03 Zacherry124: Temur Prowess (URG)
#04 NuBlkAu: Eldrazi Tron (C)
#05 Sideshowsc: Scapeshift (WURG)
#06 yamakiller: Eldrazi Tron (C)
#07 SourceOdin: Simic Control (UG)
#08 Oderus Urungus: Sultai Prowess (UBG)
#09 gyyby297: Thopter Urza (UG)
#10 dillyg10: Bant Midrange (WUG)
#11 SoulStrong: Simic Control (UG)
#12 TaylorSpain: Simic Control (UG)
#13 __matsugan: Neobrand (UG)
#14 Kev_1414: Sultai Control (UBG)
#15 Manofbone: Gifts Storm (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2020_01_11 : EventTest
    {
        [Test]
        public void Deck01_Shadowz2005_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",0),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Icteridae_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",1),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck03_Zacherry124_TemurProwess_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",2),
                new LastOkoDays(),
                ArchetypeColor.URG,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck04_NuBlkAu_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",3),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck05_Sideshowsc_Scapeshift_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",4),
                new LastOkoDays(),
                ArchetypeColor.WURG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck06_yamakiller_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",5),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck07_SourceOdin_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",6),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_OderusUrungus_SultaiProwess_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",7),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck09_gyyby297_ThopterUrza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",8),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck10_dillyg10_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",9),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck11_SoulStrong_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",10),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_TaylorSpain_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",11),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",12),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Kev1414_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",13),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Manofbone_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",14),
                new LastOkoDays(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }


    }
}
