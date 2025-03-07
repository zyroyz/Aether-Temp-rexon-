using System;
using UnityEngine;

namespace StupidTemplate.Classes
{
    public class ExtGradient
    {
        public GradientColorKey[] colors = new GradientColorKey[]
        {
            new GradientColorKey(Color.black, 0f),
        };

        public bool isRainbow = false;
        public bool copyRigColors = false;
    }
}
