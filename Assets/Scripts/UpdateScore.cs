using System;
using UnityEngine;
using UnityEngine.UI;

public class UpdateScore : MonoBehaviour
{
    private void Update()
    {
        GetComponent<Text>().text = Storage.score.ToString();
    }
}