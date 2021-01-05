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
#01 sparr0t: Humans (WUBRG, Jegantha)
#02 Nbfalcao: Bant Control (WUG)
#03 DreamsOfAshiok: Eldrazi Tron (C)
#04 zMunkeyXz: Mill (UBG)
#05 MATTHEWFOULKES: Burn (WR, Lurrus)
#06 Coly2: Devoted (WG, Lurrus)
#07 Finespoo: Devoted (WG, Lurrus)
#08 NicolasBeland: Burn (WR)
#09 Nammersquats: Humans (WUBRG)
#10 raisans: Boros Prowess (WR, Lurrus)
#11 MdvWin: Burn (WR, Lurrus)
#12 Cherryxman: Burn (WR, Lurrus)
#13 joker10289: Gruul Midrange (RG)
#14 ArchaeusDota: Green Tron (G)
#15 MissTrigger: Burn (WR)
#16 mephidro: Neobrand (UG)
#17 mansak: Jund Midrange (BRG)
#18 fradev1988: Bant Control (WUG)
#19 J000111: Dredge (BRG)
#20 hugo87: Gifts Storm (UR)
#21 Naisirc: Orzhov Taxes (WB)
#22 12Days: Gruul Midrange (RG)
#23 Skite: Uroza (UG)
#24 sandydogmtg: Burn (WR, Lurrus)
#25 Chrislampa: Devoted (WG, Lurrus)
#26 Trid0n: Humans (WUBRG)
#27 Ivc: Bant Control (WUG)
#28 Bayesta_93: Simic Control (UG)
#29 quinniac: Burn (WR, Lurrus)
#30 Team5c: Humans (WUBRG)
#31 Sonso JF: Heliod Combo (WUG)
#32 Savok: Blue Tron (U)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_super_qualifier_2020_04_19 : EventTest
    {
        [Test]
        public void Deck01_sparr0t_Humans_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",0),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck02_Nbfalcao_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",1),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",2),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck04_zMunkeyXz_Mill_UBG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",3),
                new PostIkoria(),
                ArchetypeColor.UBG,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck05_MATTHEWFOULKES_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",4),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_Coly2_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",5),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Finespoo_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",6),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_NicolasBeland_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",7),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Nammersquats_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",8),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck10_raisans_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",9),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_MdvWin_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",10),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck12_Cherryxman_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",11),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_joker10289_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",12),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_ArchaeusDota_GreenTron_G()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",13),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck15_MissTrigger_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",14),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck16_mephidro_Neobrand_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",15),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck17_mansak_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",16),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck18_fradev1988_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",17),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck19_J000111_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",18),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck20_hugo87_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",19),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck21_Naisirc_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",20),
                new PostIkoria(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck22_12Days_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",21),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck23_Skite_Uroza_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",22),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck24_sandydogmtg_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",23),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_Chrislampa_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",24),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck26_Trid0n_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",25),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck27_Ivc_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",26),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Bayesta93_SimicControl_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",27),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_quinniac_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",28),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_Team5c_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",29),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck31_SonsoJF_HeliodCombo_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",30),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Savok_BlueTron_U()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-04-19",31),
                new PostIkoria(),
                ArchetypeColor.U,
                typeof(Tron),
                typeof(BlueTron),
                null
            );
        }


    }
}
