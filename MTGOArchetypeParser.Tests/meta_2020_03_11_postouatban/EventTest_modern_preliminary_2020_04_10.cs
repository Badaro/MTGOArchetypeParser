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
#01 Pistone11: Gifts Storm (UR)
#02 pepeisra: Green Tron (G)
#03 ForThoseWhoHaveHeart: Dredge (BRG)
#04 jorgefpcardoso: Mardu Midrange (WBR)
#05 Wuby123: Burn (WR)
#06 SoIMBA_Airwave: Obligator Eldrazi (RG)
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
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck02_pepeisra_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",1),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck03_ForThoseWhoHaveHeart_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",2),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck04_jorgefpcardoso_MarduMidrange_WBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",3),
                new PostOuatBan(),
                ArchetypeColor.WBR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Wuby123_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",4),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck06_SoIMBAAirwave_ObligatorEldrazi_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",5),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GreenEldrazi),
                null,
                null
            );
        }

        [Test]
        public void Deck07_penips_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",6),
                new PostOuatBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Ivc_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",7),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_dwnb_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",8),
                new PostOuatBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck10_David1987_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",9),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck11_coert_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",10),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck12_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",11),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck13_zMunkeyXz_Mill_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",12),
                new PostOuatBan(),
                ArchetypeColor.UBG,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck14_in5ano_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",13),
                new PostOuatBan(),
                ArchetypeColor.WUR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck15_Kazuga_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",14),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck16_Janh_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",15),
                new PostOuatBan(),
                ArchetypeColor.WUR,
                typeof(SaheeliCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Miqa_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",16),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck18_jvidarte_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",17),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Trid0n_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",18),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck20_sydneydude_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",19),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Freefallingg_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",20),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Masumaro_TemurMidrange_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",21),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Krandoy_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-10",22),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }


    }
}
