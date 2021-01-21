using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 il_matagatto: Burn (WR)
#02 derk714: Bant Control (WUG)
#03 zachattack23: Grinding Breach (WUR)
#04 uaedoliB: Humans (WUBRG)
#05 Heir_of_Elendil15: Azorius Control (WU)
#06 Trieste: Bant Control (WUG)
#07 DuHeng: UBRG Shadow (UBRG)
#08 GoonLord: Bant Control (WUG)
#09 bamzing: Eldrazi Tron (C)
#10 E_Kaminuma: Devoted (WG)
#11 omgitztommy: Grinding Breach (WUBR)
#12 LickNsticK: Bant Control (WUG)
#13 coert: Green Tron (G)
#14 fuya: Mono Red Prowess (R)
#15 NightShadowJ: Thopter Urza (UBR)
#16 hikid: Amulet Titan (UG)
#17 Hfang1: Infect (UG)
#18 cool95: Dredge (WBRG)
#19 contrap: Infect (UG)
#20 BReal2: Rakdos Midrange (BR)
#21 nathansteuer: Eldrazi Tron (C)
#22 PRGJJAR: Dredge (BRG)
#23 JeremyMandel: Eldrazi Tron (C)
#24 Mooose: Bant Control (WUG)
#25 SourceOdin: Grinding Breach (WUR)
#26 Sam_Lewin: Skelementals (BR)
#27 thepensword: Izzet Control (UR)
#28 topdollar: Jund Midrange (BRG)
#29 Shadowz2005: Jund Shadow (BRG)
#30 _LSN_: Burn (WR)
#31 Aphiladon: Bant Control (WUG)
#32 PTarts2win: Crabvine (UBG)
#33 TFTIjhub: Eldrazi Tron (C)
#34 yamakiller: Mono Red Prowess (R)
#35 Usama96: Jund Midrange (BRG)
#36 dillyg10: Thopter Urza (UB)
#37 _Carter_: Grixis Shadow (UBR)
#38 RNGspecialist: WURG Control (WURG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_03_14 : EventTest
    {
        [Test]
        public void Deck01_ilmatagatto_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",0),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck02_derk714_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",1),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_zachattack23_GrindingBreach_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",2),
                "PostOuatBan",
                ArchetypeColor.WUR,
                "GrindingBreach",
                null,
                null
            );
        }

        [Test]
        public void Deck04_uaedoliB_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",3),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck05_HeirofElendil15_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",4),
                "PostOuatBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Trieste_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",5),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck07_DuHeng_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",6),
                "PostOuatBan",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck08_GoonLord_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",7),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck09_bamzing_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",8),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck10_EKaminuma_Devoted_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",9),
                "PostOuatBan",
                ArchetypeColor.WG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck11_omgitztommy_GrindingBreach_WUBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",10),
                "PostOuatBan",
                ArchetypeColor.WUBR,
                "GrindingBreach",
                null,
                null
            );
        }

        [Test]
        public void Deck12_LickNsticK_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",11),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck13_coert_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",12),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck14_fuya_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",13),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck15_NightShadowJ_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",14),
                "PostOuatBan",
                ArchetypeColor.UBR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck16_hikid_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",15),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck17_Hfang1_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",16),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck18_cool95_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",17),
                "PostOuatBan",
                ArchetypeColor.WBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck19_contrap_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",18),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck20_BReal2_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",19),
                "PostOuatBan",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck21_nathansteuer_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",20),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck22_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",21),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck23_JeremyMandel_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",22),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck24_Mooose_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",23),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck25_SourceOdin_GrindingBreach_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",24),
                "PostOuatBan",
                ArchetypeColor.WUR,
                "GrindingBreach",
                null,
                null
            );
        }

        [Test]
        public void Deck26_SamLewin_Skelementals_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",25),
                "PostOuatBan",
                ArchetypeColor.BR,
                "Skelementals",
                null,
                null
            );
        }

        [Test]
        public void Deck27_thepensword_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",26),
                "PostOuatBan",
                ArchetypeColor.UR,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck28_topdollar_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",27),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Shadowz2005_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",28),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck30_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",29),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck31_Aphiladon_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",30),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck32_PTarts2win_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",31),
                "PostOuatBan",
                ArchetypeColor.UBG,
                "Crabvine",
                null,
                null
            );
        }

        [Test]
        public void Deck33_TFTIjhub_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",32),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck34_yamakiller_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",33),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck35_Usama96_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",34),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck36_dillyg10_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",35),
                "PostOuatBan",
                ArchetypeColor.UB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck37_Carter_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",36),
                "PostOuatBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck38_RNGspecialist_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-14",37),
                "PostOuatBan",
                ArchetypeColor.WURG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
