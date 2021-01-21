using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 bomberboss: Humans (WUBRG)
#02 billsive: Temur Control (URG)
#03 Ivc: Azorius Control (WU)
#04 Sharkcaster_Mage: Reclaimer Titan (WRG)
#05 3HaLeX1: Eldrazi Tron (C)
#06 Gerschi: Sultai Control (UBG)
#07 Daking3603: Reclaimer Titan (WRG)
#08 Violent_Outburst: Scapeshift (URG)
#09 Venom1: Ad Nauseam (WUB)
#10 Zar0s: Reclaimer Titan (WG)
#11 otakkun: Green Tron (G)
#12 Janh: Sultai Control (UBG)
#13 johnsmith3373: Izzet Prowess (UR)
#14 Patxi: Rakdos Prowess (BR, Lurrus)
#15 gove1931: Bant Control (WUG)
#16 CavalloGoloso: Azorius Control (WU)
#17 HamburgerJung: Green Tron (G, Jegantha)
#18 HotBread: Izzet Prowess (UR)
#19 AJOCHUM: Temur Control (URG)
#20 oskiyaa: Obosh Aggro (R, Obosh)
#21 Colossum: Green Tron (G)
#22 patheus_84: Ad Nauseam (WUB)
#23 canepis16: Rakdos Prowess (BR, Lurrus)
#24 ShowTime_: Burn (WR, Lurrus)
#25 junghans: Devoted (WRG)
#26 Mateusf34: Eldrazi Tron (C)
#27 Kuhb: Devoted (WG, Lurrus)
#28 MoxSquirrel: Rakdos Prowess (BR, Lurrus)
#29 aspiringspike: Azorius Control (WU)
#30 ht991122: Reclamation (URG)
#31 Kurusu: Kiki Chord (WRG, Yorion)
#32 SakeIzumo: Izzet Prowess (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_champ_qual_2020_09_14 : EventTest
    {
        [Test]
        public void Deck01_bomberboss_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",0),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck02_billsive_TemurControl_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",1),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Ivc_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",2),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_SharkcasterMage_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",3),
                "PostAstrolabeBan",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck05_3HaLeX1_EldraziTron_C()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",4),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck06_Gerschi_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",5),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Daking3603_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",6),
                "PostAstrolabeBan",
                ArchetypeColor.WRG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck08_ViolentOutburst_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",7),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Venom1_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",8),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Zar0s_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",9),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "PrimevalTitan",
                "ReclaimerTitan",
                null
            );
        }

        [Test]
        public void Deck11_otakkun_GreenTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",10),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck12_Janh_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",11),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck13_johnsmith3373_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",12),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck14_Patxi_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",13),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_gove1931_BantControl_WUG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",14),
                "PostAstrolabeBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck16_CavalloGoloso_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",15),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck17_HamburgerJung_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",16),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck18_HotBread_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",17),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck19_AJOCHUM_TemurControl_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",18),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck20_oskiyaa_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",19),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "OboshAggro",
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck21_Colossum_GreenTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",20),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck22_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",21),
                "PostAstrolabeBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck23_canepis16_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",22),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_ShowTime_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",23),
                "PostAstrolabeBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_junghans_Devoted_WRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",24),
                "PostAstrolabeBan",
                ArchetypeColor.WRG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck26_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",25),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck27_Kuhb_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",26),
                "PostAstrolabeBan",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_MoxSquirrel_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",27),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_aspiringspike_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",28),
                "PostAstrolabeBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck30_ht991122_Reclamation_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",29),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck31_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",30),
                "PostAstrolabeBan",
                ArchetypeColor.WRG,
                "KikiChord",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck32_SakeIzumo_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",31),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }


    }
}
