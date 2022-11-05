using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metronome : MonoBehaviour
{
    [SerializeField] private float Bpm;
    [SerializeField] private AudioSource Audio;

    private float BpmInSeconds;
    private float NextTime;

    // Start is called before the first frame update
    void Start()
    {
        BpmInSeconds = 60f / Bpm;
        NextTime = (float)AudioSettings.dspTime + BpmInSeconds;
        AudioManager.Instance.Play("DebugMusic");
    }

    private void FixedUpdate()
    {
        if (AudioSettings.dspTime >= NextTime)
        {
            Debug.Log("FixedUpdate Tick");
            AudioManager.Instance.Play("DebugMetronome");
            NextTime += BpmInSeconds;
        }
    }
}