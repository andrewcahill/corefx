// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.ComponentModel
{
    /// <summary>
    /// Provides a way to synchronously or asynchronously execute a delegate.
    /// </summary>
    public interface ISynchronizeInvoke
    {
        /// <summary>
        /// Gets a value indicating whether the caller must call <see cref='System.ComponentModel.ISynchronizeInvoke.Invoke'/>
        /// when calling an object that implements this interface.
        /// </summary>
        bool InvokeRequired { get; }

        /// <summary>
        /// Executes the given delegate on the main thread that this object executes on.
        /// </summary>
        IAsyncResult BeginInvoke(Delegate method, object[] args);

        /// <summary>
        /// Waits until the process you started by calling <see cref='System.ComponentModel.ISynchronizeInvoke.BeginInvoke'/>
        /// completes, and then returns the value generated by the process.
        /// </summary>
        object EndInvoke(IAsyncResult result);

        /// <summary>
        /// Executes the given delegate on the main thread that this object executes on.
        /// </summary>
        object Invoke(Delegate method, object[] args);
    }
}
