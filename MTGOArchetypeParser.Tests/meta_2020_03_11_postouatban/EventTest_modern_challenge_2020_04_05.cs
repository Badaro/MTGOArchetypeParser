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
#08 Patxi: Uroza (UG)
#09 lucadaky: Gruul Midrange (RG)
#10 _goblinlackey: Bushwhacker Zoo (WRG)
#11 HappySandwich: Gruul Midrange (RG)
#12 FestiFan: Bant Control (WUG)
#13 Manacymbal: Sultai Control (UBG)
#14 Misplacedginger: Bant Control (WUG)
#15 TradewindRider: Bant Control (WUG)
#16 Kuhb: Grinding Breach (WUR)
#17 Sodeq: Dredge (BRG)
#18 PhantasmalBear: Scapeshift (URG)
#19 Bucknasty691989: Living End (BRG)
#20 Davede: UBRG Shadow (UBRG)
#21 SunofNothing: Uroza (UG)
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
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck02_xakx47x_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",1),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck03_harukispecial_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",2),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_remf_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",3),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck05_sparr0t_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",4),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Capinahab_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",5),
                new PostOuatBan(),
                ArchetypeColor.WUR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck07_Laplasjan_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",6),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Patxi_Uroza_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",7),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck09_lucadaky_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",8),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_goblinlackey_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",9),
                new PostOuatBan(),
                ArchetypeColor.WRG,
                typeof(BushwhackerZoo),
                null,
                null
            );
        }

        [Test]
        public void Deck11_HappySandwich_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",10),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_FestiFan_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",11),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Manacymbal_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",12),
                new PostOuatBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Misplacedginger_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",13),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_TradewindRider_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",14),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Kuhb_GrindingBreach_WUR()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",15),
                new PostOuatBan(),
                ArchetypeColor.WUR,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",16),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck18_PhantasmalBear_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",17),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck19_Bucknasty691989_LivingEnd_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",18),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(LivingEnd),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Davede_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",19),
                new PostOuatBan(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck21_SunofNothing_Uroza_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",20),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Fnoop_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",21),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Montre82_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",22),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck24_EddDeedoo_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",23),
                new PostOuatBan(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck25_jonasensio_BorosProwess_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",24),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck26_Parrit_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",25),
                new PostOuatBan(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck27_oniiman_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",26),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck28_ecobaronen_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",27),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck29_willpulliam_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",28),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Hfang1_Infect_UG()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",29),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck31_elpollololo_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",30),
                new PostOuatBan(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Poderosisimo_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-challenge-2020-04-05",31),
                new PostOuatBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }


    }
}
