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
#01 mindcandy: Reclamation (URG)
#02 eXavie: Rakdos Prowess (BR, Lurrus)
#03 Snusnumrick: Eldrazi Tron (C)
#04 __matsugan: Neobrand (UG)
#05 cntrlfreak: UBRG Shadow (UBRG)
#06 tibalt_of_red_sub: Mill (UB, Lurrus)
#07 cnofafva: Amulet Titan (UG)
#08 Toastxp: Rakdos Prowess (BR, Lurrus)
#09 cws: Gifts Storm (UR)
#10 TSPJendrek: Sultai Control (UBG)
#11 mikev1919: Mono Red Prowess (R)
#12 Wuhsa: Niv To Light (WUBRG, Yorion)
#13 shub89: Izzet Prowess (UR)
#14 Rhianne: Dredge (BRG)
#15 2jjm: Izzet Prowess (UR)
#16 discoverN: Green Tron (G)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_showcase_last_chance_2020_08_11 : EventTest
    {
        [Test]
        public void Deck01_mindcandy_Reclamation_URG()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-11",0),
                "PostAstrolabeBan",
                ArchetypeColor.URG,
                "Reclamation",
                null,
                null
            );
        }

        [Test]
        public void Deck02_eXavie_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-11",1),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Snusnumrick_EldraziTron_C()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-11",2),
                "PostAstrolabeBan",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck04_matsugan_Neobrand_UG()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-11",3),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck05_cntrlfreak_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-11",4),
                "PostAstrolabeBan",
                ArchetypeColor.UBRG,
                "Shadow",
                null,
                null
            );
        }

        [Test]
        public void Deck06_tibaltofredsub_Mill_UB_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-11",5),
                "PostAstrolabeBan",
                ArchetypeColor.UB,
                "Mill",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_cnofafva_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-11",6),
                "PostAstrolabeBan",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck08_Toastxp_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-11",7),
                "PostAstrolabeBan",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_cws_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-11",8),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "GiftsStorm",
                null,
                null
            );
        }

        [Test]
        public void Deck10_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-11",9),
                "PostAstrolabeBan",
                ArchetypeColor.UBG,
                "GenericControl",
                null,
                null
            );
        }

        [Test]
        public void Deck11_mikev1919_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-11",10),
                "PostAstrolabeBan",
                ArchetypeColor.R,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck12_Wuhsa_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-11",11),
                "PostAstrolabeBan",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck13_shub89_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-11",12),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck14_Rhianne_Dredge_BRG()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-11",13),
                "PostAstrolabeBan",
                ArchetypeColor.BRG,
                "Dredge",
                null,
                null
            );
        }

        [Test]
        public void Deck15_2jjm_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-11",14),
                "PostAstrolabeBan",
                ArchetypeColor.UR,
                "RedAggro",
                "Prowess",
                null
            );
        }

        [Test]
        public void Deck16_discoverN_GreenTron_G()
        {
            Test(
                GetDeck("modern-showcase-last-chance-2020-08-11",15),
                "PostAstrolabeBan",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                null
            );
        }


    }
}
