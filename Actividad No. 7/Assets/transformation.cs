using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transformations1
{

    public static Matrix4x4 TranslateM(float tx, float ty, float tz)
    {
        Matrix4x4 tm = Matrix4x4.identity;
        tm[0, 3] = tx;
        tm[1, 3] = ty;
        tm[2, 3] = tz;
        return tm;
    }
}