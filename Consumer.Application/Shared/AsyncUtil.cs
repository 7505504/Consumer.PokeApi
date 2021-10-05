using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Consumer.Application.Shared
{
    public static class AsyncUtil
    {
        private static readonly TaskFactory _taskFactory = new
            TaskFactory(CancellationToken.None,
                        TaskCreationOptions.None,
                        TaskContinuationOptions.None,
                        TaskScheduler.Default);

        /// <summary>
        /// Runs a Task synchronous avoiding deadlock
        /// </summary>
        /// <remarks>
        /// Calling Async methods from synchronous code can result in a deadlock. 
        /// This method helps to avoid that.
        /// </remarks>
        /// <typeparam name="TResult"></typeparam>
        /// <param name="func"></param>
        /// <returns></returns>
        public static TResult RunSync<TResult>(Func<Task<TResult>> func)
            => _taskFactory
                .StartNew(func)
                .Unwrap()
                .GetAwaiter()
                .GetResult();

        /// <summary>
        /// Runs a Task synchronous avoiding deadlock
        /// </summary>
        /// <remarks>
        /// Calling Async methods from synchronous code can result in a deadlock. 
        /// This method helps to avoid that.
        /// </remarks>
        /// <param name="func"></param>
        public static void RunSync(Func<Task> func)
            => _taskFactory
                .StartNew(func)
                .Unwrap()
                .GetAwaiter()
                .GetResult();
    }
}
