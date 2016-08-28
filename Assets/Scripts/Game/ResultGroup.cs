﻿using UnityEngine;
using UnityEngine.Events;
using System.Collections;

public class ResultGroup : SubGroup
{
    [SerializeField]
    UnityEvent showCallback;

    void OnEnable()
    {
        Timer.StopCount();
    }

    public override void FadeCallback()
    {
        showCallback.Invoke();
    }
}
