using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Kofurea: Amulet Titan (UG)
#02 otakkun: Green Tron (G)
#03 gyyby297: Thopter Urza (UB)
#04 siomomi: Green Tron (G)
#05 _INF_: Gifts Storm (UR)
#06 Wolfie98: Temur Control (URG)
#07 JV_7777: Humans (WUBRG)
#08 Archgaze: Winota (WRG)
#09 cjucjujp: Bushwhacker Zoo (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_25_postm21
{
    public class EventTest_modern_preliminary_2020_06_27 : EventTest
    {
        [Test]
        public void Deck01_Kofurea_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-27",0),
                "PostM21",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck02_otakkun_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-27",1),
                "PostM21",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck03_gyyby297_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-27",2),
                "PostM21",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck04_siomomi_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-27",3),
                "PostM21",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck05_INF_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-27",4),
                "PostM21",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Wolfie98_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-27",5),
                "PostM21",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_JV7777_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-27",6),
                "PostM21",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Archgaze_Winota_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-27",7),
                "PostM21",
                ArchetypeColor.WRG,
                "Winota",
                null,
                null
            );
        }

        [Test]
        public void Deck09_cjucjujp_BushwhackerZoo_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-27",8),
                "PostM21",
                ArchetypeColor.RG,
                "BushwhackerZoo",
                null,
                null
            );
        }


    }
}
