using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FOV : MonoBehaviour {

    public float viewRadius;
    [Range(0, 360)]
    public float viewAngle;
    public float offset;

    public Vector3 DirectionFromAngle(float degreeAngle) {
        degreeAngle += -transform.eulerAngles.z + offset;
        return new Vector3(Mathf.Sin(degreeAngle * Mathf.Deg2Rad), Mathf.Cos(degreeAngle * Mathf.Deg2Rad),0);
    }

    // Use this for initialization
    


}
