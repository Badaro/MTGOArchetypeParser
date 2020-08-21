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
#01 Lavaridge: TemurReclamation (URG)
#02 Magicofplayer1: Dredge (WBRG)
#03 _Falcon_: IzzetProwess (UR)
#04 E_Kaminuma: ETron (C)
#05 ScreenwriterNY: DeathAndTaxes (WU)
#06 ArchaeusDota: KGCTron (G)
#07 Zar0s: Scapeshift (URG)
#08 komattaman: Ponza (RG)
#09 Lukas261997: AzoriusStoneblade (WU)
#10 moyashi0904: TemurReclamation (URG)
#11 johnsmith3373: IzzetProwess (UR)
#12 CrusherBotBG: HammerTime (W)
#13 ktmr-39: SnowReclamation (UBG)
#14 siomomi: ETron (C)
#15 Wuhsa: BringToNiv (WUBRG)
#16 _Shatun_: Prowess (R)
#17 Littlemastercz: GruulEldrazi (RG)
#18 Goteo: Dredge (BRG)
#19 duofanel: Jund (BRG)
#20 nk0913: IzzetProwess (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_07_29 : EventTest
    {
        [Test]
        public void Deck01_Lavaridge_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",0),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(WildernessReclamation),
                typeof(TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck02_Magicofplayer1_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Falcon_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck04_EKaminuma_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",3),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck05_ScreenwriterNY_DeathAndTaxes_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck06_ArchaeusDota_GTron_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",5),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck07_Zar0s_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",6),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck08_komattaman_Ponza_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",7),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Lukas261997_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck10_moyashi0904_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",9),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(WildernessReclamation),
                typeof(TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck11_johnsmith3373_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",10),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck12_CrusherBotBG_HammerTime_W()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",11),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck13_ktmr39_SnowControl_SnowReclamation_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SnowReclamation),
                null
            );
        }

        [Test]
        public void Deck14_siomomi_ETron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",13),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Wuhsa_BringToNiv_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Shatun_Prowess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",15),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Littlemastercz_GruulEldrazi_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",16),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GruulEldrazi),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Goteo_Dredge_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",17),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck19_duofanel_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",18),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck20_nk0913_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",19),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }


    }
}
