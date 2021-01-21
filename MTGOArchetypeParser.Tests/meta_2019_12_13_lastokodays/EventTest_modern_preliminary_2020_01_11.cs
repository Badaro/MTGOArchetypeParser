using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Shadowz2005: Mono Red Prowess (R)
#02 Icteridae: Eldrazi Tron (G)
#03 Zacherry124: Urza Oko (URG)
#04 NuBlkAu: Eldrazi Tron (C)
#05 Sideshowsc: Scapeshift (WURG)
#06 yamakiller: Eldrazi Tron (G)
#07 SourceOdin: Urza Oko (WUG)
#08 Oderus Urungus: Urza Oko (UBG)
#09 gyyby297: Thopter Urza (UBG)
#10 dillyg10: Bant Midrange (WUG)
#11 SoulStrong: Urza Oko (UBG)
#12 TaylorSpain: Urza Oko (WUG)
#13 __matsugan: Neobrand (UG)
#14 Kev_1414: Urza Oko (UBG)
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
                "LastOkoDays",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck02_Icteridae_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",1),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck03_Zacherry124_UrzaOko_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",2),
                "LastOkoDays",
                ArchetypeColor.URG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck04_NuBlkAu_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",3),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck05_Sideshowsc_Scapeshift_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",4),
                "LastOkoDays",
                ArchetypeColor.WURG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck06_yamakiller_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",5),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck07_SourceOdin_UrzaOko_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",6),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck08_OderusUrungus_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",7),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck09_gyyby297_ThopterUrza_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",8),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck10_dillyg10_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",9),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck11_SoulStrong_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",10),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck12_TaylorSpain_UrzaOko_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",11),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck13_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",12),
                "LastOkoDays",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Kev1414_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",13),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Manofbone_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-11",14),
                "LastOkoDays",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }


    }
}
