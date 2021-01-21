using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 hcook725: Thopter Urza (UB)
#02 MLupa: Gruul Midrange (RG)
#03 dejoyjoe: Amulet Titan (UG)
#04 ho-oh: Eldrazi Tron (G)
#05 Ayohae: Thopter Urza (UB)
#06 qbturtle15: Azorius Control (WU)
#07 Fnoop: Grinding Breach (WUR)
#08 gatts_bra: Eldrazi Tron (G)
#09 ElevatahPartay: Uroza (URG)
#10 BARGAHOF: Eldrazi Tron (G)
#11 willpulliam: Amulet Titan (UG)
#12 cftsoc3: Bant Blink (WUG)
#13 msskinbolic: Primeval Titan (BG)
#14 Samwise_GeeGee: Mono Red Prowess (R)
#15 joker10289: Dimir Control (UB)
#16 lukystrike: Mono White Taxes (W)
#17 Novaphantom: Eldrazi Tron (C)
#18 MATTHEWFOULKES: Grinding Breach (WUR)
#19 raisans: Primeval Titan (UBG)
#20 edward40hands: Golgari Midrange (BG)
#21 _LSN_: Burn (WR)
#22 TeamMages: Mono Red Prowess (R)
#23 Shadowz2005: UBRG Shadow (UBRG)
#24 KinderAttack: Jund Midrange (BRG)
#25 MinT_: Inverter Combo (WUB)
#26 CReactor: Eldrazi Tron (G)
#27 Parrotlet: Bant Control (WUG)
#28 Soixante_Neuf: Neobrand (UG)
#29 Louis-PD: Devoted (WBG)
#30 FestiFan: Thopter Urza (UB)
#31 PRGJJAR: Dredge (BRG)
#32 ChubbyCheese: Mono Red Prowess (R)
#33 lwdgg: Thopter Urza (UB)
#34 hodortimebaby: Dredge (BRG)
#35 Mzfroste: Amulet Titan (UG)
#36 Xwhale: Eldrazi Tron (G)
#37 Icteridae: Devoted (WUG)
#38 TheTunnelingCat: Eldrazi Tron (C)
#39 DjangoRealitySculptr: Evershrike Combo (BG)
#40 azax: Neobrand (UG)
#41 pokerswizard: Eldrazi Tron (G)
#42 Bucknasty691989: Burn (WR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_03_03 : EventTest
    {
        [Test]
        public void Deck01_hcook725_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",0),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck02_MLupa_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",1),
                "PostTherosBeyondDeath",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck03_dejoyjoe_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",2),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck04_hooh_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",3),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck05_Ayohae_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",4),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck06_qbturtle15_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",5),
                "PostTherosBeyondDeath",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Fnoop_GrindingBreach_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",6),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUR,
                "GrindingBreach",
                null,
                null
            );
        }

        [Test]
        public void Deck08_gattsbra_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",7),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck09_ElevatahPartay_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",8),
                "PostTherosBeyondDeath",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck10_BARGAHOF_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",9),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck11_willpulliam_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",10),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck12_cftsoc3_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",11),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericBlink",
                null,
                null
            );
        }

        [Test]
        public void Deck13_msskinbolic_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",12),
                "PostTherosBeyondDeath",
                ArchetypeColor.BG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck14_SamwiseGeeGee_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",13),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck15_joker10289_DimirControl_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",14),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck16_lukystrike_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",15),
                "PostTherosBeyondDeath",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck17_Novaphantom_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",16),
                "PostTherosBeyondDeath",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck18_MATTHEWFOULKES_GrindingBreach_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",17),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUR,
                "GrindingBreach",
                null,
                null
            );
        }

        [Test]
        public void Deck19_raisans_PrimevalTitan_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",18),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck20_edward40hands_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",19),
                "PostTherosBeyondDeath",
                ArchetypeColor.BG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck21_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",20),
                "PostTherosBeyondDeath",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck22_TeamMages_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",21),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck23_Shadowz2005_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",22),
                "PostTherosBeyondDeath",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck24_KinderAttack_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",23),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck25_MinT_InverterCombo_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",24),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUB,
                "InverterCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck26_CReactor_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",25),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck27_Parrotlet_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",26),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck28_SoixanteNeuf_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",27),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck29_LouisPD_Devoted_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",28),
                "PostTherosBeyondDeath",
                ArchetypeColor.WBG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck30_FestiFan_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",29),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck31_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",30),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck32_ChubbyCheese_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",31),
                "PostTherosBeyondDeath",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck33_lwdgg_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",32),
                "PostTherosBeyondDeath",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck34_hodortimebaby_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",33),
                "PostTherosBeyondDeath",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck35_Mzfroste_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",34),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck36_Xwhale_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",35),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck37_Icteridae_Devoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",36),
                "PostTherosBeyondDeath",
                ArchetypeColor.WUG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck38_TheTunnelingCat_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",37),
                "PostTherosBeyondDeath",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck39_DjangoRealitySculptr_EvershrikeCombo_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",38),
                "PostTherosBeyondDeath",
                ArchetypeColor.BG,
                "EvershrikeCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck40_azax_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",39),
                "PostTherosBeyondDeath",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck41_pokerswizard_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",40),
                "PostTherosBeyondDeath",
                ArchetypeColor.G,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck42_Bucknasty691989_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",41),
                "PostTherosBeyondDeath",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }


    }
}
