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
#01 lSoLlAKirA: Thopter Urza (UB)
#02 AlabasterWolfie: Grinding Breach (UBR)
#03 Trellon: Blue Tron (U)
#04 infernflo: Bant Blink (WUG)
#05 azureu09: Ad Nauseam (WUB)
#06 Rvng: Eldrazi Tron (C)
#07 E_Kaminuma: Devoted (WG)
#08 PRGJJAR: Dredge (BRG)
#09 Sam_Lewin: Skelementals (BR)
#10 ZYURYO: Bant Control (WUG)
#11 NorrathDecay: Green Tron (G)
#12 triosk: Jund Midrange (BRG)
#13 HannoLee: Uroza (URG)
#14 Lavaridge: Bant Control (WUG)
#15 Cherryxman: Eldrazi Tron (C)
#16 Mou: Eldrazi Tron (G)
#17 r0310: Bant Control (WUG)
#18 im2g00t4ubarn: Uroza (UG)
#19 coert: Devoted (WBG)
#20 J000111: Dredge (BRG)
#21 mindcandy: Grinding Breach (WUBR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_03_11 : EventTest
    {
        [Test]
        public void Deck01_lSoLlAKirA_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-11",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck02_AlabasterWolfie_GrindingBreach_UBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-11",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UBR,
                typeof(GrindingBreach),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Trellon_BlueTron_U()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-11",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.U,
                typeof(Tron),
                typeof(BlueTron),
                null
            );
        }

        [Test]
        public void Deck04_infernflo_BantBlink_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-11",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                null
            );
        }

        [Test]
        public void Deck05_azureu09_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-11",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Rvng_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-11",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck07_EKaminuma_Devoted_WG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-11",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck08_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-11",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck09_SamLewin_Skelementals_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-11",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BR,
                typeof(Skelementals),
                null,
                null
            );
        }

        [Test]
        public void Deck10_ZYURYO_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-11",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_NorrathDecay_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-11",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck12_triosk_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-11",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_HannoLee_Uroza_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-11",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Lavaridge_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-11",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Cherryxman_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-11",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck16_Mou_EldraziTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-11",15),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck17_r0310_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-11",16),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_im2g00t4ubarn_Uroza_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-11",17),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck19_coert_Devoted_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-11",18),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck20_J000111_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-11",19),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck21_mindcandy_GrindingBreach_WUBR()
        {
            Test(
                GetDeck("modern-preliminary-2020-03-11",20),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUBR,
                typeof(GrindingBreach),
                null,
                null
            );
        }


    }
}
