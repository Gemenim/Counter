using System;
using System.Collections;
using UnityEngine;

public class Counter : MonoBehaviour
{
    [SerializeField] private float _delayTime = 0.5f;
    [SerializeField] private float _delta = 1;

    private float _count = 0;
    private bool _isOff = true;
    private IEnumerator _timeCounter;

    public Action Change;

    public float Count => _count;

    private void Start()
    {
        _timeCounter = TimeCounter();
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if(_isOff)
            {
                _isOff = false;
                StartCoroutine(_timeCounter);
            }
            else
            {
                _isOff = true;
                StopCoroutine(_timeCounter);
            }
        }
        else if (Input.GetMouseButtonDown(1))
        {
            _count = 0;
            Change();
        }
    }

    private void TakeTeime(float time)
    {
        _count += _delta;
    }

    private IEnumerator TimeCounter()
    {
        WaitForSeconds delayTime = new WaitForSeconds(_delayTime);

        while (true)
        {
            TakeTeime(_delayTime);
            Change();

            yield return delayTime;
        }
    }
}
