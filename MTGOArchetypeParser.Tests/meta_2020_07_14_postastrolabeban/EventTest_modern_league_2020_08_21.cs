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
#01 Janh: Azorius Control (WU)
#02 remf: Merfolk (WU, Lurrus)
#03 bbotonline: Bant Midrange (WUG)
#04 excel0679: Izzet Prowess (UR)
#05 TheWonderLord: Jund Midrange (BRG)
#06 Bosseidon: Burn (WR, Lurrus)
#07 Seeker__of_the_Wei: Slivers (WUBRG)
#08 chicers: Humans (WUBRG)
#09 HypnoticaL: Mono Red Prowess (R)
#10 Tedpanic: Azorius Control (WU)
#11 TheGaul: Golgari Midrange (BG)
#12 Trellon: U Tron (U)
#13 D00mwake: Rakdos Prowess (BR, Lurrus)
#14 moralmar: Hardened Scales (G)
#15 Vilaboy: Kiki Chord (WURG, Yorion)
#16 BananOlaf: Ad Nauseam (WUB)
#17 aqualog: Boros Prowess (WR, Lurrus)
#18 benchsummer: UBRG Shadow (UBRG)
#19 FreedMania: KGC Amulet Titan (UBRG)
#20 Ivan_Catanduva_Br: Gruul Midrange (RG)
#21 AndersPovirk: Dredge (WBRG)
#22 lordavery: Bant Midrange (WUG)
#23 psych4tog: Elementals (WUBRG)
#24 Juaspas: Abzan Midrange (WBG)
#25 SickWorld: Bogles (WG)
#26 t1griselbrand: Neobrand (UG)
#27 flyingspaghetti: Gifts Storm (UR)
#28 Mordeka1ser: Niv To Light (WUBRG, Yorion)
#29 Delthar: Mill (UB)
#30 Leviathan102: Reclaimer Titan (WRG)
#31 Firewalker89: Grixis Shadow (UBR)
#32 Rebus8: Orzhov Eldrazi Taxes (WB)
#33 benchsummer: Heliod Sisters (W)
#34 DylansHyper: Devoted (WG, Lurrus)
#35 Curryvore: Jeskai Control (WUR, Yorion)
#36 flankattack27: Uroza (WUG)
#37 kogamo: Reclaimer Titan (WRG)
#38 nick4567: Temur Reclamation (URG)
#39 DoctorQueller: Bant Spirits (WUG)
#40 Unlife: E Tron (C)
#41 TuggaNaxos: Sultai Control (UBG)
#42 llabmonkey: Bant Control (WUG)
#43 harukispecial: Sultai Control (UBG)
#44 MartinezDP: Niv To Light (WUBRG, Yorion)
#45 Weasley: Sultai Reclamation (UBG)
#46 JUJUBEAN__2004: Devoted (WUG)
#47 Game_Night: Golos Tron (G, Jegantha)
#48 DarkKeeper: Bant Control (WUG)
#49 SpicyLeche: Jund Shadow (BRG, Lurrus)
#50 Ticky13: Azorius Taxes (WU)
#51 jaredseely: Martyr Proc (W)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_league_2020_08_21 : EventTest
    {
        [Test]
        public void Deck01_Janh_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-21",0),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
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
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck04_excel0679_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-league-2020-08-21",3),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck05_TheWonderLord_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",4),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
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
        public void Deck09_HypnoticaL_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-league-2020-08-21",8),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck10_Tedpanic_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-21",9),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck11_TheGaul_GolgariMidrange_BG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",10),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(GenericMidrange),
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
        public void Deck13_D00mwake_RakdosProwess_BR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-21",12),
                new PostAstrolabeBan(),
                ArchetypeColor.BR,
                typeof(GenericProwess),
                null,
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
        public void Deck17_aqualog_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-21",16),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck18_benchsummer_UBRGShadow_UBRG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",17),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck19_FreedMania_KGCAmuletTitan_UBRG()
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
        public void Deck20_IvanCatanduvaBr_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",19),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
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
                typeof(GenericMidrange),
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
        public void Deck24_Juaspas_AbzanMidrange_WBG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",23),
                new PostAstrolabeBan(),
                ArchetypeColor.WBG,
                typeof(GenericMidrange),
                null,
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
        public void Deck28_Mordeka1ser_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-21",27),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
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
        public void Deck30_Leviathan102_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",29),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck31_Firewalker89_GrixisShadow_UBR()
        {
            Test(
                GetDeck("modern-league-2020-08-21",30),
                new PostAstrolabeBan(),
                ArchetypeColor.UBR,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck32_Rebus8_OrzhovEldraziTaxes_WB()
        {
            Test(
                GetDeck("modern-league-2020-08-21",31),
                new PostAstrolabeBan(),
                ArchetypeColor.WB,
                typeof(GenericTaxes),
                null,
                null
            );
        }

        [Test]
        public void Deck33_benchsummer_HeliodSisters_W()
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
        public void Deck35_Curryvore_JeskaiControl_WUR_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-21",34),
                new PostAstrolabeBan(),
                ArchetypeColor.WUR,
                typeof(GenericControl),
                null,
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
        public void Deck37_kogamo_ReclaimerTitan_WRG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",36),
                new PostAstrolabeBan(),
                ArchetypeColor.WRG,
                typeof(PrimevalTitan),
                typeof(ReclaimerTitan),
                null
            );
        }

        [Test]
        public void Deck38_nick4567_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",37),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck39_DoctorQueller_BantSpirits_WUG()
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
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck42_llabmonkey_BantControl_WUG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",41),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck43_harukispecial_SultaiControl_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",42),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck44_MartinezDP_NivToLight_WUBRG_Yorion()
        {
            Test(
                GetDeck("modern-league-2020-08-21",43),
                new PostAstrolabeBan(),
                ArchetypeColor.WUBRG,
                typeof(NivToLight),
                null,
                ArchetypeCompanion.Yorion
            );
        }

        [Test]
        public void Deck45_Weasley_SultaiReclamation_UBG()
        {
            Test(
                GetDeck("modern-league-2020-08-21",44),
                new PostAstrolabeBan(),
                ArchetypeColor.UBG,
                typeof(GenericControl),
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
        public void Deck47_GameNight_GolosTron_G_Jegantha()
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
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck49_SpicyLeche_JundShadow_BRG_Lurrus()
        {
            Test(
                GetDeck("modern-league-2020-08-21",48),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericShadow),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck50_Ticky13_AzoriusTaxes_WU()
        {
            Test(
                GetDeck("modern-league-2020-08-21",49),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericTaxes),
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
