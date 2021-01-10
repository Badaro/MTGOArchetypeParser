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
#01 madechai: Thopter Urza (UBG)
#02 damatoexp: Gifts Storm (URG)
#03 axk2: Neobrand (UG)
#04 abombdiggity: Primeval Titan (UG)
#05 Xwhale: Neobrand (UG)
#06 PRGJJAR: Dredge (BRG)
#07 Icteridae: Heliod Combo (WBG)
#08 Searzist: Mono Red Prowess (R)
#09 uwata: Gifts Storm (UR)
#10 clockzombie: WURG Control (WURG)
#11 joker10289: WURG Control (WURG)
#12 SourceOdin: Amulet Titan (G)
#13 Nammersquats: Mono Red Prowess (R)
#14 thugnificent32: Amulet Titan (UG)
#15 CReactor: Dredge (BRG)
#16 stonepeanut: Green Tron (G)
#17 Uvenwraith: Amulet Titan (UG)
#18 irakias: Gifts Storm (URG)
#19 sps: WURG Control (WURG)
#20 qbturtle15: Azorius Control (WU)
#21 Lord_Beerus: Azorius Control (WU)
#22 wisnudel: Primeval Titan (UG)
#23 AlphaFrog: Titan Shift (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_01_28 : EventTest
    {
        [Test]
        public void Deck01_madechai_ThopterUrza_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBG,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck02_damatoexp_GiftsStorm_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.URG,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck03_axk2_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck04_abombdiggity_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Xwhale_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck06_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Icteridae_HeliodCombo_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBG,
                typeof(HeliodCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck08_Searzist_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck09_uwata_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck10_clockzombie_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_joker10289_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck12_SourceOdin_AmuletTitan_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck13_Nammersquats_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck14_thugnificent32_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck15_CReactor_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck16_stonepeanut_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",15),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck17_Uvenwraith_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",16),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck18_irakias_GiftsStorm_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",17),
                new PostTherosBeyondDeath(),
                ArchetypeColor.URG,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck19_sps_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",18),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_qbturtle15_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",19),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck21_LordBeerus_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",20),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck22_wisnudel_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",21),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck23_AlphaFrog_TitanShift_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-01-28",22),
                new PostTherosBeyondDeath(),
                ArchetypeColor.RG,
                typeof(PrimevalTitan),
                typeof(TitanShift),
                null
            );
        }


    }
}
