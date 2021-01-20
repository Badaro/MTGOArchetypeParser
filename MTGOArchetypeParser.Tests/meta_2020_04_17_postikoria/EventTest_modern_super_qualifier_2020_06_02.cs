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
                new PostIkoria(),
                ArchetypeColor.UBR,
                typeof(Delver),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck02_BMJ_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",1),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",2),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck04_Traft_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",3),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck05_PietroSas_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",4),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck06_FalseMufn_AmuletTitan_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",5),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck07_pbarrrgh_BantControl_WUG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",6),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck08_WingedHussar_Neobrand_UG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",7),
                new PostIkoria(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck09_bolov0_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",8),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck10_RNGspecialist_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",9),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck11_TwistedWombat_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",10),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck12_MatiCheto_NivToLight_WUBRG_Jegantha()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",11),
                new PostIkoria(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck13_NamkrewLacsap_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",12),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_brunocaleb_GruulMidrange_RG_Obosh()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",13),
                new PostIkoria(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Obosh
            );
        }

        [Test]
        public void Deck15_Add1ct3d_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",14),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_ElYallo_GreenTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",15),
                new PostIkoria(),
                ArchetypeColor.G,
                typeof(Tron),
                typeof(GreenTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck17_Justodeangelo_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",16),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_PhillHellmuth_Scapeshift_URG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",17),
                new PostIkoria(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_MadMaxErnst_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",18),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck20_Toastxp_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",19),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_ilidioTheBrabo157SL_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",20),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck22_oskiyaa_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",21),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck23_SunofNothing_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",22),
                new PostIkoria(),
                ArchetypeColor.BRG,
                typeof(Shadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck24_GulDukat_GolgariMidrange_BG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",23),
                new PostIkoria(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck25_mephidro_Neobrand_WUG()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",24),
                new PostIkoria(),
                ArchetypeColor.WUG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck26_jvidarte_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",25),
                new PostIkoria(),
                ArchetypeColor.WR,
                typeof(RedAggro),
                typeof(Burn),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_DFrank_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",26),
                new PostIkoria(),
                ArchetypeColor.BR,
                typeof(RedAggro),
                typeof(Prowess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_Mateusf34_EldraziTron_C()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",27),
                new PostIkoria(),
                ArchetypeColor.C,
                typeof(Tron),
                typeof(EldraziTron),
                null
            );
        }

        [Test]
        public void Deck29_Vesper35_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",28),
                new PostIkoria(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck30_maxxattack_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",29),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck31_MeiaTola_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",30),
                new PostIkoria(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck32_selbstdenker_WUBGControl_WUBG_Yorion()
        {
            Test(
                GetDeck("modern-super-qualifier-2020-06-02",31),
                new PostIkoria(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                ArchetypeCompanion.Yorion
            );
        }


    }
}
