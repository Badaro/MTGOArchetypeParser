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
#01 Parrit: Mono White Taxes (W)
#02 __matsugan: Neobrand (UG)
#03 SoulStrong: Simic Control (UG)
#04 heterotic: Gruul Prowess (RG)
#05 VampireGodric: Bant Control (WUG)
#06 signblindman: Gruul Midrange (RG)
#07 Ivc: Bant Control (WUG)
#08 Mistakenn: Amulet Titan (UG)
#09 Yanti: Humans (WUBRG)
#10 Scacco Malto: Mono Red Prowess (R)
#11 Caleb_Yetman: Simic Control (UG)
#12 roter_Erzengel: Infect (UG)
#13 cftsoc3: Bant Blink (WUG)
#14 PredatorStyle: Gruul Midrange (RG)
#15 _Batutinha_: Bant Control (WUG)
#16 Logarythme: Bant Control (WUG)
#17 gio9595: Burn (WR)
#18 Capitano_CL: Dredge (UBRG)
#19 FalseMufn: Amulet Titan (UG)
#20 TJmagicJT: Humans (WUBRG)
#21 sakuragi21722749: Eldrazi Tron (C)
#22 La_Biscia: Gruul Midrange (RG)
#23 WingedHussar: Neobrand (UG)
#24 Gerschi: Thopter Urza (WUB)
#25 ACG88: Primeval Titan (BG)
#26 SunofNothing: Uroza (URG)
#27 TwistedWombat: Niv To Light (WUBRG)
#28 Mlgb92: Gruul Midrange (RG)
#29 _kg: Dredge (BRG)
#30 austinflakesss: Burn (WR)
#31 Graciasportanto: Uroza (URG)
#32 ManuelJacob: Bant Control (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_super_qualifier_2020_04_17 : EventTest
    {
        [Test]
        public void Deck01_Parrit_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",0),
                new PostOuatBan(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck02_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",1),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck03_SoulStrong_SimicControl_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",2),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_heterotic_GruulProwess_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",3),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck05_VampireGodric_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",4),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_signblindman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",5),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Ivc_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",6),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Mistakenn_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",7),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck09_Yanti_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",8),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck10_ScaccoMalto_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",9),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck11_CalebYetman_SimicControl_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",10),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_roterErzengel_Infect_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",11),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck13_cftsoc3_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",12),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck14_PredatorStyle_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",13),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Batutinha_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",14),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Logarythme_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",15),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_gio9595_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",16),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck18_CapitanoCL_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",17),
                new PostOuatBan(),
                ArchetypeColor.UBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck19_FalseMufn_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",18),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck20_TJmagicJT_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",19),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck21_sakuragi21722749_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",20),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck22_LaBiscia_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",21),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck23_WingedHussar_Neobrand_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",22),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Gerschi_ThopterUrza_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",23),
                new PostOuatBan(),
                ArchetypeColor.WUB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck25_ACG88_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",24),
                new PostOuatBan(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck26_SunofNothing_Uroza_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",25),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck27_TwistedWombat_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",26),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Mlgb92_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",27),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck29_kg_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",28),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck30_austinflakesss_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",29),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck31_Graciasportanto_Uroza_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",30),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck32_ManuelJacob_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-17",31),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
