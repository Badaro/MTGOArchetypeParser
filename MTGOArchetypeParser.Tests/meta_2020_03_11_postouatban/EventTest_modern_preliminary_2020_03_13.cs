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
#01 MaLiam: Jund Midrange (BRG)
#02 Nage051: Humans (WUBRG)
#03 NorrathDecay: Green Tron (G)
#04 frilund: Temur Control (URG)
#05 GoodDay: Bant Blink (WUG)
#06 kiteon: Devoted (WBG)
#07 Kitchen_Finks: Esper Control (WUB)
#08 yamakiller: Eldrazi Tron (C)
#09 johnyvolta: Kiki Chord (WURG)
#10 Catjack: Dredge (BRG)
#11 TSPJendrek: Bant Control (WUG)
#12 SakeIzumo: Mono Red Prowess (R)
#13 Shrugbug: Eldrazi Tron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_preliminary_2020_03_13 : EventTest
    {
        [Test]
        public void Deck01_MaLiam_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-13",0),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Nage051_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-13",1),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck03_NorrathDecay_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-13",2),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck04_frilund_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-13",3),
                new PostOuatBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_GoodDay_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-13",4),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck06_kiteon_Devoted_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-13",5),
                new PostOuatBan(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck07_KitchenFinks_EsperControl_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-13",6),
                new PostOuatBan(),
                ArchetypeColor.WUB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck08_yamakiller_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-13",7),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck09_johnyvolta_KikiChord_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-13",8),
                new PostOuatBan(),
                ArchetypeColor.WURG,
                typeof(KikiChord),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Catjack_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-13",9),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck11_TSPJendrek_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-13",10),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_SakeIzumo_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-13",11),
                new PostOuatBan(),
                ArchetypeColor.R,
                typeof(RedAggro),
                typeof(Prowess),
                null
            );
        }

        [Test]
        public void Deck13_Shrugbug_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-13",12),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }


    }
}
