using TMPro;
using UnityEngine;

public class CounterView : MonoBehaviour
{
    [SerializeField] private Counter _counter;
    [SerializeField] private TextMeshProUGUI _text;

    private void OnEnable()
    {
        _counter.Changed += ChangeText;
    }

    private void OnDisable()
    {
        _counter.Changed -= ChangeText;
    }

    private void ChangeText(float count)
    {
        _text.text =count.ToString();
    }
}
