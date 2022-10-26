using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Metronome : MonoBehaviour
{
    [SerializeField] private float Bpm;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(_MetronomeTimer());
    }

    private IEnumerator _MetronomeTimer()
    {
        AudioManager.Instance.Play("DebugMusic");
        while (true)
        {
            print("Tick");
            AudioManager.Instance.Play("DebugMetronome");
            yield return new WaitForSeconds(60f / Bpm);
            print(60f / Bpm);
        }
    }
}
