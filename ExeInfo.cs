using System;

namespace Mag_ACClientPatcher
{
    class ExeInfo
    {
        public readonly DateTime RelaseMonth;

        public readonly Version FileVersion;

        public readonly string MD5Hash;

        public ExeInfo(DateTime releaseMonth, Version fileVersion, string md5Hash)
        {
            RelaseMonth = releaseMonth;
            FileVersion = fileVersion;
            MD5Hash = md5Hash;
        }
    }
}
