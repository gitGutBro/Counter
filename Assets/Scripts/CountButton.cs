using System;
using System.Collections;
using TMPro;
using UnityEngine;

public class CountButton : MonoBehaviour
{
    private const float Delay = 0.5f;

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
            yield return new WaitForSeconds(Delay);
            _counter++;
            print(_counter);
            _counterView.text = Convert.ToString(_counter);
        }
    }
}