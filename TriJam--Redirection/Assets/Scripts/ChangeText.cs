using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class ChangeText : MonoBehaviour
{
    public TextMeshProUGUI text;
    public string[] messages;
    private int message = 0;
    public GameObject Knight2;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            if (messages.Length > message)
            {
                text.SetText(messages[message]);
                message += 1;
            }
            else
                Knight2.SetActive(false); 
        }
    }
}
