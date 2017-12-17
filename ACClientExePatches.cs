using System.Collections.Generic;
using System.Diagnostics;

namespace Mag_ACClientPatcher
{
    static class ACClientExePatches
    {
        private static readonly List<Patch> PatchesList_2015_10_11_6096 = new List<Patch>
        {
            //new Patch("Allow Multiclient No Decal", new List<PatchPart> { new PatchPart(0x122A1, new byte[] {0x68, 0x30, 0x58, 0x79, 0x00}, new byte[] {0x6A, 0x00, 0x90, 0x90, 0x90}) }, "This allows multiple instances of acclient.exe", "This patch is will crash the client if you use decals \"Dual Log\" option. This is intended for uers who want to multi-client without decal."),
            new Patch("Allow Multiclient", new List<PatchPart> { new PatchPart(0x121A2, new byte[] { 0xFF, 0x90, 0x80, 0x00, 0x00, 0x00, 0x84, 0xC0, 0x75, 0x6C }, new byte[] { 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90 }) }, "This allows multiple instances of acclient.exe even when not using decal."),
            new Patch("Bypass RenderNormalMode", new List<PatchPart> { new PatchPart(0x54CDE, new byte[] {0x74}, new byte[] {0xEB}) }, "This will not render the world. This can greatly reduce CPU but doesn't reduce memory usage much.")
        };

        /// <summary>
        /// Will return null if no match was found.
        /// </summary>
        public static List<Patch> FindBy(FileVersionInfo fileVersionInfo)
        {
            if (fileVersionInfo.FileBuildPart == 11 && fileVersionInfo.FilePrivatePart == 6096) return PatchesList_2015_10_11_6096;

            return null;
        }
    }
}
