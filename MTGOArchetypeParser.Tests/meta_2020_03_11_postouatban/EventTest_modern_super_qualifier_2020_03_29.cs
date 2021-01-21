using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Sharkcaster_Mage: Primeval Titan (BG)
#02 NorrathDecay: Burn (WR)
#03 Theo_Jung: Uroza (URG)
#04 TheAdonis: Dredge (BRG)
#05 Trieste: Mardu Shadow (WBR)
#06 MdvWin: Burn (WR)
#07 sff_mtg: Green Tron (G)
#08 Sodeq: Dredge (BRG)
#09 jled: UBRG Shadow (UBRG)
#10 katoriarch123: Bant Control (WUG)
#11 scipios: Dredge (BRG)
#12 Namkrew___Lacsap: Reclamation (UG)
#13 yPrincipe: Eldrazi Tron (C)
#14 musasabi: Jund Midrange (BRG)
#15 Darkiundsa: Bant Control (WUG)
#16 raisans: Dredge (BRG)
#17 ArchaeusDota: Eldrazi Tron (C)
#18 TFTIjhub: Primeval Titan (BG)
#19 otakkun: Eldrazi Tron (C)
#20 Malakxy: Bushwhacker Zoo (WRG)
#21 Misplacedginger: Bant Control (WUG)
#22 Mercenario: Dredge (UBRG)
#23 Gods_Shadow: Mono White Taxes (W)
#24 Squidbilly: Primeval Titan (UG)
#25 Mistakenn: Amulet Titan (G)
#26 iceiceice: Amulet Titan (UG)
#27 StormlightReaper: Eldrazi Tron (C)
#28 bogarden3: Humans (WUBRG)
#29 CReactor: Jund Midrange (BRG)
#30 baiburqueno: Bant Control (WUG)
#31 kthanakit26: Burn (WR)
#32 Do0mSwitch: Bant Control (WUG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_super_qualifier_2020_03_29 : EventTest
    {
        [Test]
        public void Deck01_SharkcasterMage_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",0),
                "PostOuatBan",
                ArchetypeColor.BG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck02_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",1),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck03_TheoJung_Uroza_URG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",2),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck04_TheAdonis_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",3),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Trieste_MarduShadow_WBR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",4),
                "PostOuatBan",
                ArchetypeColor.WBR,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck06_MdvWin_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",5),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck07_sffmtg_GreenTron_G()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",6),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck08_Sodeq_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",7),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck09_jled_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",8),
                "PostOuatBan",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck10_katoriarch123_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",9),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_scipios_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",10),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck12_NamkrewLacsap_Reclamation_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",11),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck13_yPrincipe_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",12),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck14_musasabi_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",13),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Darkiundsa_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",14),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck16_raisans_Dredge_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",15),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck17_ArchaeusDota_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",16),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck18_TFTIjhub_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",17),
                "PostOuatBan",
                ArchetypeColor.BG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck19_otakkun_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",18),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck20_Malakxy_BushwhackerZoo_WRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",19),
                "PostOuatBan",
                ArchetypeColor.WRG,
                "BushwhackerZoo",
                null,
                null
            );
        }

        [Test]
        public void Deck21_Misplacedginger_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",20),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck22_Mercenario_Dredge_UBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",21),
                "PostOuatBan",
                ArchetypeColor.UBRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck23_GodsShadow_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",22),
                "PostOuatBan",
                ArchetypeColor.W,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck24_Squidbilly_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",23),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                null,
                null
            );
        }

        [Test]
        public void Deck25_Mistakenn_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",24),
                "PostOuatBan",
                ArchetypeColor.G,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck26_iceiceice_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",25),
                "PostOuatBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck27_StormlightReaper_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",26),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck28_bogarden3_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",27),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck29_CReactor_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",28),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck30_baiburqueno_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",29),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck31_kthanakit26_Burn_WR()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",30),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck32_Do0mSwitch_BantControl_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-03-29",31),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }


    }
}
