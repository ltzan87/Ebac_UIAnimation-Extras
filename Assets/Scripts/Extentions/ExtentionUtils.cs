using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;
using DG.Tweening;

public static class ExtentionUtils
{
    public static void Scale(this Transform t, float size = 1.2f)
    {
        t.localScale = Vector3.one * size;
    }

    public static void ScaleGameObject(this GameObject g, float size = 1.2f)
    {
        g.transform.localScale = Vector3.one * size;
    }

    public static void ScaleVector(this Vector3 v, float size = 1.2f)
    {
        //t.localScale = Vector3.one * size;
    }

}