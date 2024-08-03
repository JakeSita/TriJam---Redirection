using System;
using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEditor.VersionControl;
using UnityEngine;
using UnityEngine.TestTools;

namespace DefaultNamespace
{

    namespace Test.EditMode
    {

        public class EnemyTest
        {
           
            [Test]
            // Test to see if the enemy is created
            public void EnemyCreation()
            {
                var gameObject = new GameObject();
                var enemy = gameObject.AddComponent<BasicEnemy>();

                Assert.IsNotNull(enemy);
            }

            [Test]
            // Test to see if the enemy is of type IEnemy
            public void EnemyType()
            {

                var gameObject = new GameObject();
                var enemy = gameObject.AddComponent<BasicEnemy>();

                Assert.IsInstanceOf<IEnemy>(enemy);
            }

            [Test]
            // Test to see if the enemy is initialized correctly
            public void EnemyInit()
            {
                var gameObject = new GameObject();
                var enemy = gameObject.AddComponent<BasicEnemy>();
                enemy.Initalize();
                Assert.AreEqual(enemy._Speed, enemy.speed);
                Assert.AreEqual(enemy._multiplier, enemy._Multiplier);
                Assert.AreEqual(enemy.Name, enemy.gameObject.name);
            }
        }

    }
}