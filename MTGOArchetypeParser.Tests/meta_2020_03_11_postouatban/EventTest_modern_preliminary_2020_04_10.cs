using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Pistone11: Gifts Storm (UR)
#02 pepeisra: Green Tron (G)
#03 ForThoseWhoHaveHeart: Dredge (BRG)
#04 jorgefpcardoso: Mardu Midrange (WBR)
#05 Wuby123: Burn (WR)
#06 SoIMBA_Airwave: Green Eldrazi (RG)
#07 penips: Mono White Taxes (W)
#08 Ivc: Bant Control (WUG)
#09 dwnb: Ad Nauseam (WUB)
#10 David1987: Niv To Light (WUBRG)
#11 coert: Burn (WR)
#12 JustBurn420: Slivers (WUBRG)
#13 zMunkeyXz: Mill (UBG)
#14 in5ano: Thopter Urza (WUR)
#15 Kazuga: Green Tron (G)
#16 Janh: Saheeli Combo (WUR)
#17 Miqa: Eldrazi Tron (C)
#18 jvidarte: Burn (WR)
#19 Trid0n: Humans (WUBRG)
#20 sydneydude: Temur Control (URG)
#21 Freefallingg: Gruul Midrange (RG)
#22 Masumaro: Temur Midrange (URG)
#23 Krandoy: Burn (WR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_04_10 : EventTest
    {
        [Test]
        public void Deck01_Pistone11_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",0),
                "PostOuatBan",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck02_pepeisra_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",1),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck03_ForThoseWhoHaveHeart_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",2),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck04_jorgefpcardoso_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",3),
                "PostOuatBan",
                ArchetypeColor.WBR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Wuby123_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",4),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck06_SoIMBAAirwave_GreenEldrazi_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",5),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GreenEldrazi",
                null,
                null
            );
        }

        [Test]
        public void Deck07_penips_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",6),
                "PostOuatBan",
                ArchetypeColor.W,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Ivc_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",7),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck09_dwnb_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",8),
                "PostOuatBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck10_David1987_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",9),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck11_coert_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",10),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck12_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",11),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Slivers",
                null,
                null
            );
        }

        [Test]
        public void Deck13_zMunkeyXz_Mill_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",12),
                "PostOuatBan",
                ArchetypeColor.UBG,
                "Mill",
                null,
                null
            );
        }

        [Test]
        public void Deck14_in5ano_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",13),
                "PostOuatBan",
                ArchetypeColor.WUR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck15_Kazuga_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",14),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck16_Janh_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",15),
                "PostOuatBan",
                ArchetypeColor.WUR,
                "SaheeliCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck17_Miqa_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",16),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck18_jvidarte_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",17),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck19_Trid0n_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",18),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck20_sydneydude_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",19),
                "PostOuatBan",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck21_Freefallingg_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",20),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Masumaro_TemurMidrange_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",21),
                "PostOuatBan",
                ArchetypeColor.URG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Krandoy_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",22),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }


    }
}
