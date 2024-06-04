using System.Collections;
using TMPro;
using UnityEngine;

[RequireComponent(typeof(Counter))]
public class CounterView : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _text;
    [SerializeField] private Switcher _switch;
    [SerializeField] private float _delayTime;

    private Counter _counter;

    private void Start()
    {
        _counter = GetComponent<Counter>();
        _text.text = _counter.Count.ToString();
    }

    private void OnEnable()
    {
        _switch.OnSwitch += ChangeTime;
    }

    private void OnDisable()
    {
        _switch.OnSwitch -= ChangeTime;
    }

    private void ChangeTime()
    {
        if (_switch.IsOn)
        {
            var OnCounter =  StartCoroutine(TimeCounter());
        }
        else
        {
            StopAllCoroutines();
        }
    }

    private IEnumerator TimeCounter()
    {
        WaitForSeconds delayTime = new WaitForSeconds(_delayTime);

        while (true) 
        {
            _counter.TakeTeime(_delayTime);
            _text.text = _counter.Count.ToString();

            yield return delayTime;
        }
    }
}
