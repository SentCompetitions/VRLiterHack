using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class QuestItem : MonoBehaviour
{
    public bool isChecked = false;
    public int score = 10;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other);

        if (!isChecked)
        {
            GetComponent<AudioSource>().Play();
            Storage.score += score;
            isChecked = true;
        }
    }
}
