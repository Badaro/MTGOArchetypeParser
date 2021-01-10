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
#01 VTCLA: Urza Oko (UG)
#02 bolov0: Primeval Titan (UG)
#03 sandydogmtg: Burn (R)
#04 Brunister: Eldrazi Tron (C)
#05 GodlikeNg: Mono Red Prowess (R)
#06 SourceOdin: Urza Oko (UG)
#07 Broniak: Titan Shift (RG)
#08 Bayesta_93: Urza Oko (UG)
#09 im2g00t4ubarn: Primeval Titan (UG)
#10 u_mad_bro: Bant Control (WUG)
#11 xXLogosXx: Green Devotion (G)
#12 rage_hs: Eldrazi Tron (C)
#13 chaba_lol: Crabvine (UBG)
#14 Elias: Urza Oko (UG)
#15 ThomasH: Green Tron (G)
#16 _goblinlackey: Primeval Titan (UG)
#17 Ajani89: Amulet Titan (RG)
#18 Pooka311: Titan Shift (RG)
#19 dillyg10: Eldrazi Tron (C)
#20 bigjc00: Amulet Titan (UG)
#21 ScriptKip: Burn (WR)
#22 Daniel_Garcia: Gruul Midrange (RG)
#23 ItsukiS: Amulet Titan (UG)
#24 KO_Mak: Tunnel Moon (RG)
#25 CharlesBukowski: Amulet Titan (WUG)
#26 AKA_SHIN: Eldrazi Tron (C)
#27 pepeisra: Urza Oko (UG)
#28 Graciasportanto: Urza Oko (UG)
#29 Griselpuff: Eldrazi Tron (G)
#30 tagosaku: Burn (WR)
#31 _IlNano_: Humans (WUBRG)
#32 bernardocssa: Humans (WUBRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_mocs_2019_12_29 : EventTest
    {
        [Test]
        public void Deck01_VTCLA_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",0),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck02_bolov0_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",1),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck03_sandydogmtg_Burn_R()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",2),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck04_Brunister_EldraziTron_C()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",3),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck05_GodlikeNg_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",4),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck06_SourceOdin_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",5),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Broniak_TitanShift_RG()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",6),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck08_Bayesta93_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",7),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck09_im2g00t4ubarn_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",8),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck10_umadbro_BantControl_WUG()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",9),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_xXLogosXx_GreenDevotion_G()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",10),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(GreenDevotion),
                null,
                null
            );
        }

        [Test]
        public void Deck12_ragehs_EldraziTron_C()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",11),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck13_chabalol_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",12),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Elias_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",13),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck15_ThomasH_GreenTron_G()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",14),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck16_goblinlackey_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",15),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Ajani89_AmuletTitan_RG()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",16),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck18_Pooka311_TitanShift_RG()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",17),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }

        [Test]
        public void Deck19_dillyg10_EldraziTron_C()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",18),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck20_bigjc00_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",19),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck21_ScriptKip_Burn_WR()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",20),
                new LastOkoDays(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck22_DanielGarcia_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",21),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck23_ItsukiS_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",22),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck24_KOMak_TunnelMoon_RG()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",23),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(TunnelMoon),
                null,
                null
            );
        }

        [Test]
        public void Deck25_CharlesBukowski_AmuletTitan_WUG()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",24),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck26_AKASHIN_EldraziTron_C()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",25),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck27_pepeisra_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",26),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Graciasportanto_UrzaOko_UG()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",27),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(UrzaOko),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Griselpuff_EldraziTron_G()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",28),
                new LastOkoDays(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck30_tagosaku_Burn_WR()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",29),
                new LastOkoDays(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck31_IlNano_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",30),
                new LastOkoDays(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck32_bernardocssa_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-mocs-2019-12-29",31),
                new LastOkoDays(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }


    }
}
