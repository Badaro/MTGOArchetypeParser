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
#01 musasabi: OrzhovMidrange (WB)
#02 __matsugan: OopsAllSpells (WUBRG)
#03 Bedell: KGCAmuletTitan (URG)
#04 Bullwinkkle6705: UBRGControl (UBRG)
#05 GodOfSlaughter: BringToNiv (WUBRG, Yorion)
#06 rob85tx: IzzetProwess (UR)
#07 TuggaNaxos: Burn (WBR, Lurrus)
#08 Laplasjan: Devoted (WG, Lurrus)
#09 Morenothings: Humans (WUBRG)
#10 ZYURYO: WURGControl (WURG)
#11 qbturtle15: MonoWhiteTaxes (W)
#12 122pablo: JeskaiAscendancy (WURG, Jegantha)
#13 SoulStrong: RakdosShadow (BR, Lurrus)
#14 Sodeq: AdNauseam (WUB)
#15 Antarctica: MarduProwess (WBR, Lurrus)
#16 eggybenny: Devoted (WG, Lurrus)
#17 kiko: MonoWhiteTaxes (W)
#18 matiaskm: Devoted (WG, Lurrus)
#19 Lacansa: Humans (WUBRG)
#20 Bayesta_93: RakdosShadow (BR, Lurrus)
#21 kanister: OopsAllSpells (WUBRG)
#22 trader08111: GruulMidrange (RG)
#23 dough_shack: AmuletTitan (WUBRG)
#24 TSPJendrek: SultaiControl (UBG)
#25 Smdster: TemurControl (URG)
#26 helpfulsheep: RakdosProwess (BR, Lurrus)
#27 Disgruntled_Elk: RakdosShadow (BR, Lurrus)
#28 Side_Arms: Scapeshift (URG)
#29 Flshtoph: BringToNiv (WUBRG, Yorion)
#30 littledarwin: HammerTime (W)
#31 Metcalf23: MonoWhiteTaxes (W)
#32 HotBread: GruulMidrange (RG)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_09_16_postzendikarrising
{
    public class EventTest_modern_challenge_2020_09_27 : EventTest
    {
        [Test]
        public void Deck01_musasabi_OrzhovMidrange_WB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",0),
                new PostZendikarRising(),
                ArchetypeColor.WB,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck02_matsugan_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",1),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck03_Bedell_KGCAmuletTitan_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",2),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck04_Bullwinkkle6705_UBRGControl_UBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",3),
                new PostZendikarRising(),
                ArchetypeColor.UBRG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_GodOfSlaughter_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",4),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck06_rob85tx_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",5),
                new PostZendikarRising(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck07_TuggaNaxos_Burn_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",6),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck08_Laplasjan_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",7),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck09_Morenothings_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",8),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck10_ZYURYO_WURGControl_WURG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",9),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_qbturtle15_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",10),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck12_122pablo_JeskaiAscendancy_WURG_Jegantha()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",11),
                new PostZendikarRising(),
                ArchetypeColor.WURG,
                typeof(JeskaiAscendancy),
                null,
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck13_SoulStrong_RakdosShadow_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",12),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_Sodeq_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",13),
                new PostZendikarRising(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Antarctica_MarduProwess_WBR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",14),
                new PostZendikarRising(),
                ArchetypeColor.WBR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck16_eggybenny_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",15),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck17_kiko_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",16),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck18_matiaskm_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",17),
                new PostZendikarRising(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck19_Lacansa_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",18),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck20_Bayesta93_RakdosShadow_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",19),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck21_kanister_OopsAllSpells_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",20),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(OopsAllSpells),
                null,
                null
            );
        }

        [Test]
        public void Deck22_trader08111_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",21),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck23_doughshack_AmuletTitan_WUBRG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",22),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(PrimevalTitan),
                typeof(AmuletTitan),
                null
            );
        }

        [Test]
        public void Deck24_TSPJendrek_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",23),
                new PostZendikarRising(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck25_Smdster_TemurControl_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",24),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck26_helpfulsheep_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",25),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck27_DisgruntledElk_RakdosShadow_BR_Lurrus()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",26),
                new PostZendikarRising(),
                ArchetypeColor.BR,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck28_SideArms_Scapeshift_URG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",27),
                new PostZendikarRising(),
                ArchetypeColor.URG,
                typeof(Scapeshift),
                null,
                null
            );
        }

        [Test]
        public void Deck29_Flshtoph_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",28),
                new PostZendikarRising(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck30_littledarwin_HammerTime_W()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",29),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(HammerTime),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Metcalf23_MonoWhiteTaxes_W()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",30),
                new PostZendikarRising(),
                ArchetypeColor.W,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck32_HotBread_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-challenge-2020-09-27",31),
                new PostZendikarRising(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }


    }
}
