using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using DefaultNamespace;

public class TimerTest
{
    [Test]
    // Test to see if the timer is created
    public void TimerSetUp()
    {
        Timer timer = new Timer(() => Debug.Log("Timer Triggered"), 1);
        Assert.AreEqual(0, timer.GetTime());
    }
    [Test]
    // Test to see if the timer is created
    public void TimerTickNotRepeat()
    {
        var timer = new Timer(()=>Debug.Log("Timer Triggered"), 1);
        timer.StartTimer();
        timer.Tick(0.5f);
        Assert.AreEqual(0.5f, timer.GetTime());
        timer.Tick(1);
        Assert.AreEqual(0, timer.GetTime());
        timer.Tick(0.5f);
        Assert.AreEqual(0, timer.GetTime());
    }

    [Test]
    // Test to see if the timer is created
    public void TimerTickRepeat()
    {
        var timer = new Timer(()=>Debug.Log("Timer Repeat Triggered"), 2, true);
        timer.StartTimer();
        timer.Tick(2);
        timer.Tick(1);
        Assert.AreEqual(1, timer.GetTime());
    }
    
    [Test]
    // Test to see if the timer is created
    public void TimerStop()
    {
        var timer = new Timer(()=>Debug.Log("Timer Stop Triggered"), 1);
        timer.StartTimer();
        timer.Tick(0.5f);
        timer.StopTimer();
        timer.Tick(0.5f);
        Assert.AreEqual(0.5f, timer.GetTime());
    }
    
    [Test]
    // Test to see if the timer is created
    public void multipleTimers()
    {
        var timer1 = new Timer(()=>Debug.Log("Timer 1 Triggered"), 1);
        var timer2 = new Timer(()=>Debug.Log("Timer 2 Triggered"), 1);
        timer1.StartTimer();
        timer2.StartTimer();
        timer1.Tick(1);
        timer2.Tick(0.5f);
        Assert.AreEqual(0, timer1.GetTime());
        Assert.AreEqual(0.5f, timer2.GetTime());
    }
    
}
