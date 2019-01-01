using System;
using System.Collections.Generic;
using System.Diagnostics;

namespace Mag_ACClientPatcher
{
    static class ACClientExeInfos
    {
        /// <summary>
        /// Do not modify the contents of this collection externally.
        /// </summary>
        public static readonly List<ExeInfo> InfosList = new List<ExeInfo>
        {
            new ExeInfo(new DateTime(2013, 09, 1), new Version(0, 0, 11, 4186), "2E30CD620B26F9787B4E6A6257A9E581"),
            new ExeInfo(new DateTime(2015, 10, 1), new Version(0, 0, 11, 6096), "116D9A66A70B6AF449DC3A28D82F2F6D"),
        };

        /// <summary>
        /// Will return null if no match was found.
        /// </summary>
        public static ExeInfo FindBy(FileVersionInfo fileVersionInfo)
        {
            foreach (var item in InfosList)
            {
                if (item.FileVersion.Build == fileVersionInfo.FileBuildPart && item.FileVersion.Revision == fileVersionInfo.FilePrivatePart)
                    return item;
            }

            return null;
        }
    }
}
