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
#01 Zonast: Delver (UBR, Lurrus)
#02 __BMJ__: Jund Shadow (BRG, Lurrus)
#03 Laplasjan: Devoted (WG, Lurrus)
#04 Traft: Ad Nauseam (WUB)
#05 PietroSas: Jund Shadow (BRG, Lurrus)
#06 FalseMufn: Amulet Titan (UG)
#07 pbarrrgh: Bant Control (WUG, Yorion)
#08 WingedHussar: Neobrand (UG)
#09 bolov0: Rakdos Prowess (BR, Lurrus)
#10 RNGspecialist: Jund Shadow (BRG, Lurrus)
#11 TwistedWombat: Niv To Light (WUBRG, Jegantha)
#12 MatiCheto: Niv To Light (WUBRG, Jegantha)
#13 Namkrew___Lacsap: Burn (WR, Lurrus)
#14 brunocaleb: Gruul Midrange (RG, Obosh)
#15 Add1ct3d: Jund Shadow (BRG, Lurrus)
#16 ElYallo: Green Tron (G, Jegantha)
#17 Justodeangelo: Rakdos Prowess (BR, Lurrus)
#18 Phill_Hellmuth: Scapeshift (URG, Yorion)
#19 MadMaxErnst: Rakdos Prowess (BR, Lurrus)
#20 Toastxp: Jund Shadow (BRG, Lurrus)
#21 ilidioTheBrabo157SL: Ad Nauseam (WUB)
#22 oskiyaa: Devoted (WG, Lurrus)
#23 SunofNothing: Jund Shadow (BRG, Lurrus)
#24 Gul_Dukat: Golgari Midrange (BG, Lurrus)
#25 mephidro: Neobrand (WUG)
#26 jvidarte: Burn (WR, Lurrus)
#27 DFrank: Rakdos Prowess (BR, Lurrus)
#28 Mateusf34: Eldrazi Tron (C)
#29 Vesper35: Devoted (WG, Lurrus)
#30 maxxattack: Ad Nauseam (WUB)
#31 MeiaTola: Ad Nauseam (WUB)
#32 selbstdenker: WUBG Control (WUBG, Yorion)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_04_17_postikoria
{
    public class EventTest_modern_super_qualifier_2020_06_02 : EventTest
    {
        [Test]
        public void Deck01_Zonast_Delver_UBR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",0),
                "PostIkoria",
                ArchetypeColor.UBR,
                "Delver",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_BMJ_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",1),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",2),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Traft_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",3),
                "PostIkoria",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck05_PietroSas_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",4),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_FalseMufn_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",5),
                "PostIkoria",
                ArchetypeColor.UG,
                "PrimevalTitan",
                "AmuletTitan",
                null
            );
        }

        [Test]
        public void Deck07_pbarrrgh_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",6),
                "PostIkoria",
                ArchetypeColor.WUG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_WingedHussar_Neobrand_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",7),
                "PostIkoria",
                ArchetypeColor.UG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck09_bolov0_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",8),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_RNGspecialist_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",9),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_TwistedWombat_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",10),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck12_MatiCheto_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",11),
                "PostIkoria",
                ArchetypeColor.WUBRG,
                "NivToLight",
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck13_NamkrewLacsap_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",12),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_brunocaleb_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",13),
                "PostIkoria",
                ArchetypeColor.RG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck15_Add1ct3d_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",14),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_ElYallo_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",15),
                "PostIkoria",
                ArchetypeColor.G,
                "Tron",
                "GreenTron",
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck17_Justodeangelo_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",16),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_PhillHellmuth_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",17),
                "PostIkoria",
                ArchetypeColor.URG,
                "Scapeshift",
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_MadMaxErnst_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",18),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_Toastxp_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",19),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_ilidioTheBrabo157SL_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",20),
                "PostIkoria",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck22_oskiyaa_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",21),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_SunofNothing_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",22),
                "PostIkoria",
                ArchetypeColor.BRG,
                "Shadow",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_GulDukat_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",23),
                "PostIkoria",
                ArchetypeColor.BG,
                "GenericMidrange",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_mephidro_Neobrand_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",24),
                "PostIkoria",
                ArchetypeColor.WUG,
                "Neobrand",
                null,
                null
            );
        }

        [Test]
        public void Deck26_jvidarte_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",25),
                "PostIkoria",
                ArchetypeColor.WR,
                "RedAggro",
                "Burn",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_DFrank_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",26),
                "PostIkoria",
                ArchetypeColor.BR,
                "RedAggro",
                "Prowess",
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",27),
                "PostIkoria",
                ArchetypeColor.C,
                "Tron",
                "EldraziTron",
                null
            );
        }

        [Test]
        public void Deck29_Vesper35_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",28),
                "PostIkoria",
                ArchetypeColor.WG,
                "Devoted",
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_maxxattack_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",29),
                "PostIkoria",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck31_MeiaTola_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",30),
                "PostIkoria",
                ArchetypeColor.WUB,
                "AdNauseam",
                null,
                null
            );
        }

        [Test]
        public void Deck32_selbstdenker_WUBGControl_WUBG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",31),
                "PostIkoria",
                ArchetypeColor.WUBG,
                "GenericControl",
                null,
                ArchetypeCompanion.Yorion
            );
        }


    }
}
