using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class PunchScaleOnClick : MonoBehaviour
{
    public float strength = .1f;
    public float duration = .5f;

    private void OnMouseDown()
    {
        Debug.Log("Hang in there.");
        transform.DOPunchScale(new Vector3(strength, strength, strength), duration);
    }
}
