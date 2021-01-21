using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 McWinSauce: WURG Control (WURG)
#02 WingedHussar: Neobrand (UG)
#03 Mzfroste: Amulet Titan (UG)
#04 Papelucho10: Infect (UG)
#05 coert: Devoted (WBG)
#06 FalseMufn: Amulet Titan (UG)
#07 yamakiller: Eldrazi Tron (G)
#08 hcook725: Thopter Urza (UB)
#09 Finalnub: Eldrazi Tron (G)
#10 thepensword: Izzet Control (UR)
#11 Lord_Beerus: Burn (WR)
#12 i_b_TRUE: Jund Midrange (BRG)
#13 Saviall: Green Tron (G)
#14 bobthedog: Bant Blink (WUG)
#15 _LSN_: Burn (WR)
#16 MichaelScott: Jund Shadow (BRG)
#17 maxxattack: Infect (UG)
#18 damatoexp: Gifts Storm (URG)
#19 mac121711: Sultai Control (UBG)
#20 qbturtle15: Azorius Control (WU)
#21 Scooter8968: Jund Midrange (BRG)
#22 Hazzrd: Azorius Control (WU)
#23 uaedoliB: Amulet Titan (UG)
#24 in5ano: Thopter Urza (UBR)
#25 vini_torres: Gifts Storm (UR)
#26 vinnyrussian123: Primeval Titan (UG)
#27 offline: Thopter Urza (UB)
#28 PTarts2win: Mono Red Prowess (R)
#29 Amayesing83: Abzan Midrange (WBG)
#30 coolperson63: Infect (UG)
#31 ElevatahPartay: Azorius Control (WU)
#32 BrandanMya: Izzet Control (UR)
#33 The_NotSure: Infect (UG)
#34 Xwhale: Primeval Titan (BG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_02_25 : EventTest
    {
        [Test]
        public void Deck01_McWinSauce_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",0),
                "PostTherosBeyondDeath",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck02_WingedHussar_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Mzfroste_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck04_Papelucho10_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck05_coert_Devoted_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.WBG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck06_FalseMufn_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck07_yamakiller_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck08_hcook725_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck09_Finalnub_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck10_thepensword_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_LordBeerus_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck12_ibTRUE_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Saviall_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck14_bobthedog_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",13),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericBlink",
                null,
                null
            );
        }

        [Test]
        public void Deck15_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",14),
                "PostTherosBeyondDeath",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck16_MichaelScott_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",15),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck17_maxxattack_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",16),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck18_damatoexp_GiftsStorm_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",17),
                "PostTherosBeyondDeath",
                ArchetypeColor.URG,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck19_mac121711_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",18),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck20_qbturtle15_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",19),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck21_Scooter8968_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",20),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Hazzrd_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",21),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck23_uaedoliB_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",22),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck24_in5ano_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",23),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck25_vinitorres_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",24),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck26_vinnyrussian123_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",25),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck27_offline_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",26),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck28_PTarts2win_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",27),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck29_Amayesing83_AbzanMidrange_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",28),
                "PostTherosBeyondDeath",
                ArchetypeColor.WBG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck30_coolperson63_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",29),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck31_ElevatahPartay_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",30),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck32_BrandanMya_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",31),
                "PostTherosBeyondDeath",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck33_TheNotSure_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",32),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck34_Xwhale_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-25",33),
                "PostTherosBeyondDeath",
                ArchetypeColor.BG,
                "PrimevalTitan",
                null,
                null
            );
        }


    }
}
