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
#01 maxxattack: Infect (UG)
#02 Epachniak: Mono Red Prowess (R)
#03 WorstNewbEver: Amulet Titan (UG)
#04 benchsummer: UBRG Shadow (UBRG)
#05 nahuel10: Burn (WR)
#06 Nammersquats: Humans (WUBRG)
#07 yamakiller: Eldrazi Tron (C)
#08 SourceOdin: Urza Oko (WUG)
#09 thugnificent32: Amulet Titan (UG)
#10 quinniac: Burn (WRG)
#11 rileydk: Amulet Titan (UG)
#12 Theo_Jung: Eldrazi Tron (C)
#13 koko_lopez: UBRG Shadow (UBRG)
#14 MLupa: Gifts Storm (URG)
#15 SoulStrong: UBRG Shadow (UBRG)
#16 azax: UBRG Shadow (UBRG)
#17 Xwhale: Eldrazi Tron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2019_12_16 : EventTest
    {
        [Test]
        public void Deck01_maxxattack_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-16",0),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Epachniak_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-16",1),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck03_WorstNewbEver_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-16",2),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck04_benchsummer_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-16",3),
                new LastOkoDays(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck05_nahuel10_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-16",4),
                new LastOkoDays(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck06_Nammersquats_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-16",5),
                new LastOkoDays(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck07_yamakiller_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-16",6),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck08_SourceOdin_UrzaOko_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-16",7),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck09_thugnificent32_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-16",8),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck10_quinniac_Burn_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-16",9),
                new LastOkoDays(),
                ArchetypeColor.WRG,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck11_rileydk_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-16",10),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck12_TheoJung_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-16",11),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck13_kokolopez_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-16",12),
                new LastOkoDays(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck14_MLupa_GiftsStorm_URG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-16",13),
                new LastOkoDays(),
                ArchetypeColor.URG,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck15_SoulStrong_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-16",14),
                new LastOkoDays(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck16_azax_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-16",15),
                new LastOkoDays(),
                ArchetypeColor.UBRG,
                typeof(Shadow),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Xwhale_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-16",16),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }


    }
}
