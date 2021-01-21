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
#01 romanmy: Thopter Urza (WUB)
#02 SunofNothing: Uroza (URG)
#03 sicsmoo: Eldrazi Tron (C)
#04 _goblinlackey: Dredge (BRG)
#05 Marxelo: Humans (WUBRG)
#06 azax: Neobrand (UG)
#07 lsv: Bant Control (WUG)
#08 shadow_PT: Gruul Midrange (RG)
#09 bomberboss: Burn (WR)
#10 Dalbert: Mono Red Prowess (R)
#11 baconator5000: Mono Red Prowess (R)
#12 Finalnub: Neobrand (UG)
#13 NorrathDecay: Green Tron (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_04_17_2 : EventTest
    {
        [Test]
        public void Deck01_romanmy_ThopterUrza_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",0),
                "PostOuatBan",
                ArchetypeColor.WUB,
                "ThopterCombo",
                "ThopterUrza",
                null
            );
        }

        [Test]
        public void Deck02_SunofNothing_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",1),
                "PostOuatBan",
                ArchetypeColor.URG,
                "Uroza",
                null,
                null
            );
        }

        [Test]
        public void Deck03_sicsmoo_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",2),
                "PostOuatBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck04_goblinlackey_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",3),
                "PostOuatBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck05_Marxelo_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",4),
                "PostOuatBan",
                ArchetypeColor.WUBRG,
                "Humans",
                null,
                null
            );
        }

        [Test]
        public void Deck06_azax_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",5),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck07_lsv_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",6),
                "PostOuatBan",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck08_shadowPT_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",7),
                "PostOuatBan",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                null
            );
        }

        [Test]
        public void Deck09_bomberboss_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",8),
                "PostOuatBan",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                null
            );
        }

        [Test]
        public void Deck10_Dalbert_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",9),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck11_baconator5000_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",10),
                "PostOuatBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck12_Finalnub_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",11),
                "PostOuatBan",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck13_NorrathDecay_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",12),
                "PostOuatBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }


    }
}
