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
#01 Blinkmoth-Nexus: Dredge (BRG)
#02 __matsugan: Neobrand (UG)
#03 kanister: Jund Shadow (BRG)
#04 ecobaronen: Bant Control (WUG)
#05 ZYURYO: Bant Control (WUG)
#06 Asmodean1990: Jund Midrange (BRG)
#07 PRGJJAR: Dredge (BRG)
#08 CReactor: Eldrazi Tron (C)
#09 NightKnight131: Devoted (WBG)
#10 _IlNano_: Merfolk (UG)
#11 MATTHEWFOULKES: Jund Shadow (BRG)
#12 Fnoop: Inverter Combo (WUB)
#13 offline: Thopter Urza (UB)
#14 WuYuHsien: Bant Control (WUG)
#15 ChillingLauge: Dredge (BRG)
#16 Just_Roll: Eldrazi Tron (C)
#17 _Shatun_: Mono Red Prowess (R)
#18 Saviall: Green Tron (G)
#19 MissTrigger: Neobrand (UG)
#20 lSoLlAKirA: Thopter Urza (UB)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_01_17_posttherosbeyonddeath
{
    public class EventTest_modern_preliminary_2020_02_26 : EventTest
    {
        [Test]
        public void Deck01_BlinkmothNexus_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-26",0),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck02_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-26",1),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck03_kanister_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-26",2),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck04_ecobaronen_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-26",3),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_ZYURYO_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-26",4),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Asmodean1990_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-26",5),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-26",6),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck08_CReactor_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-26",7),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck09_NightKnight131_Devoted_WBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-26",8),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WBG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck10_IlNano_Merfolk_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-26",9),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Merfolk),
                null,
                null
            );
        }

        [Test]
        public void Deck11_MATTHEWFOULKES_JundShadow_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-26",10),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Fnoop_InverterCombo_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-26",11),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUB,
                typeof(InverterCombo),
                null,
                null
            );
        }

        [Test]
        public void Deck13_offline_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-26",12),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }

        [Test]
        public void Deck14_WuYuHsien_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-26",13),
                new PostTherosBeyondDeath(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck15_ChillingLauge_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-26",14),
                new PostTherosBeyondDeath(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck16_JustRoll_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-26",15),
                new PostTherosBeyondDeath(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck17_Shatun_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-26",16),
                new PostTherosBeyondDeath(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Saviall_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-26",17),
                new PostTherosBeyondDeath(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                null
            );
        }

        [Test]
        public void Deck19_MissTrigger_Neobrand_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-26",18),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck20_lSoLlAKirA_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-02-26",19),
                new PostTherosBeyondDeath(),
                ArchetypeColor.UB,
                typeof(ThopterCombo),
                typeof(ThopterUrza),
                null
            );
        }


    }
}
