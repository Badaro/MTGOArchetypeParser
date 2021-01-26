using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Tw33Ty: Bushwhacker Zoo (WRG)
#02 baconator5000: Mono Red Prowess (R)
#03 penips: Orzhov Taxes (WB)
#04 Albimtg: Jund Shadow (BRG)
#05 in5ano: Thopter Urza (WUR)
#06 coert: Bushwhacker Zoo (WRG)
#07 Manny-: Jund Shadow (BRG)
#08 joker10289: Gruul Midrange (RG)
#09 _IlNano_: Humans (WUBRG)
#10 kanister: Uroza (URG)
#11 topdeckbolt: Burn (BR)
#12 KanyMTG: Gifts Storm (UR)
#13 PRGJJAR: Dredge (BRG)
#14 Albyz: Gruul Midrange (RG)
#15 Jositoshekel: Bushwhacker Zoo (WRG)
#16 crazyklicker: Tokens (WB)
#17 mell0n: Primeval Titan (BG)
#18 josetorr87: Gruul Midrange (RG)
#19 Dafne17: Uroza (URG)
#20 ArchaeusDota: Eldrazi Tron (R)
#21 Michai: Green Tron (G)
#22 ZYURYO: Jund Midrange (BRG)
#23 J000111: Dredge (BRG)
#24 Amatox: Bant Blink (WUG)
#25 ACG88: Primeval Titan (BG)
#26 Rudokant: Gruul Midrange (RG)
#27 Just-In: Jund Midrange (BRG)
#28 Rinko: Goryo Reanimator (BRG)
#29 Tonynine: Gruul Midrange (RG)
#30 AbelMolto: Burn (WRG)
#31 selbstdenker: Primeval Titan (BG)
#32 rn17: Thopter Urza (UBR)
#33 SoIMBA_Airwave: Green Eldrazi (RG)
#34 TSPJendrek: Esper Control (WUB)
#35 Melon9: Gruul Midrange (RG)
#36 Smurfyyy: Jund Shadow (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_04_01 : EventTest
    {
        [Test]
        public void Deck01_Tw33Ty_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",0),
                "PostOuatBan",
                ArchetypeColor.WRG,
                "BushwhackerZoo",
                null,
                null
            );
        }

        [Test]
        public void Deck02_baconator5000_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",1),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck03_penips_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",2),
                "PostOuatBan",
                ArchetypeColor.WB,
                "Taxes",
                null,
                null
            );
        }

        [Test]
        public void Deck04_Albimtg_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",3),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck05_in5ano_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",4),
                "PostOuatBan",
                ArchetypeColor.WUR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck06_coert_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",5),
                "PostOuatBan",
                ArchetypeColor.WRG,
                "BushwhackerZoo",
                null,
                null
            );
        }

        [Test]
        public void Deck07_Manny_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",6),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck08_joker10289_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",7),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_IlNano_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",8),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck10_kanister_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",9),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck11_topdeckbolt_Burn_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",10),
                "PostOuatBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck12_KanyMTG_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",11),
                "PostOuatBan",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck13_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",12),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Albyz_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",13),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Jositoshekel_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",14),
                "PostOuatBan",
                ArchetypeColor.WRG,
                "BushwhackerZoo",
                null,
                null
            );
        }

        [Test]
        public void Deck16_crazyklicker_Tokens_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",15),
                "PostOuatBan",
                ArchetypeColor.WB,
                "Tokens",
                null,
                null
            );
        }

        [Test]
        public void Deck17_mell0n_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",16),
                "PostOuatBan",
                ArchetypeColor.BG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck18_josetorr87_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",17),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck19_Dafne17_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",18),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck20_ArchaeusDota_EldraziTron_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",19),
                "PostOuatBan",
                ArchetypeColor.R,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck21_Michai_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",20),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck22_ZYURYO_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",21),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck23_J000111_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",22),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck24_Amatox_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",23),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericBlink",
                null,
                null
            );
        }

        [Test]
        public void Deck25_ACG88_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",24),
                "PostOuatBan",
                ArchetypeColor.BG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck26_Rudokant_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",25),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck27_JustIn_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",26),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck28_Rinko_GoryoReanimator_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",27),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GoryoReanimator",
                null,
                null
            );
        }

        [Test]
        public void Deck29_Tonynine_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",28),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck30_AbelMolto_Burn_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",29),
                "PostOuatBan",
                ArchetypeColor.WRG,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck31_selbstdenker_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",30),
                "PostOuatBan",
                ArchetypeColor.BG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck32_rn17_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",31),
                "PostOuatBan",
                ArchetypeColor.UBR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck33_SoIMBAAirwave_GreenEldrazi_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",32),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GreenEldrazi",
                null,
                null
            );
        }

        [Test]
        public void Deck34_TSPJendrek_EsperControl_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",33),
                "PostOuatBan",
                ArchetypeColor.WUB,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck35_Melon9_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",34),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck36_Smurfyyy_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-01",35),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                null
            );
        }


    }
}
