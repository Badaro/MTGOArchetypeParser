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
#01 haubidtran: Uroza (UG)
#02 Mercenario: Dredge (BRG)
#03 JSG-MTG: Eldrazi Tron (C)
#04 fistfullofmetal: Green Tron (G)
#05 Rooney56: Jund Midrange (BRG)
#06 SuperCow12653: Humans (WUBRG)
#07 Mateusf34: Eldrazi Tron (C)
#08 MatheusPonciano: Dredge (BRG)
#09 Do0mSwitch: Bant Control (WUG)
#10 ander_lizarrakoa: Delver (UR)
#11 ballestin93: Rakdos Midrange (BR)
#12 _Batutinha_: Bant Control (WUG)
#13 pbarrrgh: WURG Control (WURG)
#14 Hayseed: Thopter Urza (WU)
#15 Nikito18: Bant Control (WUG)
#16 in5ano: Thopter Urza (WUR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_03_11_postouatban
{
    public class EventTest_modern_premier_2020_03_16 : EventTest
    {
        [Test]
        public void Deck01_haubidtran_Uroza_UG()
        {
            Test(
                GetDeck("modern-premier-2020-03-16",0),
                new PostOuatBan(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck02_Mercenario_Dredge_BRG()
        {
            Test(
                GetDeck("modern-premier-2020-03-16",1),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck03_JSGMTG_EldraziTron_C()
        {
            Test(
                GetDeck("modern-premier-2020-03-16",2),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck04_fistfullofmetal_GreenTron_G()
        {
            Test(
                GetDeck("modern-premier-2020-03-16",3),
                new PostOuatBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck05_Rooney56_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-premier-2020-03-16",4),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck06_SuperCow12653_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-premier-2020-03-16",5),
                new PostOuatBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-premier-2020-03-16",6),
                new PostOuatBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck08_MatheusPonciano_Dredge_BRG()
        {
            Test(
                GetDeck("modern-premier-2020-03-16",7),
                new PostOuatBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Do0mSwitch_BantControl_WUG()
        {
            Test(
                GetDeck("modern-premier-2020-03-16",8),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_anderlizarrakoa_Delver_UR()
        {
            Test(
                GetDeck("modern-premier-2020-03-16",9),
                new PostOuatBan(),
                ArchetypeColor.UR,
                typeof(Delver),
                null,
                null
            );
        }

        [Test]
        public void Deck11_ballestin93_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-premier-2020-03-16",10),
                new PostOuatBan(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Batutinha_BantControl_WUG()
        {
            Test(
                GetDeck("modern-premier-2020-03-16",11),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_pbarrrgh_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-premier-2020-03-16",12),
                new PostOuatBan(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Hayseed_ThopterUrza_WU()
        {
            Test(
                GetDeck("modern-premier-2020-03-16",13),
                new PostOuatBan(),
                ArchetypeColor.WU,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck15_Nikito18_BantControl_WUG()
        {
            Test(
                GetDeck("modern-premier-2020-03-16",14),
                new PostOuatBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck16_in5ano_ThopterUrza_WUR()
        {
            Test(
                GetDeck("modern-premier-2020-03-16",15),
                new PostOuatBan(),
                ArchetypeColor.WUR,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }


    }
}
