using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Mag_ACClientPatcher
{
    class Patch
    {
        public readonly string Name;

        public readonly IReadOnlyCollection<PatchPart> PatchParts;

        public readonly string Notes;

        public readonly string ApplyWarning;

        public Patch(string name, IList<PatchPart> patches, string notes = null, string applyWarning = null)
        {
            Name = name;

            PatchParts = new ReadOnlyCollection<PatchPart>(patches);

            Notes = notes;

            ApplyWarning = applyWarning;
        }

        public PatchState GetPatchState(byte[] exeData)
        {
            int notAppliedCount = 0;
            int appliedCount = 0;

            foreach (var part in PatchParts)
            {
                var state = part.GetPatchState(exeData);

                if (state == PatchState.NotApplied)
                    notAppliedCount++;
                else if (state == PatchState.Applied)
                    appliedCount++;
                else
                    return state;
            }

            if (notAppliedCount > 0 && appliedCount == 0) return PatchState.NotApplied;
            if (notAppliedCount == 0 && appliedCount > 0) return PatchState.Applied;

            throw new NotImplementedException();
        }

        public void Apply(byte[] exeData)
        {
            foreach (var part in PatchParts)
                part.Apply(exeData);
        }

        public void Revert(byte[] exeData)
        {
            foreach (var part in PatchParts)
                part.Revert(exeData);
        }
    }
}
