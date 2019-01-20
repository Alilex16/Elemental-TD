using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseTrail : MonoBehaviour {

    [Header("Mouse Trail")]
    public float distance = 10f;


    // Fancy Mouse Trail
    void Update () {
        Ray r = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 pos = r.GetPoint(distance);
        transform.position = pos;
    }
}
