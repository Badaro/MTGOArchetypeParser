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
#01 DreamsOfAshiok: Eldrazi Tron (C)
#02 mark_68: Bogles (WG, Lurrus)
#03 Icteridae: Dice Factory Tron (C)
#04 Xwhale: Eldrazi Tron (C)
#05 xfile: Golgari Midrange (BG, Lurrus)
#06 yamakiller: Ad Nauseam (WUB)
#07 Wartico1: Mardu Prowess (WBR, Lurrus)
#08 Lord_of_Puntlantis: Electro Balance (UR)
#09 grahams: Green Tron (G)
#10 AvocadoToast: Jund Prowess (BRG, Lurrus)
#11 ilton: Niv To Light (WUBRG, Jegantha)
#12 MrZarukai: Ad Nauseam (WUB)
#13 joker10289: Mardu Prowess (WBR, Lurrus)
#14 Parrit: Hardened Scales (BG, Lurrus)
#15 Dai1412: Bogles (WG, Lurrus)
#16 Naisirc: Rakdos Prowess (BR, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_05_21 : EventTest
    {
        [Test]
        public void Deck01_DreamsOfAshiok_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-21",0),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck02_mark68_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-21",1),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Icteridae_DiceFactoryTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-21",2),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(DiceFactoryTron),
                null
            );
        }

        [Test]
        public void Deck04_Xwhale_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-21",3),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck05_xfile_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-21",4),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_yamakiller_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-21",5),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Wartico1_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-21",6),
                new PostIkoria(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_LordofPuntlantis_ElectroBalance_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-21",7),
                new PostIkoria(),
                ArchetypeColor.UR,
                typeof(FreeSpells),
                typeof(ElectroBalance),
                null
            );
        }

        [Test]
        public void Deck09_grahams_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-21",8),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck10_AvocadoToast_JundProwess_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-21",9),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_ilton_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-21",10),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck12_MrZarukai_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-21",11),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck13_joker10289_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-21",12),
                new PostIkoria(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Parrit_HardenedScales_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-21",13),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(HardenedScales),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_Dai1412_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-21",14),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_Naisirc_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-21",15),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}
