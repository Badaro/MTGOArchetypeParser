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
#01 hcook725: Thopter Urza (UB)
#02 MLupa: Gruul Midrange (RG)
#03 dejoyjoe: Amulet Titan (UG)
#04 ho-oh: Eldrazi Tron (C)
#05 Ayohae: Thopter Urza (UB)
#06 qbturtle15: Azorius Control (WU)
#07 Fnoop: Grinding Breach (WUR)
#08 gatts_bra: Eldrazi Tron (C)
#09 ElevatahPartay: Uroza (UG)
#10 BARGAHOF: Eldrazi Tron (C)
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
#26 CReactor: Eldrazi Tron (C)
#27 Parrotlet: Bant Control (WUG)
#28 Soixante_Neuf: Neobrand (UG)
#29 Louis-PD: Devoted (WBG)
#30 FestiFan: Thopter Urza (UB)
#31 PRGJJAR: Dredge (BRG)
#32 ChubbyCheese: Mono Red Prowess (R)
#33 lwdgg: Thopter Urza (UB)
#34 hodortimebaby: Dredge (BRG)
#35 Mzfroste: Amulet Titan (UG)
#36 Xwhale: Eldrazi Tron (C)
#37 Icteridae: Devoted (WUG)
#38 TheTunnelingCat: Eldrazi Tron (C)
#39 DjangoRealitySculptr: Golgari Midrange (BG)
#40 azax: Neobrand (UG)
#41 pokerswizard: Eldrazi Tron (C)
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
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck02_MLupa_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_dejoyjoe_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck04_hooh_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck05_Ayohae_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck06_qbturtle15_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Fnoop_GrindingBreach_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUR,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck08_gattsbra_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck09_ElevatahPartay_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck10_BARGAHOF_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck11_willpulliam_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck12_cftsoc3_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck13_msskinbolic_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck14_SamwiseGeeGee_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck15_joker10289_DimirControl_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_lukystrike_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",15),
                new PostTherosBeyondDeath(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Novaphantom_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",16),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck18_MATTHEWFOULKES_GrindingBreach_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",17),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUR,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck19_raisans_PrimevalTitan_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",18),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck20_edward40hands_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",19),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck21_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",20),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck22_TeamMages_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",21),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Shadowz2005_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",22),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck24_KinderAttack_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",23),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck25_MinT_InverterCombo_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",24),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUB,
                typeof(InverterCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck26_CReactor_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",25),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck27_Parrotlet_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",26),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck28_SoixanteNeuf_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",27),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck29_LouisPD_Devoted_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",28),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck30_FestiFan_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",29),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck31_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",30),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck32_ChubbyCheese_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",31),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck33_lwdgg_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",32),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck34_hodortimebaby_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",33),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck35_Mzfroste_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",34),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck36_Xwhale_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",35),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck37_Icteridae_Devoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",36),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck38_TheTunnelingCat_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",37),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck39_DjangoRealitySculptr_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",38),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BG,
                typeof(EvershrikeCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck40_azax_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",39),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck41_pokerswizard_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",40),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck42_Bucknasty691989_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-03",41),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }


    }
}
