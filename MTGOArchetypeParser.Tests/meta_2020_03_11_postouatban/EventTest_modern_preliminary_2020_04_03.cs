using FluentAssertions;
using MTGOArchetypeParser.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/*
#01 Fluorspar: Humans (WUBRG)
#02 Bomboleriot: Dredge (BRG)
#03 envizz: Gruul Midrange (RG)
#04 ForThoseWhoHaveHeart: Bant Control (WUG)
#05 ArchaeusDota: Eldrazi Tron (R)
#06 penips: Orzhov Taxes (WB)
#07 wumbowizard: Azorius Control (WU)
#08 signblindman: Gruul Midrange (RG)
#09 Sorph: Uroza (URG)
#10 baconator5000: Mono Red Prowess (R)
#11 rinazina: Green Tron (G)
#12 BSK_hercules: Gruul Midrange (RG)
#13 Snaps_The_Mad: Gruul Midrange (RG)
#14 PRGJJAR: Dredge (BRG)
#15 Higdur: Infect (UG)
#16 Zack12354: Uroza (URG)
#17 jumaygo: Bogles (WG)
#18 jvidarte: Mono Red Prowess (R)
#19 kastermester: Jund Midrange (BRG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_04_03 : EventTest
    {
        [Test]
        public void Deck01_Fluorspar_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-03",0),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck02_Bomboleriot_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-03",1),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck03_envizz_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-03",2),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck04_ForThoseWhoHaveHeart_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-03",3),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck05_ArchaeusDota_EldraziTron_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-03",4),
                "PostOuatBan",
                ArchetypeColor.R,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck06_penips_OrzhovTaxes_WB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-03",5),
                "PostOuatBan",
                ArchetypeColor.WB,
                "GenericTaxes",
                null,
                null
            );
        }

        [Test]
        public void Deck07_wumbowizard_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-03",6),
                "PostOuatBan",
                ArchetypeColor.WU,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_signblindman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-03",7),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_Sorph_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-03",8),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck10_baconator5000_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-03",9),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck11_rinazina_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-03",10),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }

        [Test]
        public void Deck12_BSKhercules_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-03",11),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck13_SnapsTheMad_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-03",12),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck14_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-03",13),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck15_Higdur_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-03",14),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Infect",
                null,
                null
            );
        }

        [Test]
        public void Deck16_Zack12354_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-03",15),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck17_jumaygo_Bogles_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-03",16),
                "PostOuatBan",
                ArchetypeColor.WG,
                "Bogles",
                null,
                null
            );
        }

        [Test]
        public void Deck18_jvidarte_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-03",17),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck19_kastermester_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-03",18),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "GenericMidrange",
                null,
                null
            );
        }


    }
}
