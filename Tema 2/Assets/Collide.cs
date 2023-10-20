using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Collide : MonoBehaviour
{
    public AudioSource audioSrc;
    public AudioClip audioClip;
    public GameObject particlePrefab1;
    public GameObject particlePrefab2;
    public TMP_Text scoreText;
    int score = 0;

    void OnCollisionEnter (Collision myColisionObj)
    {
        if (myColisionObj.gameObject.name == "FootballGate")
        {
            score += 10;
            audioSrc.Play();
            Debug.Log("Score: " + score);
            scoreText.text = "Score " + score;
            Instantiate(particlePrefab1);
            Instantiate(particlePrefab2);
        }
    }

    public void Start ()
    {
        score = 0;
        scoreText.text = "Score 0";
        audioSrc.clip = audioClip;
    }
}
