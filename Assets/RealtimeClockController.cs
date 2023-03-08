using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class RealtimeClockController : MonoBehaviour
{
    public Transform HourHand, MinuteHand, SecondHand;

    private const float
    hoursToDegrees = 360f / 12f,
    minutesToDegrees = 360f / 60f,
    secondsToDegrees = 360f / 60f;

    private void Update()
    {
        DateTime time = DateTime.Now;
        HourHand.localRotation = Quaternion.Euler((time.Hour * hoursToDegrees)+90f, 0f, -90f);
        MinuteHand.localRotation = Quaternion.Euler((time.Minute * minutesToDegrees)+90f, 0f, -90f);
        SecondHand.localRotation = Quaternion.Euler((time.Second * secondsToDegrees)+90f, 0f, -90f);
    }
}
