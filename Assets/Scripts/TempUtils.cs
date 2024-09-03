using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TempUtils
{
    // K = °C + 273.15
    // K = (°F + 459.67) x 5/9
    // K = °R x 5/9
    // Conversions to Celsius

    // °C = K - 273.15
    // °C = (°F - 32) x 5/9
    // °C = (°R - 491.67) x 5/9
    // Conversions to Fahrenheit

    // °F = (K x 9/5) - 459.67
    // °F = (°C x 9/5) + 32
    // °F = °R - 459.67
    // Conversions to Rankine

    // °R = K x 9/5
    // °R = (°C + 273.15) x 9/5
    // °R = °F + 459.67

    public static float CelsiusToKelvin(float celsius)
    {
        return celsius + 273.15f;
    }

    public static float KelvinToCelsius(float kelvin)
    {
        return kelvin - 273.15f;
    }

    public static float CelsiusToFahrenheit(float celsius) 
    {
        return (celsius * 9 / 5) + 32;
    }

    public static float FahrenheitToCelsius(float fahrenheit)
    {
        return (fahrenheit - 32) * 5 / 9;
    }

    public static float KelvinToFahrenheit(float kelvin)
    {
        return (kelvin * 9 / 5) - 459.67f;
    }

    public static float FahrenheitToKelvin(float fahrenheit)
    {
        return (fahrenheit + 459.67f) * 5 / 9;
    }

    public static float KelvinToRankine(float kelvin)
    {
        return kelvin * 9 / 5;
    }

    public static float RankineToKelvin(float rankine)
    {
        return rankine * 5 / 9;
    }

    public static float CelsiusToRankine(float celsius)
    {
        return (celsius + 273.15f) * 9 / 5;
    }

    public static float RankineToCelsius(float rankine)
    {
        return (rankine - 491.67f) * 5 / 9;
    }

    public static float FahrenheitToRankine(float fahrenheit)
    {
        return fahrenheit + 459.67f;
    }

    public static float RankineToFahrenheit(float rankine)
    {
        return rankine - 459.67f;
    }
    
}