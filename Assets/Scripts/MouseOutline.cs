using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using cakeslice;

public class MouseOutline : MonoBehaviour
{
    private Outline outline;

    void Start()
    {
        outline = GetComponentInChildren<Outline>();
        outline.enabled = false;
    }

    private void OnMouseEnter()
    {
        outline.enabled = true;
    }

    private void OnMouseExit()
    {
        outline.enabled = false;
    }
}
