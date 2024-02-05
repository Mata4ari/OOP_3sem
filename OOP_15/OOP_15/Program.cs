using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace OOP_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                Task task = new Task(() => MulVector(100000));
                task.Start();
                Console.WriteLine(task.Id+"\t"+task.Status+"\t"+task.IsCompleted);
                task.Wait();
                Console.WriteLine(task.Id + "\t" + task.Status + "\t" + task.IsCompleted);
                sw.Stop();
                Console.WriteLine("Затраченое время: "+sw.ElapsedMilliseconds);
                Console.WriteLine();
            }

            CancellationTokenSource cancel = new CancellationTokenSource();
            Task task1 = Task.Run(() => MulVector(100000, cancel), cancel.Token);
            try
            {
                cancel.Cancel();
                task1.Wait();
            }
            catch (Exception)
            {
                if (task1.IsCanceled)
                    Console.WriteLine("Задача отменена\n");
            }

            Func<int> func1 = () => { return new Random().Next(0, 9) * 10; };
            Task<int> task2 = new Task<int>(func1);
            Task<int> task3 = new Task<int>(() => new Random().Next(0, 100));
            Task<int> task4 = new Task<int>(() =>new Random().Next(0, 7)*11);
            task4.Start();
            task2.Start();
            task3.Start();

            Task<int> task5 = Task.WhenAll(task2, task3, task4).
                ContinueWith((t) => task2.Result+task3.Result+task4.Result);

            var awaiter = task5.GetAwaiter();
            awaiter.OnCompleted(() => Console.WriteLine( awaiter.GetResult()+"\n"));
            Thread.Sleep(10);

            int[] arr1 = new int[1000000];
            int[] arr2 = new int[1000000];
            Stopwatch stopwatch2 = new Stopwatch();
            stopwatch2.Start();
            Parallel.For(0, arr1.Length, t => arr1[t] = t);
            stopwatch2.Stop();
            Console.WriteLine($"Parallel.For: {stopwatch2.ElapsedMilliseconds}");

            Stopwatch stopwatch3 = new Stopwatch();
            stopwatch3.Start();
            for (int i = 0; i < arr2.Length; i++)
                arr2[i] = i + 1;

            stopwatch3.Stop();
            Console.WriteLine("for: " + stopwatch3.ElapsedMilliseconds);
            Stopwatch stopwatch4 = new Stopwatch();
            stopwatch4.Start();
            Parallel.ForEach(new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 }, Factorial);
            stopwatch4.Stop();
            Console.WriteLine("Parallel.Foreach: " + stopwatch4.ElapsedMilliseconds);

            Stopwatch stopwatch5 = new Stopwatch();
            stopwatch5.Start();
            foreach (var m in new List<int>() { 1, 2, 3, 4,5,6,7,8,9,10,11,12,13,14,15, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 })
            {
                Factorial(m);
            }
            stopwatch5.Stop();
            Console.WriteLine("foreach: " + stopwatch5.ElapsedMilliseconds);
            Console.WriteLine();

            int[] arr3 = new int[100];
            int[] arr4 = new int[100];
            Parallel.Invoke(() =>
            {
                for(int i=0;i<arr3.Length; i++)
                {
                    arr3[i] = i*7;
                }
            }, () =>
            {
                for (int i = 0; i < arr4.Length; i++)
                {
                    arr4[i] = i % 7;
                }
            });


            //Sale();

            Console.WriteLine();


            FactorialAsync();
            Thread.Sleep(1000);
        }
        static void MulVector(int k, CancellationTokenSource token=null)
        {
            Random random = new Random();
            List<int> vector = new List<int>();
            for (int i = 0; i < k; i++)
            {
                vector.Add(random.Next(1, 10));
            }
            for(int i = 0;i<k;i++)
            {
                vector[i] = vector[i] * 7;
            }
        }
        static void Factorial(int num)
        {
            int result = 1;
            for (int i = 1; i <= num; i++)
                result *= i;

            Console.WriteLine($"Факториал числа {num} равен {result}");
        }

        static void Sale()
        {
            BlockingCollection<string> bc = new BlockingCollection<string>(5);

            Task[] sellers = new Task[5]
            {
                new Task(() => { while (true) { Thread.Sleep(300); bc.Add("Микроволновка"); } }),
                new Task(() => { while (true) { Thread.Sleep(350); bc.Add("Кровать"); } }),
                new Task(() => { while (true) { Thread.Sleep(400); bc.Add("Дверь"); } }),
                new Task(() => { while (true) { Thread.Sleep(500); bc.Add("Вазон"); } }),
                new Task(() => { while (true) { Thread.Sleep(550); bc.Add("Стул"); } })
            };

            Task[] consumers = new Task[10]
            {
                new Task(() => { while (true) { Thread.Sleep(700); bc.Take(); } }),
                new Task(() => { while (true) { Thread.Sleep(700); bc.Take(); } }),
                new Task(() => { while (true) { Thread.Sleep(700); bc.Take(); } }),
                new Task(() => { while (true) { Thread.Sleep(700); bc.Take(); } }),
                new Task(() => { while (true) { Thread.Sleep(700); bc.Take(); } }),
                new Task(() => { while (true) { Thread.Sleep(700); bc.Take(); } }),
                new Task(() => { while (true) { Thread.Sleep(700); bc.Take(); } }),
                new Task(() => { while (true) { Thread.Sleep(700); bc.Take(); } }),
                new Task(() => { while (true) { Thread.Sleep(700); bc.Take(); } }),
                new Task(() => { while (true) { Thread.Sleep(700); bc.Take(); } })
            };

            foreach (var i in sellers)
                if (i.Status != TaskStatus.Running)
                    i.Start();

            foreach (var i in consumers)
                if (i.Status != TaskStatus.Running)
                    i.Start();

            int count = -1;
            while (true)
            {
                if (bc.Count != count )
                {
                    count = bc.Count;
                    Thread.Sleep(300);
                    Console.Clear();
                    Console.WriteLine("--- СКЛАД ---");

                    foreach (var i in bc)
                        Console.WriteLine(i);
                }
            }

        }
        static void Factorial()
        {
            int result = 1;
            for (int i = 1; i <= 6; i++)
            {
                result *= i;
            }
            Thread.Sleep(1000);
            Console.WriteLine($"Факториал равен {result}");
        }

        static async void FactorialAsync()
        {
            Console.WriteLine("Начало метода FactorialAsync");
            await Task.Run(() => Factorial());
            Console.WriteLine("Конец метода FactorialAsync");
        }
    }
}
