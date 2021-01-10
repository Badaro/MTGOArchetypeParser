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
#01 Gigy: Gruul Midrange (RG, Obosh)
#02 Coly2: Gruul Midrange (RG, Obosh)
#03 Magicofplayer1: Jeskai Control (WUR, Yorion)
#04 DreamsOfAshiok: Eldrazi Tron (C)
#05 kanister: Scapeshift (WUBRG, Yorion)
#06 Lavaridge: UBRG Control (UBRG, Lurrus)
#07 Laplasjan: Devoted (WG, Lurrus)
#08 ArchaeusDota: Green Tron (G, Jegantha)
#09 12Days: Jund Midrange (BRG, Obosh)
#10 eresopacaso: Eldrazi Tron (C)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_05_30 : EventTest
    {
        [Test]
        public void Deck01_Gigy_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-30",0),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck02_Coly2_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-30",1),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck03_Magicofplayer1_JeskaiControl_WUR_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-30",2),
                new PostIkoria(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck04_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-30",3),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck05_kanister_Scapeshift_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-30",4),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_Lavaridge_UBRGControl_UBRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-30",5),
                new PostIkoria(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-30",6),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_ArchaeusDota_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-30",7),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck09_12Days_JundMidrange_BRG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-30",8),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck10_eresopacaso_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-30",9),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }


    }
}
