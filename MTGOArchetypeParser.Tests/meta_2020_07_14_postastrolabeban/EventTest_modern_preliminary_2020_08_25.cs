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
#02 SunofNothing: DimirShadow (UB)
#03 A22en: SnoopGoblins (BRG)
#04 kanister: BantControl (WUG)
#05 Danker: AzoriusControl (WU)
#06 SebastianStueckl: BorosProwess (WR, Lurrus)
#07 Jack_Kashtan: AdNauseam (WUB)
#08 ZYURYO: GruulMidrange (RG)
#09 Mikhathara1994: IzzetProwess (UR)
#10 GodOfSlaughter: KGCTron (G)
#11 nykolas0507: MonoRedProwess (R)
#12 ejcos531: JundMidrange (BRG)
#13 Maccaciock: AzoriusControl (WU)
#14 Shade_Scorpion: KGCAmuletTitan (UBRG)
#15 Tsubasa_Cat: Burn (WR)
#16 Nekonii: GolgariElves (BG)
#17 BasedCloy: Mill (UB)
#18 Tarrasque1: GolgariElves (BG)
#19 Artem_Kuhtin: Devoted (WG, Lurrus)
*/

namespace MTGOArchetypeParser.Tests.meta_2020_07_14_postastrolabeban
{
    public class EventTest_modern_preliminary_2020_08_25 : EventTest
    {
        [Test]
        public void Deck01_Lavaridge_TemurReclamation_URG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",0),
                new PostAstrolabeBan(),
                ArchetypeColor.URG,
                typeof(GenericReclamation),
                null,
                null
            );
        }

        [Test]
        public void Deck02_SunofNothing_DimirShadow_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",1),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(GenericShadow),
                null,
                null
            );
        }

        [Test]
        public void Deck03_A22en_SnoopGoblins_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",2),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(Goblins),
                typeof(SnoopGoblins),
                null
            );
        }

        [Test]
        public void Deck04_kanister_BantControl_WUG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",3),
                new PostAstrolabeBan(),
                ArchetypeColor.WUG,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck05_Danker_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",4),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck06_SebastianStueckl_BorosProwess_WR_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",5),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(GenericProwess),
                null,
                ArchetypeCompanion.Lurrus
            );
        }

        [Test]
        public void Deck07_JackKashtan_AdNauseam_WUB()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",6),
                new PostAstrolabeBan(),
                ArchetypeColor.WUB,
                typeof(AdNauseam),
                null,
                null
            );
        }

        [Test]
        public void Deck08_ZYURYO_GruulMidrange_RG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",7),
                new PostAstrolabeBan(),
                ArchetypeColor.RG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck09_Mikhathara1994_IzzetProwess_UR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",8),
                new PostAstrolabeBan(),
                ArchetypeColor.UR,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck10_GodOfSlaughter_KGCTron_G()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",9),
                new PostAstrolabeBan(),
                ArchetypeColor.G,
                typeof(GTron),
                typeof(KGCTron),
                null
            );
        }

        [Test]
        public void Deck11_nykolas0507_MonoRedProwess_R()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",10),
                new PostAstrolabeBan(),
                ArchetypeColor.R,
                typeof(GenericProwess),
                null,
                null
            );
        }

        [Test]
        public void Deck12_ejcos531_JundMidrange_BRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",11),
                new PostAstrolabeBan(),
                ArchetypeColor.BRG,
                typeof(GenericMidrange),
                null,
                null
            );
        }

        [Test]
        public void Deck13_Maccaciock_AzoriusControl_WU()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",12),
                new PostAstrolabeBan(),
                ArchetypeColor.WU,
                typeof(GenericControl),
                null,
                null
            );
        }

        [Test]
        public void Deck14_ShadeScorpion_KGCAmuletTitan_UBRG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",13),
                new PostAstrolabeBan(),
                ArchetypeColor.UBRG,
                typeof(PrimevalTitan),
                typeof(KGCAmuletTitan),
                null
            );
        }

        [Test]
        public void Deck15_TsubasaCat_Burn_WR()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",14),
                new PostAstrolabeBan(),
                ArchetypeColor.WR,
                typeof(Burn),
                null,
                null
            );
        }

        [Test]
        public void Deck16_Nekonii_GolgariElves_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",15),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Elves),
                typeof(GolgariElves),
                null
            );
        }

        [Test]
        public void Deck17_BasedCloy_Mill_UB()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",16),
                new PostAstrolabeBan(),
                ArchetypeColor.UB,
                typeof(Mill),
                null,
                null
            );
        }

        [Test]
        public void Deck18_Tarrasque1_GolgariElves_BG()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",17),
                new PostAstrolabeBan(),
                ArchetypeColor.BG,
                typeof(Elves),
                typeof(GolgariElves),
                null
            );
        }

        [Test]
        public void Deck19_ArtemKuhtin_Devoted_WG_Lurrus()
        {
            Test(
                GetDeck("modern-preliminary-2020-08-25",18),
                new PostAstrolabeBan(),
                ArchetypeColor.WG,
                typeof(Devoted),
                null,
                ArchetypeCompanion.Lurrus
            );
        }


    }
}