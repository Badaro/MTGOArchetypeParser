using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 aooaaooa: Lantern (WUBRG)
#02 NightKnight131: Devoted (WG, Lurrus)
#03 MadCowChicken: Green Eldrazi (WG, Jegantha)
#04 Frank_Bonaparte: Gruul Midrange (RG)
#05 Papelucho10: Infect (UG)
#06 Mcleskey: Burn (WR)
#07 Boland: Dredge (BRG)
#08 ghostx02: Gruul Midrange (RG)
#09 FrancusAurelius: Naya Midrange (WRG)
#10 otakkun: Green Tron (G)
#11 _Logic_: Rakdos Shadow (BR)
#12 2radMTG: Bogles (WG, Lurrus)
#13 lovealienzzz: Temur Control (URG)
#14 Manacymbal: Kinnan Legends (URG, Yorion)
#15 signblindman: Gruul Midrange (RG)
#16 Nammersquats: Humans (WUBRG)
#17 Micro: Ad Nauseam (WUB)
#18 joetru: Niv To Light (WUBRG)
#19 grahams: Mill (UB)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_preliminary_2020_06_20 : EventTest
    {
        [Test]
        public void Deck01_aooaaooa_Lantern_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",0),
                "PostCompanionChange",
                ArchetypeColor.WUBRG,
                "ThopterCombo",
                "Lantern",
                null
            );
        }

        [Test]
        public void Deck02_NightKnight131_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",1),
                "PostCompanionChange",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_MadCowChicken_GreenEldrazi_WG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",2),
                "PostCompanionChange",
                ArchetypeColor.WG,
                "GreenEldrazi",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck04_FrankBonaparte_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",3),
                "PostCompanionChange",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Papelucho10_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",4),
                "PostCompanionChange",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Mcleskey_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",5),
                "PostCompanionChange",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck07_Boland_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",6),
                "PostCompanionChange",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck08_ghostx02_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",7),
                "PostCompanionChange",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_FrancusAurelius_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",8),
                "PostCompanionChange",
                ArchetypeColor.WRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck10_otakkun_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",9),
                "PostCompanionChange",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck11_Logic_RakdosShadow_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",10),
                "PostCompanionChange",
                ArchetypeColor.BR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck12_2radMTG_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",11),
                "PostCompanionChange",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_lovealienzzz_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",12),
                "PostCompanionChange",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Manacymbal_KinnanLegends_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",13),
                "PostCompanionChange",
                ArchetypeColor.URG,
                "KinnanLegends",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck15_signblindman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",14),
                "PostCompanionChange",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Nammersquats_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",15),
                "PostCompanionChange",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck17_Micro_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",16),
                "PostCompanionChange",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck18_joetru_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",17),
                "PostCompanionChange",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck19_grahams_Mill_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",18),
                "PostCompanionChange",
                ArchetypeColor.UB,
                "Mill",
                null,
                null
            );
        }


    }
}
