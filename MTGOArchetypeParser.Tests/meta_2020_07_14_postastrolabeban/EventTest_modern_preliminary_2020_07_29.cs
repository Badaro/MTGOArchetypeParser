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
#01 Lavaridge: Temur Control (URG)
#02 Magicofplayer1: Dredge (WBRG)
#03 _Falcon_: Izzet Prowess (UR)
#04 E_Kaminuma: Eldrazi Tron (C)
#05 ScreenwriterNY: Azorius Taxes (WU)
#06 ArchaeusDota: Green Tron (G)
#07 Zar0s: Scapeshift (URG)
#08 komattaman: Gruul Midrange (RG)
#09 Lukas261997: Azorius Control (WU)
#10 moyashi0904: Temur Control (URG)
#11 johnsmith3373: Izzet Prowess (UR)
#12 CrusherBotBG: Hammer Time (W)
#13 ktmr-39: Sultai Control (UBG)
#14 siomomi: Eldrazi Tron (C)
#15 Wuhsa: Niv To Light (WUBRG)
#16 _Shatun_: Mono Red Prowess (R)
#17 Littlemastercz: Green Eldrazi (RG)
#18 Goteo: Dredge (BRG)
#19 duofanel: Jund Midrange (BRG)
#20 nk0913: Izzet Prowess (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_07_29 : EventTest
    {
        [Test]
        public void Deck01_Lavaridge_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",0),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
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
        public void Deck03_Falcon_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",2),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck04_EKaminuma_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",3),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck05_ScreenwriterNY_AzoriusTaxes_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck06_ArchaeusDota_GreenTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",5),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
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
        public void Deck08_komattaman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",7),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Lukas261997_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",8),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck10_moyashi0904_TemurControl_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",9),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_johnsmith3373_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",10),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
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
        public void Deck13_ktmr39_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",12),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_siomomi_EldraziTron_C()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",13),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck15_Wuhsa_NivToLight_WUBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Shatun_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",15),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Littlemastercz_GreenEldrazi_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",16),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GreenEldrazi),
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
        public void Deck19_duofanel_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",18),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck20_nk0913_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-07-29",19),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }


    }
}
