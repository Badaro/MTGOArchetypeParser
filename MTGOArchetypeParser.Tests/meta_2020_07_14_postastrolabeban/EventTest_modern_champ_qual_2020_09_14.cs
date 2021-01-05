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
#01 bomberboss: Humans (WUBRG)
#02 billsive: Temur Control (URG)
#03 Ivc: Azorius Control (WU)
#04 Sharkcaster_Mage: Reclaimer Titan (WRG)
#05 3HaLeX1: E Tron (C)
#06 Gerschi: Sultai Control (UBG)
#07 Daking3603: Reclaimer Titan (WRG)
#08 Violent_Outburst: Scapeshift (URG)
#09 Venom1: Ad Nauseam (WUB)
#10 Zar0s: Reclaimer Titan (WG)
#11 otakkun: KGC Tron (G)
#12 Janh: Sultai Control (UBG)
#13 johnsmith3373: Izzet Prowess (UR)
#14 Patxi: Rakdos Prowess (BR, Lurrus)
#15 gove1931: Bant Control (WUG)
#16 CavalloGoloso: Azorius Control (WU)
#17 HamburgerJung: Golos Tron (G, Jegantha)
#18 HotBread: Izzet Prowess (UR)
#19 AJOCHUM: Temur Control (URG)
#20 oskiyaa: Obosh Aggro (R, Obosh)
#21 Colossum: KGC Tron (G)
#22 patheus_84: Ad Nauseam (WUB)
#23 canepis16: Rakdos Prowess (BR, Lurrus)
#24 ShowTime_: Burn (WR, Lurrus)
#25 junghans: Devoted (WG)
#26 Mateusf34: E Tron (C)
#27 Kuhb: Devoted (WG, Lurrus)
#28 MoxSquirrel: Rakdos Prowess (BR, Lurrus)
#29 aspiringspike: Azorius Control (WU)
#30 ht991122: Temur Control (URG)
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
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck02_billsive_TemurControl_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",1),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Ivc_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_SharkcasterMage_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck05_3HaLeX1_ETron_C()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",4),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck06_Gerschi_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",5),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Daking3603_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck08_ViolentOutburst_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",7),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Venom1_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Zar0s_ReclaimerTitan_WG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck11_otakkun_KGCTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",10),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck12_Janh_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",11),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_johnsmith3373_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Patxi_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",13),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_gove1931_BantControl_WUG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_CavalloGoloso_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",15),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_HamburgerJung_GolosTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",16),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck18_HotBread_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",17),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck19_AJOCHUM_TemurControl_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",18),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_oskiyaa_OboshAggro_R_Obosh()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",19),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(OboshAggro),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck21_Colossum_KGCTron_G()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",20),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck22_patheus84_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",21),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck23_canepis16_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",22),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_ShowTime_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",23),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_junghans_Devoted_WG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",24),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Mateusf34_ETron_C()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",25),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck27_Kuhb_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",26),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_MoxSquirrel_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",27),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_aspiringspike_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",28),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck30_ht991122_TemurControl_URG()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",29),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Kurusu_KikiChord_WRG_Yorion()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",30),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck32_SakeIzumo_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-champ-qual-2020-09-14",31),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }


    }
}
