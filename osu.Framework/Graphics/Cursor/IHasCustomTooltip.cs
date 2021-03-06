﻿// Copyright (c) 2007-2017 ppy Pty Ltd <contact@ppy.sh>.
// Licensed under the MIT Licence - https://raw.githubusercontent.com/ppy/osu-framework/master/LICENCE

namespace osu.Framework.Graphics.Cursor
{
    /// <summary>
    /// Implementing this interface allows the implementing <see cref="Drawable"/> to display a custom tooltip if it is the child of a <see cref="TooltipContainer"/>
    /// </summary>
    public interface IHasCustomTooltip : IHasTooltip
    {
        /// <summary>
        /// The custom tooltip that should be displayed.
        /// </summary>
        /// <returns>The custom tooltip that should be displayed.</returns>
        ITooltip GetCustomTooltip();
    }
}
