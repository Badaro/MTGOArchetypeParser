using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 zMagic4ever: Mono Red Prowess (R)
#02 SoulStrong: Thopter Urza (UB)
#03 PRGJJAR: Dredge (BRG)
#04 GedionRavenor: Azorius Control (WU)
#05 llawtonss: Amulet Titan (G)
#06 AlabasterWolfie: Grinding Breach (UBR)
#07 Brunister: Eldrazi Tron (G)
#08 Zonast: Jund Shadow (BRG)
#09 Cherlon: Burn (WR)
#10 MatheusPonciano: Dredge (BRG)
#11 yamakiller: Ad Nauseam (WUB)
#12 D00mwake: Gruul Midrange (RG)
#13 Xwhale: Eldrazi Tron (G)
#14 Zar0s: Amulet Titan (UG)
#15 stonepeanut: Green Tron (G)
#16 bradyoo: Green Tron (G)
#17 Nammersquats: Infect (UG)
#18 NHA37: Heliod Combo (WBG)
#19 Stranger99: Grixis Shadow (UBR)
#20 aedenj: Jund Midrange (BRG)
#21 madechai: Thopter Urza (WU)
#22 Stark607: Jund Midrange (BRG)
#23 3HDgamers: Azorius Control (WU)
#24 2jjm: Mono Red Prowess (R)
#25 sandydogmtg: Burn (R)
#26 1yo2yo: Thopter Urza (UB)
#27 Trieste: Azorius Control (WU)
#28 MATTHEWFOULKES: Mono Red Prowess (R)
#29 Alex_Brown: Green Tron (G)
#30 Benburr: Dredge (BRG)
#31 SourceOdin: Amulet Titan (UG)
#32 max_9: Izzet Control (UR)
#33 Coly2: Heliod Combo (WBG)
#34 vinnyrussian123: Primeval Titan (UG)
#35 MichaelScott: Jund Midrange (BRG)
#36 Boland: Grixis Shadow (UBR)
#37 cityofcards: Rakdos Midrange (BR)
#38 Samwise_GeeGee: Azorius Control (WU)
#39 Bitflipher: UBRG Shadow (UBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_02_18 : EventTest
    {
        [Test]
        public void Deck01_zMagic4ever_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",0),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck02_SoulStrong_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck03_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck04_GedionRavenor_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_llawtonss_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck06_AlabasterWolfie_GrindingBreach_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "GrindingBreach",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Brunister_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck08_Zonast_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Cherlon_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck10_MatheusPonciano_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck11_yamakiller_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck12_D00mwake_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Xwhale_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck14_Zar0s_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",13),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck15_stonepeanut_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",14),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck16_bradyoo_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",15),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck17_Nammersquats_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",16),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck18_NHA37_HeliodCombo_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",17),
                "PostTherosBeyondDeath",
                ArchetypeColor.WBG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck19_Stranger99_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",18),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck20_aedenj_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",19),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck21_madechai_ThopterUrza_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",20),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck22_Stark607_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",21),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck23_3HDgamers_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",22),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck24_2jjm_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",23),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck25_sandydogmtg_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",24),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck26_1yo2yo_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",25),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck27_Trieste_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",26),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck28_MATTHEWFOULKES_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",27),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck29_AlexBrown_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",28),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck30_Benburr_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",29),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck31_SourceOdin_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",30),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck32_max9_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",31),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck33_Coly2_HeliodCombo_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",32),
                "PostTherosBeyondDeath",
                ArchetypeColor.WBG,
                "HeliodCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck34_vinnyrussian123_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",33),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck35_MichaelScott_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",34),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck36_Boland_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",35),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck37_cityofcards_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",36),
                "PostTherosBeyondDeath",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck38_SamwiseGeeGee_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",37),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck39_Bitflipher_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-18",38),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }


    }
}
