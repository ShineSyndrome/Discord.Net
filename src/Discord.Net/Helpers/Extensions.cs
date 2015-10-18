﻿using System;
using System.Threading;
using System.Threading.Tasks;

namespace Discord
{
    internal static class Extensions
	{
		public static async Task Wait(this CancellationTokenSource tokenSource)
		{
			var token = tokenSource.Token;
			try { await Task.Delay(-1, token).ConfigureAwait(false); }
			catch (OperationCanceledException) { } //Expected
		}
		public static async Task Wait(this CancellationToken token)
		{
			try { await Task.Delay(-1, token).ConfigureAwait(false); }
			catch (OperationCanceledException) { } //Expected
		}
	}
}
