using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


public class Program
{
    static void Main(string[] args)
    {
        try 
        { 
        First();
        Second();
        Third();
        Fourth();
        Fifth();
        }
        catch (Exception ex) 
        {
            Console.WriteLine(ex.Message);
        }
    }
    private static void First()
    {
        var allProcesses = Process.GetProcesses();
        
        foreach (var process in allProcesses)
        {
            Console.Write(process.Id+"\t");
            Console.Write(process.ProcessName+"\t");
            Console.Write(process.BasePriority+"\t");
            Console.WriteLine();
        }
    }
    private static void Second()
    {
        var domain = AppDomain.CurrentDomain;
        Console.WriteLine("Information about current domain:");
        Console.WriteLine("\n\nCurrent domain:\t" + domain.FriendlyName);
        Console.WriteLine("Base directory:\t" + domain.BaseDirectory);
        Console.WriteLine("Configuration Details:\t" + domain.SetupInformation);
        Console.WriteLine("All assemblies in the domain:\n");

        foreach (var assembly in domain.GetAssemblies())
        {
            Console.WriteLine(assembly.GetName().Name);
        }

        var assem = Assembly.GetExecutingAssembly();
        AppDomain newDomain = AppDomain.CreateDomain("MyDomain");
        newDomain.Load(assem.GetName().Name);
        AppDomain.Unload(newDomain);
    }

    private static void Third()
    {
        Mutex mutex = new Mutex();
        Thread NumbersThread = new Thread(new ParameterizedThreadStart(WriteNums));
        NumbersThread.Name = "NumbersThread";
        NumbersThread.Start(7);

        Thread.Sleep(2200);
        mutex.WaitOne();


        Console.WriteLine("\n--------------------");
        Console.WriteLine("Priority:   " + NumbersThread.Priority);
        Thread.Sleep(100);
        Console.WriteLine("Name tread:  " + NumbersThread.Name);
        Thread.Sleep(100);
        Console.WriteLine("ID tread:   " + NumbersThread.ManagedThreadId);
        Console.WriteLine("---------------------");
        Thread.Sleep(2000);

        mutex.ReleaseMutex();
    }
   private static void WriteNums(object number)
    {
        int num = (int)number;
        for (int i = 0; i < num; i++)
        {
            Console.WriteLine(i);
            Thread.Sleep(500);
        }
    }
    private static void Fourth()
    {
        Console.WriteLine();
        Thread evenThread = new Thread(EvenNumbers);
        evenThread.Priority = ThreadPriority.AboveNormal;
        Thread oddThread = new Thread(OddNumbers);
        oddThread.Priority = ThreadPriority.Normal;
        evenThread.Start();
        oddThread.Start();
        Thread.Sleep(3000);
        Console.WriteLine("\n");
    }

    static object locker = new object();
    public static void EvenNumbers()
    {
        for (int i = 0; i <= 20; i++)
        {
            if (i % 2 == 0)
            {
                lock (locker)
                {
                    Console.Write($"{i} ");
                    Thread.Sleep(100);
                    Monitor.Pulse(locker);
                }
            }
        }
    }
    public static void OddNumbers()
    {
        for (int i = 0; i <= 20; i++)
        {
            if (i % 2 != 0)
            {
                lock (locker)
                {
                    Console.Write($"{i} ");
                    Thread.Sleep(100);
                    Monitor.Pulse(locker);
                }
            }
        }
    }
    static int num = 1000;
    private static void Fifth()
    {
        TimerCallback timerCallback = new TimerCallback(WhatTimeIsIt);
        Timer timer = new Timer(timerCallback, null, 0, 1000);
        Thread.Sleep(5000);
        
    }
    static void WhatTimeIsIt(object obj)
    {
        int i = (int)num;
        i -= 7;
        num = i;
        Console.WriteLine(num);
    }
}