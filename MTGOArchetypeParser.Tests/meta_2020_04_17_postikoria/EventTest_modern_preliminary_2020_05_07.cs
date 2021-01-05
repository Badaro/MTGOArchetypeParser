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
#01 Icteridae: Devoted (WUG)
#02 KelMasterP: Gruul Midrange (RG, Obosh)
#03 Nammersquats: Humans (WUBRG)
#04 patrick50: Devoted (WG, Lurrus)
#05 Toastxp: Bant Blink (WUG, Yorion)
#06 karatedom: Devoted (WG, Lurrus)
#07 Xwhale: Primeval Titan (UG)
#08 3minem: Jund Midrange (BRG, Lurrus)
#09 twinlesstwin: Temur Control (URG)
#10 TerminalJustice: Devoted (WG, Lurrus)
#11 evan_ralston: Bant Control (WUG, Yorion)
#12 HarlanMTG: Grixis Prowess (UBR, Lurrus)
#13 Bishark: Merfolk (WU, Lurrus)
#14 maximusdee: Golgari Midrange (BG, Lurrus)
#15 Berserker_BOB: Amulet Titan (URG)
#16 MdvWin: Hammer Time (WR, Lurrus)
#17 Ouranos139: Amulet Titan (UG)
#18 Papelucho10: Infect (WUG, Lurrus)
#19 slow_brz: Infect (WG, Lurrus)
#20 Sodeq: Ad Nauseam (WUB)
#21 cws: Boros Prowess (WR, Lurrus)
#22 __matsugan: Bogles (WG, Lurrus)
#23 SunofNothing: Uroza (URG, Yorion)
#24 maxxattack: Infect (UG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_preliminary_2020_05_07 : EventTest
    {
        [Test]
        public void Deck01_Icteridae_Devoted_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",0),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck02_KelMasterP_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",1),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck03_Nammersquats_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",2),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck04_patrick50_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",3),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck05_Toastxp_BantBlink_WUG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",4),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_karatedom_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",5),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_Xwhale_PrimevalTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",6),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck08_3minem_JundMidrange_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",7),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_twinlesstwin_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",8),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_TerminalJustice_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",9),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_evanralston_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",10),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck12_HarlanMTG_GrixisProwess_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",11),
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(ThopterCombo),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_Bishark_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",12),
                new PostIkoria(),
                ArchetypeColor.WU,
                typeof(Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_maximusdee_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",13),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck15_BerserkerBOB_AmuletTitan_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",14),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck16_MdvWin_HammerTime_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",15),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(HammerTime),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_Ouranos139_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",16),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck18_Papelucho10_Infect_WUG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",17),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(Infect),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_slowbrz_Infect_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",18),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Infect),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_Sodeq_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",19),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck21_cws_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",20),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck22_matsugan_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",21),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_SunofNothing_Uroza_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",22),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck24_maxxattack_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-05-07",23),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }


    }
}
