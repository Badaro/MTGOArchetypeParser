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
#01 zMagic4ever: Mono Red Prowess (R)
#02 qbturtle15: Azorius Control (WU)
#03 v3sp_tv: Elementals (WUBRG)
#04 leclairandy: Mono Red Prowess (R)
#05 SourceOdin: Primeval Titan (UG)
#06 YawgmothPT: Humans (WUBRG)
#07 Boland: Grixis Shadow (UBR)
#08 NightShadowJ: Uroza (URG)
#09 bolov0: Titan Shift (RG)
#10 yamakiller: Eldrazi Tron (G)
#11 trammell: Mono Red Prowess (R)
#12 D00mwake: Primeval Titan (UG)
#13 mitchrules25: Burn (WR)
#14 Parrotlet: Devoted (WBG)
#15 NoOuts: Sun And Moon (WR)
#16 McWinSauce: Azorius Control (WU)
#17 sandydogmtg: Burn (R)
#18 Sideshowsc: Scapeshift (WURG)
#19 Cynjii: UBRG Shadow (UBRG)
#20 603Leb: Amulet Titan (URG)
#21 Atticuslol: Titan Shift (RG)
#22 Jiraiax: Grixis Shadow (UBR)
#23 exoticherman: Infect (UG)
#24 SpiderSpace: Thalia Stompy (WR)
#25 bntrusty14: Humans (WUBRG)
#26 SoulStrong: Amulet Titan (UG)
#27 mavzero87: Eldrazi Tron (C)
#28 RUD: Mono Red Prowess (R)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_01_21 : EventTest
    {
        [Test]
        public void Deck01_zMagic4ever_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",0),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck02_qbturtle15_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_v3sptv_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUBRG,
                "Elementals",
                null,
                null
            );
        }

        [Test]
        public void Deck04_leclairandy_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck05_SourceOdin_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck06_YawgmothPT_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Boland_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck08_NightShadowJ_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck09_bolov0_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck10_yamakiller_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck11_trammell_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck12_D00mwake_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck13_mitchrules25_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck14_Parrotlet_Devoted_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",13),
                "PostTherosBeyondDeath",
                ArchetypeColor.WBG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck15_NoOuts_SunAndMoon_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",14),
                "PostTherosBeyondDeath",
                ArchetypeColor.WR,
                "SunAndMoon",
                null,
                null
            );
        }

        [Test]
        public void Deck16_McWinSauce_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",15),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck17_sandydogmtg_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",16),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck18_Sideshowsc_Scapeshift_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",17),
                "PostTherosBeyondDeath",
                ArchetypeColor.WURG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck19_Cynjii_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",18),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck20_603Leb_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",19),
                "PostTherosBeyondDeath",
                ArchetypeColor.URG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck21_Atticuslol_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",20),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "PrimevalTitan",
                "TitanShift",
                null
            );
        }

        [Test]
        public void Deck22_Jiraiax_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",21),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck23_exoticherman_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",22),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck24_SpiderSpace_ThaliaStompy_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",23),
                "PostTherosBeyondDeath",
                ArchetypeColor.WR,
                "ThaliaStompy",
                null,
                null
            );
        }

        [Test]
        public void Deck25_bntrusty14_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",24),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck26_SoulStrong_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",25),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck27_mavzero87_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",26),
                "PostTherosBeyondDeath",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck28_RUD_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-21",27),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }


    }
}
