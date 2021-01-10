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
#01 _EvaNs: Scapeshift (WUBRG, Yorion)
#02 Capitano_CL: Rakdos Prowess (BR, Lurrus)
#03 joker10289: WUBG Control (WUBG, Yorion)
#04 in5ano: Scapeshift (URG, Yorion)
#05 Theo_Jung: Rakdos Prowess (BR, Lurrus)
#06 karatedom: Boros Prowess (WR, Lurrus)
#07 hugo87: Gifts Storm (UR)
#08 Aphiladon: Bant Control (WUG)
#09 fried-liver-attack: Gruul Midrange (RG, Obosh)
#10 padakey: Jund Midrange (BRG, Lurrus)
#11 Icteridae: Eldrazi Tron (C)
#12 grahams: Mill (UB, Lurrus)
#13 maximusdee: Eldrazi Tron (C)
#14 CheeseburgerJim: Green Tron (G, Jegantha)
#15 aarongulevich: Rakdos Prowess (BR, Lurrus)
#16 qbturtle15: Gruul Midrange (RG, Obosh)
#17 nathansteuer: Scapeshift (URG, Yorion)
#18 Xwhale: Rakdos Prowess (BR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_05_26 : EventTest
    {
        [Test]
        public void Deck01_EvaNs_Scapeshift_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-26",0),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck02_CapitanoCL_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-26",1),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_joker10289_WUBGControl_WUBG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-26",2),
                new PostIkoria(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_in5ano_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-26",3),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck05_TheoJung_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-26",4),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_karatedom_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-26",5),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_hugo87_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-26",6),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Aphiladon_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-26",7),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_friedliverattack_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-26",8),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck10_padakey_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-26",9),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_Icteridae_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-26",10),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck12_grahams_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-26",11),
                new PostIkoria(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_maximusdee_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-26",12),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck14_CheeseburgerJim_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-26",13),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck15_aarongulevich_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-26",14),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_qbturtle15_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-26",15),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck17_nathansteuer_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-26",16),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck18_Xwhale_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-26",17),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
