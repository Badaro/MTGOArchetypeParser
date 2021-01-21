using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 McWinSauce: Bant Control (WUG)
#02 maxxattack: Infect (UG)
#03 Erik157751: Eldrazi Tron (C)
#04 reew2n: Mono Red Prowess (R)
#05 scubypandatv: Amulet Titan (UG)
#06 SoulStrong: UBRG Shadow (UBRG)
#07 MayoDomo: Infect (UG)
#08 SvenSveeterSven: Izzet Control (UR)
#09 koko_lopez: UBRG Shadow (UBRG)
#10 FrancusAurelius: Gruul Midrange (RG)
#11 azax: UBRG Shadow (UBRG)
#12 kanister: Amulet Titan (UG)
#13 Wolvenjoe1984: Thopter Urza (UBG)
#14 raynesobad: Urza Oko (UG)
#15 zachattack23: Urza Oko (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2019_12_21 : EventTest
    {
        [Test]
        public void Deck01_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",0),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_maxxattack_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",1),
                "LastOkoDays",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Erik157751_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",2),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck04_reew2n_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",3),
                "LastOkoDays",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck05_scubypandatv_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",4),
                "LastOkoDays",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck06_SoulStrong_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",5),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck07_MayoDomo_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",6),
                "LastOkoDays",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck08_SvenSveeterSven_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",7),
                "LastOkoDays",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck09_kokolopez_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",8),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck10_FrancusAurelius_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",9),
                "LastOkoDays",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck11_azax_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",10),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck12_kanister_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",11),
                "LastOkoDays",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck13_Wolvenjoe1984_ThopterUrza_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",12),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck14_raynesobad_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",13),
                "LastOkoDays",
                ArchetypeColor.UG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck15_zachattack23_UrzaOko_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",14),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "UrzaOko",
                null,
                null
            );
        }


    }
}
