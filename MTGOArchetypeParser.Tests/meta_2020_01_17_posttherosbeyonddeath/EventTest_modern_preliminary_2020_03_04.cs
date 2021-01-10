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
#01 kanister: Amulet Titan (G)
#02 Wurst_: WURG Control (WURG)
#03 C_E.L: Eldrazi Tron (G)
#04 Dazai: Azorius Control (WU)
#05 Kagami_Mashiro_: Eldrazi Tron (G)
#06 Patxi: Primeval Titan (BG)
#07 myst_teachings: Thopter Urza (UB)
#08 Tyerube1618: Gifts Storm (UR)
#09 lighdar: Eldrazi Tron (G)
#10 Saviall: Green Tron (G)
#11 Tiemuuu: Izzet Control (UR)
#12 jessy_samek: Amulet Titan (UG)
#13 Chipsoss: Golgari Midrange (BG)
#14 felider: Eldrazi Tron (G)
#15 gardrd: Mono Red Prowess (R)
#16 Weiden: Eldrazi Tron (G)
#17 Sam_Lewin: Skelementals (BR)
#18 fistfullofmetal: Green Tron (G)
#19 misonikomi: Devoted (WRG)
#20 harukispecial: Jeskai Control (WUR)
#21 __matsugan: Neobrand (UG)
#22 katoriarch123: Thopter Urza (UBG)
#23 siomomi: Eldrazi Tron (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_03_04 : EventTest
    {
        [Test]
        public void Deck01_kanister_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck02_Wurst_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck03_CEL_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck04_Dazai_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_KagamiMashiro_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck06_Patxi_PrimevalTitan_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck07_mystteachings_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck08_Tyerube1618_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck09_lighdar_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck10_Saviall_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck11_Tiemuuu_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_jessysamek_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck13_Chipsoss_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck14_felider_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck15_gardrd_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Weiden_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",15),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck17_SamLewin_Skelementals_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",16),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BR,
                typeof(Skelementals),
                null,
                null
            );
        }

        [Test]
        public void Deck18_fistfullofmetal_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",17),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck19_misonikomi_Devoted_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",18),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WRG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck20_harukispecial_JeskaiControl_WUR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",19),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",20),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck22_katoriarch123_ThopterUrza_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",21),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck23_siomomi_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-04",22),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }


    }
}
