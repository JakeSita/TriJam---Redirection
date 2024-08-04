using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


namespace DefaultNamespace
{

    public class MusicVolume : MonoBehaviour
    {
        private Slider slider;
        private AudioSource music;

        private void Start()
        {
            slider = GetComponent<Slider>();
            music = DontDestroyonload.Instance.gameObject.GetComponent<AudioSource>();
           
        }

        public void Update()
        {
            music.volume = slider.value;
        }

    }
}