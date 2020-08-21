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
#01 aooaaooa: Lantern (UBG)
#02 NightKnight131: Devoted (WG, Lurrus)
#03 MadCowChicken: SelesnyaEldrazi (WG, Jegantha)
#04 Frank_Bonaparte: Ponza (RG)
#05 Papelucho10: Infect (UG)
#06 Mcleskey: Burn (WR)
#07 Boland: Dredge (BRG)
#08 ghostx02: Ponza (RG)
#09 FrancusAurelius: NayaMidrange (WRG)
#10 otakkun: KGCTron (G)
#11 _Logic_: DeathsShadow (BR)
#12 2radMTG: Bogles (WG, Lurrus)
#13 lovealienzzz: SnowControl (URG)
#14 Manacymbal: KinnanUrza (URG, Yorion)
#15 signblindman: Ponza (RG)
#16 Nammersquats: Humans (WUBRG)
#17 Micro: AdNauseam (WUB)
#18 joetru: BringToNiv (WUBRG)
#19 grahams: Mill (UB)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_preliminary_2020_06_20 : EventTest
    {
        [Test]
        public void Deck01_aooaaooa_Lantern_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",0),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(Lantern),
                null,
                null
            );
        }

        [Test]
        public void Deck02_NightKnight131_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",1),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_MadCowChicken_SelesnyaEldrazi_WG_Jegantha()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",2),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(SelesnyaEldrazi),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck04_FrankBonaparte_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",3),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Papelucho10_Infect_UG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",4),
                new PostCompanionChange(),
                ArchetypeColor.UG,
                typeof(Infect),
                null,
                null
            );
        }

        [Test]
        public void Deck06_Mcleskey_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",5),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck07_Boland_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",6),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck08_ghostx02_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",7),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck09_FrancusAurelius_NayaMidrange_WRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",8),
                new PostCompanionChange(),
                ArchetypeColor.WRG,
                typeof(NayaMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck10_otakkun_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",9),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck11_Logic_DeathsShadow_BR()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",10),
                new PostCompanionChange(),
                ArchetypeColor.BR,
                typeof(DeathsShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck12_2radMTG_Bogles_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",11),
                new PostCompanionChange(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck13_lovealienzzz_SnowControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",12),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(SnowControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_Manacymbal_KinnanUrza_URG_Yorion()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",13),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(KinnanUrza),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck15_signblindman_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",14),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Nammersquats_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",15),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Micro_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",16),
                new PostCompanionChange(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck18_joetru_BringToNiv_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",17),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck19_grahams_Mill_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-06-20",18),
                new PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }


    }
}
