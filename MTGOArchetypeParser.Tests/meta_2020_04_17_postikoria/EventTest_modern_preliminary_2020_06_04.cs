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
#01 Gigy: Gruul Midrange (RG)
#02 maximusdee: Gifts Storm (UR)
#03 leclairandy: Bant Control (WUG)
#04 SunofNothing: Uroza (URG)
#05 Toastxp: Uroza (URG, Yorion)
#06 jessy_samek: Infect (UG)
#07 hugo87: Gifts Storm (UR)
#08 qbturtle15: Gruul Midrange (RG, Obosh)
#09 fried-liver-attack: Eldrazi Tron (C)
#10 D00mwake: Humans (WUBRG)
#11 alemilan19: Humans (WUBRG)
#12 ContraEgo: Thopter Urza (UBR)
#13 Icteridae: Devoted (WUG)
#14 PRGJJAR: Dredge (BRG)
#15 Lord_Beerus: Burn (WR, Lurrus)
#16 retiredcapivara: Dredge (BRG)
#17 Laplasjan: Devoted (WG, Lurrus)
#18 Add1ct3d: Bant Control (WUG)
#19 joetru: Niv To Light (WUBRG)
#20 ilsecco14: Golgari Midrange (BG)
#21 _goblinlackey: Green Tron (G, Jegantha)
#22 Ryan100495: Dredge (BRG)
#23 KeeperX: Naya Midrange (WRG)
#24 PietroSas: Devoted (WG, Lurrus)
#25 Lord_of_Puntlantis: Inverter Combo (UB)
#26 cftsoc3: Bant Blink (WUG, Yorion)
#27 _LSN_: Burn (WR)
#28 nathansteuer: Uroza (URG)
#29 pokerswizard: Eldrazi Tron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_06_04 : EventTest
    {
        [Test]
        public void Deck01_Gigy_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",0),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck02_maximusdee_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",1),
                "PostIkoria",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck03_leclairandy_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",2),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_SunofNothing_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",3),
                "PostIkoria",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Toastxp_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",4),
                "PostIkoria",
                ArchetypeColor.URG,
                "Uroza",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_jessysamek_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",5),
                "PostIkoria",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck07_hugo87_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",6),
                "PostIkoria",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck08_qbturtle15_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",7),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck09_friedliverattack_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",8),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck10_D00mwake_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",9),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck11_alemilan19_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",10),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck12_ContraEgo_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",11),
                "PostIkoria",
                ArchetypeColor.UBR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck13_Icteridae_Devoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",12),
                "PostIkoria",
                ArchetypeColor.WUG,
                "Devoted",
                null,
                null
            );
        }

        [Test]
        public void Deck14_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",13),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck15_LordBeerus_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",14),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_retiredcapivara_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",15),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck17_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",16),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_Add1ct3d_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",17),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck19_joetru_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",18),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck20_ilsecco14_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",19),
                "PostIkoria",
                ArchetypeColor.BG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck21_goblinlackey_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",20),
                "PostIkoria",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck22_Ryan100495_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",21),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck23_KeeperX_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",22),
                "PostIkoria",
                ArchetypeColor.WRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck24_PietroSas_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",23),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_LordofPuntlantis_InverterCombo_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",24),
                "PostIkoria",
                ArchetypeColor.UB,
                "InverterCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck26_cftsoc3_BantBlink_WUG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",25),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericBlink",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck27_LSN_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",26),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck28_nathansteuer_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",27),
                "PostIkoria",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck29_pokerswizard_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-04",28),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }


    }
}
