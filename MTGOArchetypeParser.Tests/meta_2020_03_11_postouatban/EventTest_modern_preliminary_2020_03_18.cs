using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 azureu09: Ad Nauseam (WUB)
#02 jhk_: Jund Midrange (BRG)
#03 Freyja: Living End (URG)
#04 johnyvolta: Kiki Chord (WURG)
#05 SourceOdin: Thopter Urza (WU)
#06 coert: Green Tron (G)
#07 Granham: Green Tron (G)
#08 Heibing: Eldrazi Tron (C)
#09 im2g00t4ubarn: Uroza (URG)
#10 Jenara19: Uroza (URG)
#11 MATTOMARINAIO: Uroza (URG)
#12 MATTHEWFOULKES: Grinding Breach (WUBR)
#13 Predicted: Yawgmoth (BG)
#14 Mou: Jund Midrange (BRG)
#15 RNGspecialist: Saheeli Combo (WUR)
#16 UmekawaneikU: Jund Midrange (BRG)
#17 kefka27: Dredge (UBRG)
#18 Drakanar: Merfolk (UG)
#19 _Antoniou_: Green Eldrazi (RG)
#20 ACG88: Green Tron (G)
#21 Playmobil: Bant Control (WUG)
#22 NosonosaN: Bant Control (WUG)
#23 fradev1988: Electro Balance (UR)
#24 Treno: Green Tron (G)
#25 Olivetti: Mono White Taxes (W)
#26 Genxim: Green Tron (G)
#27 medvedev: Mono White Taxes (W)
#28 instantQ: Burn (WR)
#29 Dazai: Bant Control (WUG)
#30 Rooney56: Jund Midrange (BRG)
#31 Phill_Hellmuth: Humans (WUBRG)
#32 G0NZO: Eldrazi Tron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_03_18 : EventTest
    {
        [Test]
        public void Deck01_azureu09_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",0),
                "PostOuatBan",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck02_jhk_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",1),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck03_Freyja_LivingEnd_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",2),
                "PostOuatBan",
                ArchetypeColor.URG,
                "LivingEnd",
                null,
                null
            );
        }

        [Test]
        public void Deck04_johnyvolta_KikiChord_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",3),
                "PostOuatBan",
                ArchetypeColor.WURG,
                "KikiChord",
                null,
                null
            );
        }

        [Test]
        public void Deck05_SourceOdin_ThopterUrza_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",4),
                "PostOuatBan",
                ArchetypeColor.WU,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck06_coert_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",5),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck07_Granham_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",6),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck08_Heibing_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",7),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck09_im2g00t4ubarn_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",8),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck10_Jenara19_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",9),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck11_MATTOMARINAIO_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",10),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck12_MATTHEWFOULKES_GrindingBreach_WUBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",11),
                "PostOuatBan",
                ArchetypeColor.WUBR,
                "GrindingBreach",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Predicted_Yawgmoth_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",12),
                "PostOuatBan",
                ArchetypeColor.BG,
                "Yawgmoth",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Mou_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",13),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck15_RNGspecialist_SaheeliCombo_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",14),
                "PostOuatBan",
                ArchetypeColor.WUR,
                "SaheeliCombo",
                null,
                null
            );
        }

        [Test]
        public void Deck16_UmekawaneikU_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",15),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck17_kefka27_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",16),
                "PostOuatBan",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck18_Drakanar_Merfolk_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",17),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Merfolk",
                null,
                null
            );
        }

        [Test]
        public void Deck19_Antoniou_GreenEldrazi_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",18),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GreenEldrazi",
                null,
                null
            );
        }

        [Test]
        public void Deck20_ACG88_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",19),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck21_Playmobil_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",20),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck22_NosonosaN_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",21),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck23_fradev1988_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",22),
                "PostOuatBan",
                ArchetypeColor.UR,
                "FreeSpells",
                "ElectroBalance",
                null
            );
        }

        [Test]
        public void Deck24_Treno_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",23),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck25_Olivetti_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",24),
                "PostOuatBan",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck26_Genxim_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",25),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck27_medvedev_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",26),
                "PostOuatBan",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck28_instantQ_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",27),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck29_Dazai_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",28),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck30_Rooney56_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",29),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck31_PhillHellmuth_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",30),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck32_G0NZO_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-18",31),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }


    }
}
