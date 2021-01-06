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
#01 McWinSauce: Bant Control (WUG)
#02 maxxattack: Infect (UG)
#03 Erik157751: Eldrazi Tron (C)
#04 reew2n: Mono Red Prowess (R)
#05 scubypandatv: Amulet Titan (UG)
#06 SoulStrong: Sultai Shadow (UBG)
#07 MayoDomo: Infect (UG)
#08 SvenSveeterSven: Izzet Control (UR)
#09 koko_lopez: Sultai Shadow (UBG)
#10 FrancusAurelius: Gruul Midrange (RG)
#11 azax: Sultai Shadow (UBG)
#12 kanister: Amulet Titan (UG)
#13 Wolvenjoe1984: Thopter Urza (UBG)
#14 raynesobad: Simic Control (UG)
#15 zachattack23: Simic Control (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2019_12_13_lastokodays
{
    public class EventTest_modern_preliminary_2019_12_21 : EventTest
    {
        [Test]
        public void Deck01_McWinSauce_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",0),
                new LastOkoDays(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck02_maxxattack_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",1),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Erik157751_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",2),
                new LastOkoDays(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck04_reew2n_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",3),
                new LastOkoDays(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck05_scubypandatv_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",4),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck06_SoulStrong_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",5),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck07_MayoDomo_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",6),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck08_SvenSveeterSven_IzzetControl_UR()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",7),
                new LastOkoDays(),
                ArchetypeColor.UR,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck09_kokolopez_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",8),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck10_FrancusAurelius_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",9),
                new LastOkoDays(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck11_azax_SultaiShadow_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",10),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck12_kanister_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",11),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck13_Wolvenjoe1984_ThopterUrza_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",12),
                new LastOkoDays(),
                ArchetypeColor.UBG,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck14_raynesobad_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",13),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_zachattack23_SimicControl_UG()
        {
            Test(
                GetDeck("modern-preliminary-2019-12-21",14),
                new LastOkoDays(),
                ArchetypeColor.UG,
                typeof(GenericControl),
                null,
                null
            );
        }


    }
}
