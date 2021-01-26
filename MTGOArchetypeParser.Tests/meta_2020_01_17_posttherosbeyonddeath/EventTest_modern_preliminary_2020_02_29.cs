using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Daryl_Ayers: Amulet Titan (UG)
#02 Mistakenn: Amulet Titan (UG)
#03 NorrathDecay: Burn (R)
#04 zMagic4ever: Eldrazi Tron (G)
#05 xfile: Eldrazi Tron (G)
#06 quinniac: Burn (WR)
#07 Misterkle: Grixis Shadow (UBR)
#08 tritty: Spirits (WUG)
#09 NightKnight131: Devoted (WBG)
#10 _LSN_: Burn (WR)
#11 A22en: Devoted (WG)
#12 Ramp: Selesnya Taxes (WG)
#13 ElevatahPartay: Uroza (UG)
#14 flankattack27: Esper Midrange (WUB)
#15 markdm: Gruul Midrange (RG)
#16 dejoyjoe: Amulet Titan (UG)
#17 MisterBoo: Burn (WR)
#18 Kitchen_Finks: Thopter Urza (UB)
#19 rofelos: Grinding Breach (WURG)
#20 Benburr: Rakdos Midrange (BR)
#21 triosk: Jund Midrange (BRG)
#22 MichaelScott: Grixis Shadow (UBR)
#23 bradyoo: Green Tron (G)
#24 CReactor: Eldrazi Tron (G)
#25 _Shatun_: Mono Red Prowess (R)
#26 Poderosisimo: Grixis Shadow (UBR)
#27 MTGOLover: WURG Control (WURG)
#28 fescap110: Mono Red Prowess (R)
#29 DreamsOfAshiok: Eldrazi Tron (C)
#30 larkblue: Infect (UG)
#31 Ultimar: Jund Shadow (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_02_29 : EventTest
    {
        [Test]
        public void Deck01_DarylAyers_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",0),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck02_Mistakenn_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck03_NorrathDecay_Burn_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck04_zMagic4ever_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck05_xfile_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck06_quinniac_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck07_Misterkle_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck08_tritty_Spirits_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck09_NightKnight131_Devoted_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.WBG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck10_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck11_A22en_Devoted_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.WG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck12_Ramp_SelesnyaTaxes_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.WG,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck13_ElevatahPartay_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck14_flankattack27_EsperMidrange_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",13),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUB,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck15_markdm_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",14),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck16_dejoyjoe_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",15),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck17_MisterBoo_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",16),
                "PostTherosBeyondDeath",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck18_KitchenFinks_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",17),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck19_rofelos_GrindingBreach_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",18),
                "PostTherosBeyondDeath",
                ArchetypeColor.WURG,
                "GrindingBreach",
                null,
                null
            );
        }

        [Test]
        public void Deck20_Benburr_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",19),
                "PostTherosBeyondDeath",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck21_triosk_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",20),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck22_MichaelScott_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",21),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck23_bradyoo_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",22),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck24_CReactor_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",23),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck25_Shatun_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",24),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck26_Poderosisimo_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",25),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck27_MTGOLover_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",26),
                "PostTherosBeyondDeath",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck28_fescap110_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",27),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck29_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",28),
                "PostTherosBeyondDeath",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck30_larkblue_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",29),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck31_Ultimar_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-29",30),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }


    }
}
