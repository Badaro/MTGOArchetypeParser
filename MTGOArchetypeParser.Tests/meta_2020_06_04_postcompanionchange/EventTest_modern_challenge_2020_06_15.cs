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
#01 hugo87: GiftsStorm (UR)
#02 toondoslav: Dredge (BRG)
#03 Janh: SultaiControl (UBG)
#04 SebastianStueckl: Dredge (BRG)
#05 PRGJJAR: Dredge (BRG)
#06 ecobaronen: GruulMidrange (RG)
#07 TheSouthDakota: Dredge (BRG)
#08 Lord_Beerus: Burn (WR)
#09 NorrathDecay: Burn (WR)
#10 Xenowan: Inverter (UB)
#11 signblindman: GruulMidrange (RG)
#12 Walka: BantControl (WUG)
#13 Diatomic: SultaiControl (UBG)
#14 litianshuo670: OrzhovEldraziTaxes (WB)
#15 SkiLwrAp: ETron (C)
#16 ZYURYO: WUBGControl (WUBG)
#17 Xwhale: BantControl (WUG)
#18 JB2002: BantBlink (WUG, Yorion)
#19 swff: WUBGControl (WUBG)
#20 Granham: JundMidrange (BRG)
#21 MadMaxErnst: Uroza (URG)
#22 bobthedog: SultaiControl (UBG)
#23 gyyby297: ThopterUrza (UB)
#24 coert: GTron (G)
#25 Magicofplayer1: EsperControl (WUB)
#26 sff_mtg: GruulMidrange (RG)
#27 musasabi: Humans (WUBRG)
#28 _Batutinha_: BantControl (WUG)
#29 Damgar: ETron (C)
#30 j_money10: BantControl (WUG)
#31 ilsecco14: GruulMidrange (RG)
#32 Mallik7D: GiftsStorm (UR)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_06_04_postcompanionchange
{
    public class EventTest_modern_challenge_2020_06_15 : EventTest
    {
        [Test]
        public void Deck01_hugo87_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",0),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck02_toondoslav_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",1),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Janh_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",2),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck04_SebastianStueckl_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",3),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck05_PRGJJAR_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",4),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck06_ecobaronen_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",5),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck07_TheSouthDakota_Dredge_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",6),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck08_LordBeerus_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",7),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck09_NorrathDecay_Burn_WR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",8),
                new PostCompanionChange(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Xenowan_Inverter_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",9),
                new PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(Inverter),
                null,
                null
            );
        }

        [Test]
        public void Deck11_signblindman_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",10),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Walka_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",11),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Diatomic_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",12),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_litianshuo670_OrzhovEldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",13),
                new PostCompanionChange(),
                ArchetypeColor.WB,
                typeof(GenericEldraziTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck15_SkiLwrAp_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",14),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck16_ZYURYO_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",15),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck17_Xwhale_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",16),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck18_JB2002_BantBlink_WUG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",17),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericBlink),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck19_swff_WUBGControl_WUBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",18),
                new PostCompanionChange(),
                ArchetypeColor.WUBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Granham_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",19),
                new PostCompanionChange(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck21_MadMaxErnst_Uroza_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",20),
                new PostCompanionChange(),
                ArchetypeColor.URG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck22_bobthedog_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",21),
                new PostCompanionChange(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck23_gyyby297_ThopterUrza_UB()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",22),
                new PostCompanionChange(),
                ArchetypeColor.UB,
                typeof(ThopterUrza),
                null,
                null
            );
        }

        [Test]
        public void Deck24_coert_GTron_G()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",23),
                new PostCompanionChange(),
                ArchetypeColor.G,
                typeof(GTron),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Magicofplayer1_EsperControl_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",24),
                new PostCompanionChange(),
                ArchetypeColor.WUB,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck26_sffmtg_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",25),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck27_musasabi_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",26),
                new PostCompanionChange(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Batutinha_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",27),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Damgar_ETron_C()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",28),
                new PostCompanionChange(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck30_jmoney10_BantControl_WUG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",29),
                new PostCompanionChange(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck31_ilsecco14_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",30),
                new PostCompanionChange(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Mallik7D_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-06-15",31),
                new PostCompanionChange(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }


    }
}
