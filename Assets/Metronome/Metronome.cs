using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metronome : MonoBehaviour
{
    [SerializeField] private float Bpm;
    [SerializeField] private int BeatsPerMeasure;

    private float BpmInSeconds;
    private float NextTime;
    private int Beat = 0;

    // Start is called before the first frame update
    void Start()
    {
        BpmInSeconds = 60f / Bpm;
        NextTime = (float)AudioSettings.dspTime + BpmInSeconds;
        AudioManager.Instance.Play("DebugMusic");
        PlayBeat();
    }

    private void FixedUpdate()
    {
        Debug.Log("FixedUpdate Tick");
        if (AudioSettings.dspTime >= NextTime)
        {
            PlayBeat();
            NextTime += BpmInSeconds;
        }
    }


    private void PlayBeat()
    {
        if (Beat == 0)
            {
                AudioManager.Instance.Play("MetronomeLow");
            }
            else
            {
                AudioManager.Instance.Play("MetronomeHigh");
            }

            Beat++;
            if (Beat == BeatsPerMeasure)
            {
                Beat = 0;
            }
    }
}