﻿// Copyright (c) 2007-2018 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu/master/LICENCE

namespace osu.Game.Rulesets.Objects.Legacy.Taiko
{
    /// <summary>
    /// Legacy osu!taiko Hit-type, used for parsing Beatmaps.
    /// </summary>
    internal sealed class ConvertHit : HitObject
    {
        protected override HitWindows CreateHitWindows() => null;
    }
}
