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
#01 Mordeka1ser: Niv To Light (WUBRG)
#02 xakx47x: Naya Midrange (WRG)
#03 harukispecial: Bant Control (WUG)
#04 remf: Gruul Midrange (RG)
#05 sparr0t: Humans (WUBRG)
#06 Capin_ahab: Thopter Urza (WUR)
#07 Laplasjan: Gruul Midrange (RG)
#08 Patxi: Uroza (URG)
#09 lucadaky: Gruul Midrange (RG)
#10 _goblinlackey: Bushwhacker Zoo (WRG)
#11 HappySandwich: Gruul Midrange (RG)
#12 FestiFan: Bant Control (WUG)
#13 Manacymbal: UBRG Control (UBRG)
#14 Misplacedginger: Bant Control (WUG)
#15 TradewindRider: Bant Control (WUG)
#16 Kuhb: Grinding Breach (WURG)
#17 Sodeq: Dredge (BRG)
#18 PhantasmalBear: Scapeshift (URG)
#19 Bucknasty691989: Living End (BRG)
#20 Davede: UBRG Shadow (UBRG)
#21 SunofNothing: Uroza (URG)
#22 Fnoop: Infect (UG)
#23 Montre82: Humans (WUBRG)
#24 EddDeedoo: Orzhov Midrange (WB)
#25 jonasensio: Boros Prowess (WR)
#26 Parrit: Orzhov Taxes (WB)
#27 oniiman: Mono Red Prowess (R)
#28 ecobaronen: Infect (UG)
#29 willpulliam: Niv To Light (WUBRG)
#30 Hfang1: Infect (UG)
#31 el-pollo-lolo: Rakdos Midrange (BR)
#32 Poderosisimo: Grixis Shadow (UBR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_challenge_2020_04_05 : EventTest
    {
        [Test]
        public void Deck01_Mordeka1ser_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",0),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck02_xakx47x_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",1),
                "PostOuatBan",
                ArchetypeColor.WRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck03_harukispecial_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",2),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck04_remf_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",3),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck05_sparr0t_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",4),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck06_Capinahab_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",5),
                "PostOuatBan",
                ArchetypeColor.WUR,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck07_Laplasjan_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",6),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck08_Patxi_Uroza_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",7),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck09_lucadaky_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",8),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck10_goblinlackey_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",9),
                "PostOuatBan",
                ArchetypeColor.WRG,
                "BushwhackerZoo",
                null,
                null
            );
        }

        [Test]
        public void Deck11_HappySandwich_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",10),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck12_FestiFan_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",11),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck13_Manacymbal_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",12),
                "PostOuatBan",
                ArchetypeColor.UBRG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck14_Misplacedginger_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",13),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck15_TradewindRider_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",14),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Kuhb_GrindingBreach_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",15),
                "PostOuatBan",
                ArchetypeColor.WURG,
                "GrindingBreach",
                null,
                null
            );
        }

        [Test]
        public void Deck17_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",16),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck18_PhantasmalBear_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",17),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                null
            );
        }

        [Test]
        public void Deck19_Bucknasty691989_LivingEnd_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",18),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "LivingEnd",
                null,
                null
            );
        }

        [Test]
        public void Deck20_Davede_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",19),
                "PostOuatBan",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck21_SunofNothing_Uroza_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",20),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Fnoop_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",21),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck23_Montre82_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",22),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck24_EddDeedoo_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",23),
                "PostOuatBan",
                ArchetypeColor.WB,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck25_jonasensio_BorosProwess_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",24),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck26_Parrit_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",25),
                "PostOuatBan",
                ArchetypeColor.WB,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck27_oniiman_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",26),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck28_ecobaronen_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",27),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck29_willpulliam_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",28),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                null
            );
        }

        [Test]
        public void Deck30_Hfang1_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",29),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck31_elpollololo_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",30),
                "PostOuatBan",
                ArchetypeColor.BR,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck32_Poderosisimo_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",31),
                "PostOuatBan",
                ArchetypeColor.UBR,
                "Shadow",
                null,
                null
            );
        }


    }
}
