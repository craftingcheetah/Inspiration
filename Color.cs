using System;

public class Color
{
    public string Name;
    public int Value;
    public void ChangeRandomValue(int maxValue)
    {
        Value = new Random().Next(0, maxValue);        
    }
}