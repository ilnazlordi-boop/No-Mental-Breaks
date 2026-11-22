
using HarmonyLib;
using Verse;

namespace NoMentalBreaks
{
    [StaticConstructorOnStartup]
    public static class NoMentalBreaksMod
    {
        static NoMentalBreaksMod()
        {
            var harmony = new Harmony(
                "Ilnaz.NoMentalBreaks"
            );

            harmony.PatchAll();
            Log.Message(
                "[NoMentalBreaks] Mod loaded!"
            );
        }
    }

    [HarmonyPatch(
        typeof(MentalBreakWorker),
        nameof(MentalBreakWorker.BreakCanOccur)
    )]
    public static class Patch_MentalBreaks
    {
        public static bool Prefix(ref bool __result)
        {
            __result = false;
            return false;
        }
    }
}
