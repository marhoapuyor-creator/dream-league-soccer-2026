// TimeOfDayController.cs
using UnityEngine;

public class TimeOfDayController : MonoBehaviour
{
    [Range(0,23)] public int currentHour = 18;
    public float cycleSpeed = 0.05f; // hours per second

    public Light sunLight;
    public Gradient lightGradient;
    public AnimationCurve intensityCurve;

    void Update()
    {
        // advance hour if cycleSpeed > 0
        if (cycleSpeed > 0f)
        {
            float hoursAdvanced = cycleSpeed * Time.deltaTime;
            float fractional = (currentHour + hoursAdvanced) % 24f;
            currentHour = (int)fractional;
        }

        float t = currentHour / 24f;
        if (sunLight != null)
        {
            sunLight.color = lightGradient.Evaluate(t);
            sunLight.intensity = intensityCurve.Evaluate(t);
            // rotate the sun to simulate day/night
            sunLight.transform.rotation = Quaternion.Euler((t * 360f) - 90f, 45f, 0f);
        }
    }
}
