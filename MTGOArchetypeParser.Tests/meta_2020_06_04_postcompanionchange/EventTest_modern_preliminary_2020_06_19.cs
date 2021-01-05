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
#01 _Shatun_: Gruul Midrange (RG)
#02 MrJACEone: Crabvine (UBG)
#03 qbturtle15: Gruul Midrange (RG, Obosh)
#04 staples87: Eldrazi Tron (C)
#05 PeanutBrittle: Thopter Urza (UBR)
#06 billsive: Bant Control (WUG, Yorion)
#07 no_lyfe: Mono Red Prowess (R)
#08 BoltTheBirds: Gifts Storm (UR)
#09 BaronOfBacon: Humans (WUBRG)
#10 joetru: Niv To Light (WUBRG)
#11 ManavonRX: Rakdos Midrange (BR)
#12 lovealienzzz: Temur Control (URG)
#13 eggybenny: Neobrand (UG)
#14 erose199423: Thopter Urza (WU)
#15 rn17: Thopter Urza (UB)
#16 Boin: Gruul Midrange (RG)
#17 Jositoshekel: Bogles (WG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_preliminary_2020_06_19 : EventTest
    {
        [Test]
        public void Deck01_Shatun_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",0),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_MrJACEone_Crabvine_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",1),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(Crabvine),
                null,
                null
            );
        }

        [Test]
        public void Deck03_qbturtle15_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",2),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck04_staples87_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",3),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck05_PeanutBrittle_ThopterUrza_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",4),
                new PostCompanionChange(),
                ArchetypeColor.UBR,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck06_billsive_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",5),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck07_nolyfe_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",6),
                new PostCompanionChange(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck08_BoltTheBirds_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",7),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck09_BaronOfBacon_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",8),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck10_joetru_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",9),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck11_ManavonRX_RakdosMidrange_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",10),
                new PostCompanionChange(),
                ArchetypeColor.BR,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_lovealienzzz_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",11),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_eggybenny_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",12),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck14_erose199423_ThopterUrza_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",13),
                new PostCompanionChange(),
                ArchetypeColor.WU,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck15_rn17_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",14),
                new PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Boin_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",15),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Jositoshekel_Bogles_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-19",16),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }


    }
}
