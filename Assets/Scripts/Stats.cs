using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats
{
    [SerializeField] private int _dex;
    [SerializeField] private int _int;
    [SerializeField] private int _str;
    public int Dex => _dex;
    public int Int => _int;
    public int Str => _str;
        
    public Stats (int Dex, int Int, int Str)
    {
        _dex = Dex;
        _int = Int;
        _str = Str;
    }

    public void UpStats(int Dex, int Int, int Str)
    {
        _dex += Dex;
        _int += Int;
        _str += Str;
    }
}