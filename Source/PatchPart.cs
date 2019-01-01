using System;

namespace Mag_ACClientPatcher
{
    class PatchPart
    {
        public readonly int Address;

        public readonly byte[] Original;

        public readonly byte[] Patched;

        /// <exception cref="ArgumentNullException">original and patched cannot be null</exception>
        /// <exception cref="ArgumentException">original and patched must be the same length</exception>
        public PatchPart(int address, byte[] original, byte[] patched)
        {
            if (original.Length != patched.Length)
                throw new ArgumentException();

            Address = address;
            Original = original;
            Patched = patched;
        }

        public PatchState GetPatchState(byte[] exeData)
        {
            try
            {
                for (int i = 0; i <= Original.Length; i++)
                {
                    if (i == Original.Length)
                        return PatchState.NotApplied;

                    if (exeData[Address + i] != Original[i])
                        break;
                }

                for (int i = 0; i <= Patched.Length; i++)
                {
                    if (i == Patched.Length)
                        return PatchState.Applied;

                    if (exeData[Address + i] != Patched[i])
                        break;
                }
            }
            catch
            {
                return PatchState.OutOfRange;
            }

            return PatchState.Mismatch;
        }

        public void Apply(byte[] exeData)
        {
            for (int i = 0; i < Patched.Length; i++)
                exeData[Address + i] = Patched[i];
        }

        public void Revert(byte[] exeData)
        {
            for (int i = 0; i < Original.Length; i++)
                exeData[Address + i] = Original[i];
        }
    }
}
