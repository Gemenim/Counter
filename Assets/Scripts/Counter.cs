using UnityEngine;

public class Counter : MonoBehaviour
{
    private float _count = 0;

    public float Count => _count;

    public void TakeTeime(float time)
    {
        _count += time;
    }
}
