using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
    public class Stats
    {
        [SerializeField] private int _dex;
        [SerializeField] private int _int;
        [SerializeField] private int _str;
        public int Dex => _dex;
        public int Int => _int;
        public int Str => _str;
    }
}
