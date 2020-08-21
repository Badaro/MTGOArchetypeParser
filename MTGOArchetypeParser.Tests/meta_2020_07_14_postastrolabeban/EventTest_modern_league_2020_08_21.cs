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
#01 Janh: AzoriusStoneblade (WU)
#02 remf: Merfolk (WU, Lurrus)
#03 bbotonline: BantMidrange (WUG)
#04 excel0679: IzzetProwess (UR)
#05 TheWonderLord: Jund (BRG)
#06 Bosseidon: Burn (WR, Lurrus)
#07 Seeker__of_the_Wei: Slivers (WUBRG)
#08 chicers: Humans (WUBRG)
#09 HypnoticaL: Prowess (R)
#10 Tedpanic: Miracles (WU)
#11 TheGaul: Rock (BG)
#12 Trellon: UTron (U)
#13 D00mwake: RakdosProwess (BR, Lurrus)
#14 moralmar: HardenedScales (G)
#15 Vilaboy: KikiChord (WURG, Yorion)
#16 BananOlaf: AdNauseam (WUB)
#17 aqualog: Prowess (WR, Lurrus)
#18 benchsummer: TraverseShadow (UBRG)
#19 FreedMania: KGCAmuletTitan (UBRG)
#20 Ivan_Catanduva_Br: Ponza (RG)
#21 AndersPovirk: Dredge (WBRG)
#22 lordavery: BantMidrange (WUG)
#23 psych4tog: Elementals (WUBRG)
#24 Juaspas: Abzan (WBG)
#25 SickWorld: Bogles (WG)
#26 t1griselbrand: Neobrand (UG)
#27 flyingspaghetti: GiftsStorm (UR)
#28 Mordeka1ser: BringToNiv (WUBRG, Yorion)
#29 Delthar: Mill (UB)
#30 Leviathan102: TitanVial (WRG)
#31 Firewalker89: GrixisShadow (UBR)
#32 Rebus8: EldraziTaxes (WB)
#33 benchsummer: HeliodSisters (W)
#34 DylansHyper: Devoted (WG, Lurrus)
#35 Curryvore: JeskaiBlink (WUR, Yorion)
#36 flankattack27: Uroza (WUG)
#37 kogamo: PrimevalTitan (WRG)
#38 nick4567: TemurReclamation (URG)
#39 DoctorQueller: BantSpirits (WUG)
#40 Unlife: ETron (C)
#41 TuggaNaxos: SultaiControl (UBG)
#42 llabmonkey: SnowBlade (WUG)
#43 harukispecial: SultaiSnow (UBG)
#44 MartinezDP: BringToNiv (WUBRG, Yorion)
#45 Weasley: WildernessReclamation (UBG)
#46 JUJUBEAN__2004: Devoted (WUG)
#47 Game_Night: GolosTron (G, Jegantha)
#48 DarkKeeper: BantControl (WUG)
#49 SpicyLeche: SuicideShadow (BRG, Lurrus)
#50 Ticky13: DeathAndTaxes (WU)
#51 jaredseely: MartyrProc (W)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_league_2020_08_21 : EventTest
    {
        [Test]
        public void Deck01_Janh_AzoriusControl_AzoriusStoneblade_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-21",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(AzoriusStoneblade),
                null
            );
        }

        [Test]
        public void Deck02_remf_Merfolk_WU_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-21",1),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(Merfolk),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck03_bbotonline_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",2),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_excel0679_Prowess_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-21",3),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(Prowess),
                typeof(IzzetProwess),
                null
            );
        }

        [Test]
        public void Deck05_TheWonderLord_Rock_Jund_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",4),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Rock),
                typeof(Jund),
                null
            );
        }

        [Test]
        public void Deck06_Bosseidon_Burn_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-21",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_SeekeroftheWei_Slivers_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Slivers),
                null,
                null
            );
        }

        [Test]
        public void Deck08_chicers_Humans_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",7),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Humans),
                null,
                null
            );
        }

        [Test]
        public void Deck09_HypnoticaL_Prowess_R()
        {
            Test(
                GetDeck("modern-league-2020-08-21",8),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(Prowess),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Tedpanic_AzoriusControl_Miracles_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-21",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(AzoriusControl),
                typeof(Miracles),
                null
            );
        }

        [Test]
        public void Deck11_TheGaul_Rock_BG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",10),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Rock),
                null,
                null
            );
        }

        [Test]
        public void Deck12_Trellon_UTron_U()
        {
            Test(
                GetDeck("modern-league-2020-08-21",11),
                new PostAstrolabeBan(),
                ArchetypeColor.U,
                typeof(UTron),
                null,
                null
            );
        }

        [Test]
        public void Deck13_D00mwake_Prowess_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-21",12),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(Prowess),
                typeof(RakdosProwess),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck14_moralmar_HardenedScales_G()
        {
            Test(
                GetDeck("modern-league-2020-08-21",13),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(HardenedScales),
                null,
                null
            );
        }

        [Test]
        public void Deck15_Vilaboy_KikiChord_WURG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-21",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WURG,
                typeof(KikiChord),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck16_BananOlaf_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-league-2020-08-21",15),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck17_aqualog_Prowess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-21",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Prowess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_benchsummer_DeathsShadow_TraverseShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",17),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(DeathsShadow),
                typeof(TraverseShadow),
                null
            );
        }

        [Test]
        public void Deck19_FreedMania_PrimevalTitan_KGCAmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",18),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck20_IvanCatanduvaBr_Ponza_RG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",19),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(Ponza),
                null,
                null
            );
        }

        [Test]
        public void Deck21_AndersPovirk_Dredge_WBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",20),
                new PostAstrolabeBan(),
                ArchetypeColor.WBRG,
                typeof(Dredge),
                null,
                null
            );
        }

        [Test]
        public void Deck22_lordavery_BantMidrange_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",21),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck23_psych4tog_Elementals_WUBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",22),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(Elementals),
                null,
                null
            );
        }

        [Test]
        public void Deck24_Juaspas_Rock_Abzan_WBG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",23),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(Rock),
                typeof(Abzan),
                null
            );
        }

        [Test]
        public void Deck25_SickWorld_Bogles_WG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",24),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Bogles),
                null,
                null
            );
        }

        [Test]
        public void Deck26_t1griselbrand_Neobrand_UG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",25),
                new PostAstrolabeBan(),
                ArchetypeColor.UG,
                typeof(Neobrand),
                null,
                null
            );
        }

        [Test]
        public void Deck27_flyingspaghetti_GiftsStorm_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-21",26),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GiftsStorm),
                null,
                null
            );
        }

        [Test]
        public void Deck28_Mordeka1ser_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-21",27),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck29_Delthar_Mill_UB()
        {
            Test(
                GetDeck("modern-league-2020-08-21",28),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck30_Leviathan102_TitanVial_WRG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",29),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(TitanVial),
                null,
                null
            );
        }

        [Test]
        public void Deck31_Firewalker89_DeathsShadow_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-08-21",30),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(DeathsShadow),
                typeof(GrixisShadow),
                null
            );
        }

        [Test]
        public void Deck32_Rebus8_DeathAndTaxes_EldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-08-21",31),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(DeathAndTaxes),
                typeof(EldraziTaxes),
                null
            );
        }

        [Test]
        public void Deck33_benchsummer_SoulSisters_HeliodSisters_W()
        {
            Test(
                GetDeck("modern-league-2020-08-21",32),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(SoulSisters),
                typeof(HeliodSisters),
                null
            );
        }

        [Test]
        public void Deck34_DylansHyper_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-21",33),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck35_Curryvore_AzoriousBlink_JeskaiBlink_WUR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-21",34),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(AzoriousBlink),
                typeof(JeskaiBlink),
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck36_flankattack27_Uroza_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",35),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Uroza),
                null,
                null
            );
        }

        [Test]
        public void Deck37_kogamo_PrimevalTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",36),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                null,
                null
            );
        }

        [Test]
        public void Deck38_nick4567_WildernessReclamation_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",37),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(WildernessReclamation),
                typeof(TemurReclamation),
                null
            );
        }

        [Test]
        public void Deck39_DoctorQueller_Spirits_BantSpirits_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",38),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Spirits),
                typeof(BantSpirits),
                null
            );
        }

        [Test]
        public void Deck40_Unlife_ETron_C()
        {
            Test(
                GetDeck("modern-league-2020-08-21",39),
                new PostAstrolabeBan(),
                ArchetypeColor.C,
                typeof(ETron),
                null,
                null
            );
        }

        [Test]
        public void Deck41_TuggaNaxos_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",40),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SultaiControl),
                null,
                null
            );
        }

        [Test]
        public void Deck42_llabmonkey_SnowControl_SnowBlade_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",41),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(SnowControl),
                typeof(SnowBlade),
                null
            );
        }

        [Test]
        public void Deck43_harukispecial_SnowControl_SultaiSnow_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",42),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(SnowControl),
                typeof(SultaiSnow),
                null
            );
        }

        [Test]
        public void Deck44_MartinezDP_BringToNiv_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-21",43),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(BringToNiv),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck45_Weasley_WildernessReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",44),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(WildernessReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck46_JUJUBEAN2004_Devoted_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",45),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(Devoted),
                null,
                null
            );
        }

        [Test]
        public void Deck47_GameNight_GTron_GolosTron_G_Jegantha()
        {
            Test(
                GetDeck("modern-league-2020-08-21",46),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(GolosTron),
                ArchetypeCompanion.Jegantha
            );
        }

        [Test]
        public void Deck48_DarkKeeper_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",47),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(BantControl),
                null,
                null
            );
        }

        [Test]
        public void Deck49_SpicyLeche_DeathsShadow_SuicideShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-21",48),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(DeathsShadow),
                typeof(SuicideShadow),
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck50_Ticky13_DeathAndTaxes_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-21",49),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(DeathAndTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck51_jaredseely_MartyrProc_W()
        {
            Test(
                GetDeck("modern-league-2020-08-21",50),
                new PostAstrolabeBan(),
                ArchetypeColor.W,
                typeof(MartyrProc),
                null,
                null
            );
        }


    }
}
