# C-Sharp-Samples
To test Asyn Await with and without task.

Un-Comment the code and test.  
* TestVoidAsync();  

1.	Async Void                                
Con1 ThreadId 1  
Con2 ThreadId 1  
Finish ThreadId 1  
After await Con3 ThreadId 4  

2.	Task with (_)underscore                              
Con1 ThreadId 1  
Con2 ThreadId 1  
Finish ThreadId 1  
After await Con3 ThreadId 4

3. await Task
Console1 ThreadId 1
Console2 ThreadId 1
After await Console3 ThreadId 4
Finish ThreadId 4

4.	GetAwaiter().GetResult()             
Con1 ThreadId 1  
Con2 ThreadId 1  
After await Con3 ThreadId 4\
Finish ThreadId 1

5.	Task.Run(TestMethod)\
Con1 ThreadId 1\
Finish ThreadId 1\
Con2 ThreadId 4\
After await Con3 ThreadId 4


6.	Task.Run(TestMethod).GetAwaiter().GetResult();\
Con1 ThreadId 1\
Con2 ThreadId 4\
After await Con3 ThreadId 5\
Finish ThreadId 1

7.	Task.Run(() => TestMethod());\
Con1 ThreadId 1\
Finish ThreadId 1\
Con2 ThreadId 4\
After await Con3 ThreadId 5

8.	Task.Run(async () => await TestMethod());\
Con1 ThreadId 1\
Finish ThreadId 1\
Con2 ThreadId 4\
After await Con3 ThreadId 4

9.	 Task.Run(async () => await TestMethod()).GetAwaiter().GetResult();\
Con1 ThreadId 1\
Con2 ThreadId 4\
After await Con3 ThreadId 4\
Finish ThreadId 1

10.	Task.Run(() => TestMethod()).GetAwaiter().GetResult();\
Con1 ThreadId 1\
Con2 ThreadId 4\
After await Con3 ThreadId 6\
Finish ThreadId 1


* With Exception
1.	Void Async without TryCatch : Crashed\
Con1 ThreadId 1\
Finish ThreadId 1\
Unhandled exception. System.InvalidOperationException:

2.	Void Async with TryCatch\
Con1 ThreadId 1\
Exception Caught 1\
Finish ThreadId 1

3.	Task without TryCatch\
Con1 ThreadId 1\
Finish ThreadId 1

4.	Task with TryCatch
Con1 ThreadId 1\
Exception Caught 1\
Finish ThreadId 1

5.	Task Await without TryCatch : Crashed\
Con1 ThreadId 1\
Unhandled exception.

6.	Task Await with TryCatch\
Con1 ThreadId 1\
Exception Caught 1\
Finish ThreadId 1

7.	Task.Run without TryCatch\
Con1 ThreadId 1\
Finish ThreadId 1

8.	Task.Run with TryCatch\
Con1 ThreadId 1\
Finish ThreadId 1\
Exception Caught 4

9.	Task.Run Await without TryCatch : Crashed\
Con1 ThreadId 1\
Unhandled exception. System.InvalidOperationException:

10.	Task.Run Await with TryCatch\
Con1 ThreadId 1\
Exception Caught 5\
Finish ThreadId 1

