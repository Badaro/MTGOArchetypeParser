using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 ArchaeusDota: Green Tron (G, Jegantha)
#02 Patxi: Rakdos Prowess (BR, Lurrus)
#03 WhiTe TsaR: Miracles (WU, Kaheera)
#04 Toastxp: Jund Prowess (BRG, Lurrus)
#05 PredatorStyle: Bogles (WUG, Lurrus)
#06 Smok1ngBUDS: Rakdos Prowess (BR, Lurrus)
#07 Sanchez5272: Eldrazi Tron (C)
#08 B1gDan: Jund Shadow (BRG, Lurrus)
#09 AndyAWKWARD: Scapeshift (WURG, Yorion)
#10 Sideshowsc: Devoted (WG, Lurrus)
#11 GR_DONKIN: Ad Nauseam (WUB)
#12 RNGspecialist: Scapeshift (WURG, Yorion)
#13 sneaky robot: Infect (WG, Lurrus)
#14 bolov0: Rakdos Prowess (BR, Lurrus)
#15 themightylinguine: Rakdos Prowess (BR, Lurrus)
#16 3minem: Rakdos Prowess (BR, Lurrus)
#17 TheTunnelingCat: Eldrazi Tron (C)
#18 SknerusMcKwacz: Bogles (WG)
#19 maxxattack: Ad Nauseam (WUB)
#20 xfile: Jund Prowess (BRG, Lurrus)
#21 TwistedWombat: Niv To Light (WUBRG, Jegantha)
#22 coicoi91: Eldrazi Tron (C)
#23 eragon777: Boros Prowess (WR, Lurrus)
#24 Boin: Golgari Midrange (BG, Lurrus)
#25 MadMaxErnst: Rakdos Prowess (BR, Lurrus)
#26 DreamsOfAshiok: Eldrazi Tron (C)
#27 MatiCheto: Niv To Light (WUBRG, Jegantha)
#28 SnuffyTheFluffy: Dimir Control (UB, Lurrus)
#29 bobjackson: Bogles (WG, Lurrus)
#30 staples87: Eldrazi Tron (C)
#31 forenmagra: Saheeli Combo (WUBRG, Yorion)
#32 Alvas: Rakdos Prowess (BR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_super_qualifier_2020_05_26 : EventTest
    {
        [Test]
        public void Deck01_ArchaeusDota_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",0),
                "PostIkoria",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck02_Patxi_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",1),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_WhiTeTsaR_Miracles_WU_Kaheera()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",2),
                "PostIkoria",
                ArchetypeColor.WU,
                "Miracles",
                null,
                ArchetypeCompanion.Kaheera
            );
        }

        [Test]
        public void Deck04_Toastxp_JundProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",3),
                "PostIkoria",
                ArchetypeColor.BRG,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_PredatorStyle_Bogles_WUG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",4),
                "PostIkoria",
                ArchetypeColor.WUG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_Smok1ngBUDS_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",5),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Sanchez5272_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",6),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck08_B1gDan_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",7),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_AndyAWKWARD_Scapeshift_WURG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",8),
                "PostIkoria",
                ArchetypeColor.WURG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck10_Sideshowsc_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",9),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_GRDONKIN_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",10),
                "PostIkoria",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck12_RNGspecialist_Scapeshift_WURG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",11),
                "PostIkoria",
                ArchetypeColor.WURG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck13_sneakyrobot_Infect_WG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",12),
                "PostIkoria",
                ArchetypeColor.WG,
                "Infect",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_bolov0_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",13),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_themightylinguine_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",14),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_3minem_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",15),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_TheTunnelingCat_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",16),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck18_SknerusMcKwacz_Bogles_WG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",17),
                "PostIkoria",
                ArchetypeColor.WG,
                "Bogles",
                null,
                null
            );
        }

        [Test]
        public void Deck19_maxxattack_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",18),
                "PostIkoria",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck20_xfile_JundProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",19),
                "PostIkoria",
                ArchetypeColor.BRG,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_TwistedWombat_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",20),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck22_coicoi91_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",21),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck23_eragon777_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",22),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_Boin_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",23),
                "PostIkoria",
                ArchetypeColor.BG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_MadMaxErnst_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",24),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",25),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck27_MatiCheto_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",26),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck28_SnuffyTheFluffy_DimirControl_UB_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",27),
                "PostIkoria",
                ArchetypeColor.UB,
                "GenericControl",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck29_bobjackson_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",28),
                "PostIkoria",
                ArchetypeColor.WG,
                "Bogles",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_staples87_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",29),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck31_forenmagra_SaheeliCombo_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",30),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "SaheeliCombo",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck32_Alvas_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-05-26",31),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
