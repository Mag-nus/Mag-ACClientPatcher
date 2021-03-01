﻿using System.Collections.Generic;
using System.Diagnostics;

namespace Mag_ACClientPatcher
{
    static class ACClientExePatches
    {
        private static readonly List<Patch> PatchesList_2015_10_11_6096 = new List<Patch>
        {
            //new Patch("Allow Multiclient No Decal", new List<PatchPart> { new PatchPart(0x122A1, new byte[] {0x68, 0x30, 0x58, 0x79, 0x00}, new byte[] {0x6A, 0x00, 0x90, 0x90, 0x90}) }, "This allows multiple instances of acclient.exe", "This patch is will crash the client if you use decals \"Dual Log\" option. This is intended for uers who want to multi-client without decal."),

            new Patch("Allow Multiclient", new List<PatchPart>
            {
                new PatchPart(0x0121A2,
                    new byte[]
                    {
                        0xFF, 0x90, 0x80, 0x00, 0x00, 0x00, 0x84, 0xC0, 0x75, 0x6C
                    },
                    new byte[]
                    {
                        0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90
                    })
            }, "This allows multiple instances of acclient.exe even when not using decal."),

            new Patch("Bypass RenderNormalMode", new List<PatchPart>
            {
                new PatchPart(0x054CDE,
                    new byte[]
                    {
                        0x74
                    },
                    new byte[]
                    {
                        0xEB
                    })
            }, "This will not render the world. This can greatly reduce CPU but doesn't reduce memory usage much."),

            new Patch("Pea 4K Res Unlocked", new List<PatchPart>
            {
                new PatchPart(0x06128D,
                    new byte[]
                    {
                        0x8D, 0x54, 0x24, 0x2C, 0x52, 0x6A, 0x3D, 0x8B, 0xCB, 0x88, 0x44, 0x24, 0x40, 0xE8, 0x91, 0xF8,
                        0xFF, 0xFF, 0x88, 0x44, 0x24, 0x11, 0x8D, 0x44, 0x24, 0x20, 0x50, 0x6A, 0x3E, 0x8B, 0xCB, 0xE8,
                        0x7F, 0xF8, 0xFF, 0xFF, 0x8D, 0x4C, 0x24, 0x24, 0x51, 0x6A, 0x3C, 0x8B, 0xCB, 0x88, 0x44, 0x24,
                        0x3C, 0xE8, 0x6D, 0xF8, 0xFF, 0xFF, 0x8B, 0x8B, 0x80, 0x04, 0x00, 0x00, 0x49, 0x83, 0xF9, 0x07,
                        0x8A, 0xD0, 0x88, 0x54, 0x24, 0x12},
                    new byte[]
                    {
                        0xC7, 0x44, 0x24, 0x2C, 0x00, 0x0F, 0x00, 0x00, 0x90, 0x88, 0x44, 0x24, 0x38, 0xC6, 0x44, 0x24,
                        0x11, 0x00, 0x90, 0x90, 0x90, 0x90, 0x8D, 0x44, 0x24, 0x20, 0x50, 0x6A, 0x3E, 0x8B, 0xCB, 0xE8,
                        0x7F, 0xF8, 0xFF, 0xFF, 0xC7, 0x44, 0x24, 0x24, 0x70, 0x08, 0x00, 0x00, 0x90, 0x88, 0x44, 0x24,
                        0x3C, 0xC6, 0x44, 0x24, 0x12, 0x00, 0x8B, 0x8B, 0x80, 0x04, 0x00, 0x00, 0x49, 0x33, 0xC0, 0x33,
                        0xD2, 0x83, 0xF9, 0x07, 0x90, 0x90

                    }),
                new PatchPart(0x063D94, 
                    new byte[]
                    {
                        0x74, 0x0A, 0x8B, 0x44, 0x24, 0x0C, 0x3B, 0xE8, 0x7E, 0x02, 0x8B, 0xE8, 0x8D, 0x4C, 0x24, 0x10,
                        0x51, 0x6A, 0x3E, 0x8B, 0xCE, 0xE8, 0x82, 0xCD, 0xFF, 0xFF, 0x84, 0xC0, 0x74, 0x0A, 0x8B, 0x44,
                        0x24, 0x10, 0x3B, 0xE8, 0x7D, 0x02, 0x8B, 0xE8, 0x8D, 0x54, 0x24, 0x14, 0x52, 0x6A, 0x3D, 0x8B,
                        0xCE, 0xE8, 0x66, 0xCD, 0xFF, 0xFF, 0x84, 0xC0, 0x74, 0x0C, 0x8B, 0x44, 0x24, 0x14, 0x39, 0x44,
                        0x24, 0x54, 0x7E, 0x02, 0x8B, 0xD8, 0x8D, 0x44, 0x24, 0x18, 0x50, 0x6A, 0x3F, 0x8B, 0xCE, 0xE8,
                        0x48, 0xCD, 0xFF, 0xFF, 0x84, 0xC0, 0x74
                    },
                    new byte[]
                    {
                        0xEB, 0x0A, 0x8B, 0x44, 0x24, 0x0C, 0x3B, 0xE8, 0x7E, 0x02, 0x8B, 0xE8, 0x8D, 0x4C, 0x24, 0x10,
                        0x51, 0x6A, 0x3E, 0x8B, 0xCE, 0xE8, 0x82, 0xCD, 0xFF, 0xFF, 0x84, 0xC0, 0xEB, 0x0A, 0x8B, 0x44,
                        0x24, 0x10, 0x3B, 0xE8, 0x7D, 0x02, 0x8B, 0xE8, 0x8D, 0x54, 0x24, 0x14, 0x52, 0x6A, 0x3D, 0x8B,
                        0xCE, 0xE8, 0x66, 0xCD, 0xFF, 0xFF, 0x84, 0xC0, 0xEB, 0x0C, 0x8B, 0x44, 0x24, 0x14, 0x39, 0x44,
                        0x24, 0x54, 0x7E, 0x02, 0x8B, 0xD8, 0x8D, 0x44, 0x24, 0x18, 0x50, 0x6A, 0x3F, 0x8B, 0xCE, 0xE8,
                        0x48, 0xCD, 0xFF, 0xFF, 0x84, 0xC0, 0xEB
                    })
            }, "This is Peas client patch that unlocks 4K resolution. Pea has given me permission to add his patch to this tool."),

            /*
             This patch NOP's the following lines of code in Client::UseTime

            .text:00411FFB                 call    ?StartFrame@SceneTool@@SAXXZ ; SceneTool::StartFrame(void)
            .text:00412000                 mov ecx, [esi + 120h]; this
            .text:00412006                 call? Draw@SmartBox@@QAEXXZ ; SmartBox::Draw(void)

            We do not NOP EndFrame because decal uses that as the trigger for RenderFrame event
            */
            new Patch("Client::UseTime Disable StartFrame and Draw", new List<PatchPart>
            {
	            new PatchPart(0x011FFB,
		            new byte[]
		            {
			            0xE8, 0xA0, 0xC6, 0x02, 0x00, 0x8B, 0x8E, 0x20, 0x01, 0x00, 0x00, 0xE8, 0x05, 0x36, 0x04, 0x00
                    },
		            new byte[]
		            {
			            0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90, 0x90
                    })
            }, "This disables all rendering when in-world. It removes almost all CPU/GPU based load. It doesn't reduce memory usage much."),
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
