// MatchScheduler.cs
using System;
using UnityEngine;

public class MatchScheduler : MonoBehaviour
{
    public int[] availableMatchHours = { 9, 15, 21 };

    public bool IsMatchTime(int hour)
    {
        foreach(var h in availableMatchHours)
            if (h == hour) return true;
        return false;
    }

    public DateTime NextMatchTime(DateTime now)
    {
        DateTime next = now.AddHours(1);
        while (!IsMatchTime(next.Hour)) next = next.AddHours(1);
        return next;
    }
}
