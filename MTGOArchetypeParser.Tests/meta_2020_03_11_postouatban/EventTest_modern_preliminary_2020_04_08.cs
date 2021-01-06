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
#01 in5ano: Thopter Urza (WUR)
#02 mark_68: Mono Red Prowess (R)
#03 HCHAK: Uroza (UG)
#04 Rinko: Goryo Reanimator (BRG)
#05 Dafne17: Gruul Midrange (RG)
#06 Violent_Outburst: Polymorph (WUR)
#07 Gigy: Humans (WUBRG)
#08 _Antoniou_: Niv To Light (WUBRG)
#09 envizz: Jund Midrange (BRG)
#10 a_p_s: Gruul Midrange (RG)
#11 Toastxp: Uroza (UG)
#12 JustBurn420: Slivers (WUBRG)
#13 winterlong: Dredge (BRG)
#14 coert: Burn (WR)
#15 alemilan19: Dredge (BRG)
#16 selbstdenker: Niv To Light (WUBRG)
#17 PRGJJAR: Dredge (BRG)
#18 Laplasjan: Gruul Midrange (RG)
#19 12Days: Gruul Midrange (RG)
#20 Darthkid: Niv To Light (WUBRG)
#21 Blueliner: Mono Green Midrange (G)
#22 Turn5: Izzet Control (UR)
#23 __matsugan: Neobrand (UG)
#24 ACG88: Niv To Light (WUBRG)
#25 jessy_samek: Uroza (UG)
#26 hikid: Amulet Titan (G)
#27 grinderA: Gruul Midrange (RG)
#28 IsKeiP529: Green Tron (G)
#29 2n0r1ax: Inverter Combo (WUB)
#30 TSPJendrek: Esper Control (WUB)
#31 Oscar_Franco: Ad Nauseam (WUB)
#32 Rudokant: Temur Control (URG)
#33 Ravnika_on_fire: Dredge (BRG)
#34 penips: Mono White Taxes (W)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_04_08 : EventTest
    {
        [Test]
        public void Deck01_in5ano_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",0),
                new PostOuatBan(),
                ArchetypeColor.WUR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck02_mark68_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",1),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck03_HCHAK_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",2),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Rinko_GoryoReanimator_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",3),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GoryoReanimator),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Dafne17_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",4),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_ViolentOutburst_Polymorph_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",5),
                new PostOuatBan(),
                ArchetypeColor.WUR,
                typeof(Polymorph),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Gigy_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",6),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Antoniou_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",7),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck09_envizz_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",8),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_aps_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",9),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck11_Toastxp_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",10),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck12_JustBurn420_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",11),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck13_winterlong_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",12),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck14_coert_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",13),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck15_alemilan19_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",14),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck16_selbstdenker_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",15),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck17_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",16),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Laplasjan_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",17),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck19_12Days_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",18),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Darthkid_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",19),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Blueliner_MonoGreenMidrange_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",20),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck22_Turn5_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",21),
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",22),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck24_ACG88_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",23),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck25_jessysamek_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",24),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck26_hikid_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",25),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck27_grinderA_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",26),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck28_IsKeiP529_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",27),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck29_2n0r1ax_InverterCombo_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",28),
                new PostOuatBan(),
                ArchetypeColor.WUB,
                typeof(InverterCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck30_TSPJendrek_EsperControl_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",29),
                new PostOuatBan(),
                ArchetypeColor.WUB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_OscarFranco_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",30),
                new PostOuatBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Rudokant_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",31),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck33_Ravnikaonfire_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",32),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck34_penips_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-08",33),
                new PostOuatBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }


    }
}
