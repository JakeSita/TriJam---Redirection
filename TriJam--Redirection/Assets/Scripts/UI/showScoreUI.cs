using System;
using System.Collections;
using System.Collections.Generic;
using DefaultNamespace;
using TMPro;
using UnityEngine;

namespace DefaultNamespace
{
    public class showScoreUI : MonoBehaviour
    {
        // Start is called before the first frame update
        public TextMeshProUGUI text;

        private void Start()
        {
            text.SetText("Score: " + StaticGameManager.Actualscore);
        }
    }
}