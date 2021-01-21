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
#01 coert: Burn (WR)
#02 Do0mSwitch: Bant Control (WUG)
#03 Toastxp: Uroza (URG)
#04 ack_s: Gruul Midrange (RG)
#05 JV_7777: Dredge (BRG)
#06 David1987: Niv To Light (WUBRG)
#07 Sarv: Grinding Breach (WUR)
#08 Traft: Goblins (BRG)
#09 Diem4x: Bant Control (WUG)
#10 sokos13: Infect (UG)
#11 Blade400: Eldrazi Tron (C)
#12 SourceOdin: Bant Control (WUG)
#13 Dafne17: Gruul Midrange (RG)
#14 Werepigs: Spirits (WU)
#15 anaccidentalman: Dredge (BRG)
#16 Voidpaw: Jund Midrange (BRG)
#17 Gerardo94: Bant Control (WUG)
#18 zMunkeyXz: Mill (UBG)
#19 Kenzaburo: Niv To Light (WUBRG)
#20 sff_mtg: Green Tron (G)
#21 Bayesta_93: Gruul Midrange (RG)
#22 Ivc: Bant Control (WUG)
#23 Asoen: Rakdos Midrange (BR)
#24 SickWorld: Burn (WR)
#25 yxcvbnm: Uroza (URG)
#26 ArchaeusDota: Eldrazi Tron (R)
#27 larkblue: Ad Nauseam (WUB)
#28 eminemberry: Burn (WR)
#29 Sodeq: Dredge (BRG)
#30 Aluren85: Dredge (UBRG)
#31 gottelicious: Green Tron (G)
#32 ACG88: Humans (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_super_qualifier_2020_04_12 : EventTest
    {
        [Test]
        public void Deck01_coert_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",0),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck02_Do0mSwitch_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",1),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Toastxp_Uroza_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",2),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck04_acks_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",3),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck05_JV7777_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",4),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck06_David1987_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",5),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Sarv_GrindingBreach_WUR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",6),
                "PostOuatBan",
                ArchetypeColor.WUR,
                "GrindingBreach",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Traft_Goblins_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",7),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Goblins",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Diem4x_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",8),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck10_sokos13_Infect_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",9),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck11_Blade400_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",10),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck12_SourceOdin_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",11),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Dafne17_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",12),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Werepigs_Spirits_WU()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",13),
                "PostOuatBan",
                ArchetypeColor.WU,
                "Spirits",
                null,
                null
            );
        }

        [Test]
        public void Deck15_anaccidentalman_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",14),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Voidpaw_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",15),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck17_Gerardo94_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",16),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck18_zMunkeyXz_Mill_UBG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",17),
                "PostOuatBan",
                ArchetypeColor.UBG,
                "Mill",
                null,
                null
            );
        }

        [Test]
        public void Deck19_Kenzaburo_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",18),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck20_sffmtg_GreenTron_G()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",19),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck21_Bayesta93_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",20),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Ivc_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",21),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Asoen_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",22),
                "PostOuatBan",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck24_SickWorld_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",23),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck25_yxcvbnm_Uroza_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",24),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck26_ArchaeusDota_EldraziTron_R()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",25),
                "PostOuatBan",
                ArchetypeColor.R,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck27_larkblue_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",26),
                "PostOuatBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck28_eminemberry_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",27),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck29_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",28),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck30_Aluren85_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",29),
                "PostOuatBan",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck31_gottelicious_GreenTron_G()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",30),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck32_ACG88_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-12",31),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }


    }
}
