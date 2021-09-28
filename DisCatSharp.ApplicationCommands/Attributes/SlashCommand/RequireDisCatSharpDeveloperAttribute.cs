// This file is part of the DisCatSharp project, a fork of DSharpPlus.
//
// Copyright (c) 2021 AITSYS
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
// SOFTWARE.

using System;
using System.Linq;
using System.Threading.Tasks;

namespace DisCatSharp.ApplicationCommands.Attributes
{
    /// <summary>
    /// Defines that this application command is restricted to the owner of the bot.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method | AttributeTargets.Class, AllowMultiple = false, Inherited = false)]
    public sealed class ApplicationCommandRequireDisCatSharpDeveloperAttribute : SlashCheckBaseAttribute
    {
        /// <summary>
        /// Defines that this application command is restricted to the owner of the bot.
        /// </summary>
        public ApplicationCommandRequireDisCatSharpDeveloperAttribute()
        { }

        /// <summary>
        /// Runs checks.
        /// </summary>
        public override Task<bool> ExecuteChecksAsync(InteractionContext ctx)
        {
            var team = ctx.Client.LibraryDeveloperTeam.Developers;
            return team != null ? Task.FromResult(team.Where(x => x.Id == ctx.User.Id).Any()) : Task.FromResult(false);
        }
    }
}