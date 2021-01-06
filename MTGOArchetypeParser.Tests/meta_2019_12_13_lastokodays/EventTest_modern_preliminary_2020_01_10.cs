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
#01 Toastxp: Temur Prowess (URG)
#02 122pablo: Ascendancy Combo (WURG)
#03 Zacherry124: Bant Midrange (WUG)
#04 _Shatun_: Mono Red Prowess (R)
#05 fradev1988: Electro Balance (UR)
#06 yamakiller: Eldrazi Tron (C)
#07 uwata: Ad Nauseam (WUB)
#08 qbturtle15: Jund Midrange (BRG)
#09 Ivan_Catanduva_Br: Bant Midrange (WUG)
#10 karatedom: Simic Prowess (UG)
#11 Butakov: Eldrazi Tron (C)
#12 armstrong36: Sun And Moon (WR)
#13 Nammersquats: Simic Control (UG)
#14 Albimtg: Sultai Shadow (UBG)
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
        public void Deck01_Toastxp_TemurProwess_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",0),
                new LastOkoDays(),
                ArchetypeColor.URG,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck02_122pablo_AscendancyCombo_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",1),
                new LastOkoDays(),
                ArchetypeColor.WURG,
                typeof(AscendancyCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Zacherry124_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",2),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Shatun_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",3),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck05_fradev1988_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",4),
                new LastOkoDays(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck06_yamakiller_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",5),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck07_uwata_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",6),
                new LastOkoDays(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck08_qbturtle15_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",7),
                new LastOkoDays(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_IvanCatanduvaBr_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",8),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_karatedom_SimicProwess_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",9),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Butakov_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",10),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck12_armstrong36_SunAndMoon_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",11),
                new LastOkoDays(),
                ArchetypeColor.WR,
                typeof(SunAndMoon),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Nammersquats_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",12),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Albimtg_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",13),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Moyashi01_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",14),
                new LastOkoDays(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck16_TombSimon_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",15),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck17_tangrams_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",16),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck18_plasticman_Bogles_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",17),
                new LastOkoDays(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Rukzah_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",18),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck20_Antarctica_Spirits_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",19),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Kazuga_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-10",20),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }


    }
}
