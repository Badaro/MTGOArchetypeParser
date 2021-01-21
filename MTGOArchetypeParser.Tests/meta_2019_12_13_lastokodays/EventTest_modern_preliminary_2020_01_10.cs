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
#01 Toastxp: Urza Oko (URG)
#02 122pablo: Ascendancy Combo (WURG)
#03 Zacherry124: Bant Midrange (WUG)
#04 _Shatun_: Mono Red Prowess (R)
#05 fradev1988: Electro Balance (UR)
#06 yamakiller: Eldrazi Tron (G)
#07 uwata: Ad Nauseam (WUB)
#08 qbturtle15: Jund Midrange (BRG)
#09 Ivan_Catanduva_Br: Bant Midrange (WUG)
#10 karatedom: Urza Oko (UBG)
#11 Butakov: Eldrazi Tron (C)
#12 armstrong36: Sun And Moon (WR)
#13 Nammersquats: Urza Oko (UG)
#14 Albimtg: UBRG Shadow (UBRG)
#15 Moyashi01: Grixis Shadow (UBR)
#16 TombSimon: Mono Red Prowess (R)
#17 tangrams: Eldrazi Tron (G)
#18 plasticman: Bogles (WG)
#19 Rukzah: Amulet Titan (UG)
#20 Antarctica: Spirits (WUG)
#21 Kazuga: Mono Red Prowess (R)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2020_01_10 : EventTest
    {
        [Test]
        public void Deck01_Toastxp_UrzaOko_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",0),
                "LastOkoDays",
                ArchetypeColor.URG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck02_122pablo_AscendancyCombo_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",1),
                "LastOkoDays",
                ArchetypeColor.WURG,
                "AscendancyCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Zacherry124_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",2),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Shatun_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",3),
                "LastOkoDays",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck05_fradev1988_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",4),
                "LastOkoDays",
                ArchetypeColor.UR,
                "FreeSpells",
                "ElectroBalance",
                null
            );
        }

        [Test]
        public void Deck06_yamakiller_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",5),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck07_uwata_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",6),
                "LastOkoDays",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck08_qbturtle15_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",7),
                "LastOkoDays",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_IvanCatanduvaBr_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",8),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck10_karatedom_UrzaOko_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",9),
                "LastOkoDays",
                ArchetypeColor.UBG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Butakov_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",10),
                "LastOkoDays",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck12_armstrong36_SunAndMoon_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",11),
                "LastOkoDays",
                ArchetypeColor.WR,
                "SunAndMoon",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Nammersquats_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",12),
                "LastOkoDays",
                ArchetypeColor.UG,
                "UrzaOko",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Albimtg_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",13),
                "LastOkoDays",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Moyashi01_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",14),
                "LastOkoDays",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck16_TombSimon_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",15),
                "LastOkoDays",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck17_tangrams_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",16),
                "LastOkoDays",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck18_plasticman_Bogles_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",17),
                "LastOkoDays",
                ArchetypeColor.WG,
                "Bogles",
                null,
                null
            );
        }

        [Test]
        public void Deck19_Rukzah_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",18),
                "LastOkoDays",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck20_Antarctica_Spirits_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",19),
                "LastOkoDays",
                ArchetypeColor.WUG,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck21_Kazuga_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",20),
                "LastOkoDays",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }


    }
}
