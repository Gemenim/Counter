using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switcher : MonoBehaviour
{
    private bool _isOn = false;

    public bool IsOn => _isOn;

    public Action OnSwitch;

    private void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            if(_isOn)
                _isOn = false;
            else
                _isOn = true;

            OnSwitch();
        }
    }
}
