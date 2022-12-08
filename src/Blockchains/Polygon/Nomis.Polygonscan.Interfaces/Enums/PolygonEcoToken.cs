// ------------------------------------------------------------------------------------------------------
// <copyright file="PolygonEcoToken.cs" company="Nomis">
// Copyright (c) Nomis, 2022. All rights reserved.
// The Application under the MIT license. See LICENSE file in the solution root for full license information.
// </copyright>
// ------------------------------------------------------------------------------------------------------

using System.ComponentModel;

namespace Nomis.Polygonscan.Interfaces.Enums
{
    /// <summary>
    /// Polygon eco token.
    /// </summary>
    public enum PolygonEcoToken :
        byte
    {
        /// <summary>
        /// KLIMA.
        /// </summary>
        [Description("klima-dao")]
        Klima = 0,

        /// <summary>
        /// ZRO.
        /// </summary>
        [Description("zro")]
        Zro = 1
    }
}