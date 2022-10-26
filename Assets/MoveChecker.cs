using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveChecker : MonoBehaviour
{
    [SerializeField] private Text Label;

    private IEnumerator Timer;

    private void Start()
    {
        Timer = _Timer();
    }

    public void ShowMove(string move)
    {
        Label.text = move;

        StopCoroutine(Timer);
        Timer = _Timer();
        StartCoroutine(Timer);
    }

    private IEnumerator _Timer()
    {
        Color color = Label.color;

        float progress = 0;
        while (progress < 1)
        {
            color.a = Mathf.Lerp(1, 0, progress);
            Label.color = color;

            progress += Time.deltaTime / 3;
            yield return null;
        }

        color.a = 1;
        Label.color = color;

        Label.text = "";
    }
}