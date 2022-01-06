using System;
using System.Threading;
using System.Threading.Tasks;

namespace SampleToTest
{
    public class AsyncAwaitTest
    {
        protected AsyncAwaitTest()
        {
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Con1 ThreadId {0}", Thread.CurrentThread.ManagedThreadId);

            TestVoidAsync();
            //_ = TestTaskAsync();

            //TestTaskAsync().GetAwaiter().GetResult();

            //Task.Run(TestVoidAsync);
            //Task.Run(TestTaskAsync);

            //Task.Run(TestVoidAsync).GetAwaiter().GetResult();
            //Task.Run(TestTaskAsync).GetAwaiter().GetResult();

            // Task.Run(() => TestVoidAsync()).GetAwaiter().GetResult();
            //Task.Run(() => TestTaskAsync()).GetAwaiter().GetResult();
            //Task.Run(async () => await TestTaskAsync()).GetAwaiter().GetResult();

            //AsyncVoidExceptions_WithoutTryCatch();
            //AsyncVoidExceptions_WithTryCatch();

            //AsyncTaskExceptions_WithoutTryCatch();
            //AsyncTaskExceptions_WithTryCatch();

            //AsyncTaskExceptions_WithoutTryCatch().GetAwaiter().GetResult();
            //AsyncTaskExceptions_WithTryCatch().GetAwaiter().GetResult();

            // Task.Run(AsyncTaskExceptions_WithoutTryCatch);
            //Task.Run(AsyncTaskExceptions_WithoutTryCatch).GetAwaiter().GetResult();

            //Task.Run(AsyncTaskExceptions_WithTryCatch);
            //Task.Run(AsyncTaskExceptions_WithTryCatch).GetAwaiter().GetResult();

            //Task.Run(() => AsyncTaskExceptions_WithoutTryCatch());
            //Task.Run(() => AsyncTaskExceptions_WithTryCatch());

            //Task.Run(() => AsyncTaskExceptions_WithoutTryCatch()).GetAwaiter().GetResult();
            //Task.Run(() => AsyncTaskExceptions_WithTryCatch()).GetAwaiter().GetResult();

            //Task.Run(async () => await AsyncTaskExceptions_WithoutTryCatch());
            //Task.Run(async () => await AsyncTaskExceptions_WithTryCatch());

            //Task.Run(async () => await AsyncTaskExceptions_WithoutTryCatch()).GetAwaiter().GetResult();
            //Task.Run(async () => await AsyncTaskExceptions_WithTryCatch()).GetAwaiter().GetResult();

            Console.WriteLine("Finish ThreadId {0}", Thread.CurrentThread.ManagedThreadId);

            Console.ReadLine();
        }

        private static async void TestVoidAsync()
        {
            Console.WriteLine("Con2 ThreadId {0}", Thread.CurrentThread.ManagedThreadId);

            await Task.Delay(2000);

            Console.WriteLine("After await Con3 ThreadId {0}", Thread.CurrentThread.ManagedThreadId);
        }

        private static async Task TestTaskAsync()
        {
            Console.WriteLine("Con2 ThreadId {0}", Thread.CurrentThread.ManagedThreadId);

            await Task.Delay(2000);

            Console.WriteLine("After await Con3 ThreadId {0}", Thread.CurrentThread.ManagedThreadId);
        }

        private static async Task ThrowExceptionAsync()
        {
            throw new InvalidOperationException();
        }

        public static async void AsyncVoidExceptions_WithoutTryCatch()
        {
            await ThrowExceptionAsync();
        }

        public static async void AsyncVoidExceptions_WithTryCatch()
        {
            try
            {
                await ThrowExceptionAsync();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception Caught {0}", Thread.CurrentThread.ManagedThreadId);
            }
        }

        public static async Task AsyncTaskExceptions_WithoutTryCatch()
        {
            await ThrowExceptionAsync();
        }

        public static async Task AsyncTaskExceptions_WithTryCatch()
        {
            try
            {
                await ThrowExceptionAsync();
            }
            catch (Exception)
            {
                Console.WriteLine("Exception Caught {0}", Thread.CurrentThread.ManagedThreadId);
            }
        }
    }
}