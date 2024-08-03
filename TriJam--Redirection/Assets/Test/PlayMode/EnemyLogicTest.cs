using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using DefaultNameSpace;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class EnemyLogicTest
{
    private GameObject _enemyTester;
    private GameObject player;
    private BasicEnemy enemy;
    private GameObject GameManager;

    [SetUp]
    public void SetUp()
    {
       //GameLoop Set up 
        
        //setup gameManager Object
        GameManager = GameObject.Instantiate(new GameObject());
        GameManager.AddComponent<EnemySpeedUp>();
        //setup enemy object
        _enemyTester = GameObject.Instantiate(new GameObject());
        enemy = _enemyTester.AddComponent<BasicEnemy>();
        //setup player object
        player = GameObject.Instantiate(new GameObject());
        //give player tag because enemy needs to find player
        player.tag = "Player";
        
    }

    //checks that the fuctionality of the enemy speed up is correct after a event is triggered
    [UnityTest]
    public IEnumerator TimerEvent()
    {
        enemy._Speed = 5;
        enemy._Multiplier = 2;
        enemy.Initalize();
        //wait for event to trigger every 6 seconds
        yield return new WaitForSeconds(6);
        Assert.AreEqual(10, enemy.speed);
    }
    // checks that the enemy speed up event is triggered by the game manager
    [UnityTest]
    public IEnumerator GmEvent()
    {
        var timer = GameManager.GetComponent<EnemySpeedUp>().timer;
        yield return new WaitForSeconds(7);
        Assert.AreEqual(1,Math.Floor(timer.GetTime()));
    }
    //checks that the game manager has an event
    [UnityTest]
    public IEnumerator GmHasEvent()
    {
        yield return new WaitForSeconds(1);
        var timer = GameManager.GetComponent<EnemySpeedUp>().timer;
        Assert.IsNotNull(timer.OnTimerTrigger);
    }
    

}
