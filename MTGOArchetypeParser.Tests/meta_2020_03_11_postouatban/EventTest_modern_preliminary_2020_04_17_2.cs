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
                new PostOuatBan(),
                ArchetypeColor.WUB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck02_SunofNothing_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",1),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck03_sicsmoo_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",2),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck04_goblinlackey_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",3),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Marxelo_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",4),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck06_azax_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",5),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck07_lsv_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",6),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_shadowPT_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",7),
                new PostOuatBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_bomberboss_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",8),
                new PostOuatBan(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                null
            );
        }

        [Test]
        public void Deck10_Dalbert_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",9),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck11_baconator5000_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",10),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck12_Finalnub_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",11),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck13_NorrathDecay_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-04-17-2",12),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }


    }
}
