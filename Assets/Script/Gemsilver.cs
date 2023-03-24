using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Gemsilver : MonoBehaviour
{
    public GameObject ScoreBox;
    public AudioSource collectSound;
    void OnTriggerEnter()
    {
        collectSound.Play();
        Destroy(gameObject);
    }
}
