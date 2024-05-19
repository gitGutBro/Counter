using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class Counter : MonoBehaviour
{
    private const float DelaySeconds = 0.5f;

    private readonly WaitForSecondsRealtime _delay = new(DelaySeconds);
    [SerializeField] private TextMeshProUGUI _iteratorView;

    private int _iterator;
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
            _iterator++;
            print(_iterator);
            _iteratorView.text = Convert.ToString(_iterator);
        }
    }
}