using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Properties : MonoBehaviour
{
    private int _ptVal;

    public int PointValue
    {
        get
        {
            return _ptVal;
        }
        set
        {
            _ptVal = value;
        }
    }
}
