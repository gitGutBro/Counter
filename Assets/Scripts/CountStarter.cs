using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class CountStarter : MonoBehaviour
{
    private const float DelaySeconds = 0.5f;

    private readonly WaitForSecondsRealtime _delay = new(DelaySeconds);
    [SerializeField] private TextMeshProUGUI _counterView;

    private int _counter;
    private bool _isCounting = false;

    private void OnMouseDown()
    {
        if (_isCounting)
        {
            _isCounting = false;
            StopCoroutine(Add());
        }
        else
        {
            _isCounting = true;
            StartCoroutine(Add());
        }
    }

    private IEnumerator Add()
    {
        while(enabled)
        {
            yield return _delay;
            _counter++;
            print(_counter);
            _counterView.text = Convert.ToString(_counter);
        }
    }
}