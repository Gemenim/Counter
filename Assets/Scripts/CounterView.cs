using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private TextMeshProUGUI _text;

    private void Start()
    {
        _text.text = _counter.Count.ToString();
    }

    private void OnEnable()
    {
        _counter.Change += ChangeText;
    }

    private void OnDisable()
    {
        _counter.Change -= ChangeText;
    }

    private void ChangeText()
    {
        _text.text = _counter.Count.ToString();
    }
}
