using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor (typeof(FOV))]
public class FOVEditor : Editor {

    void OnSceneGUI() {
        FOV fov = (FOV)target;
        Handles.color = Color.white;
        Handles.DrawWireArc(fov.transform.position, Vector3.forward, Vector3.up, 360, fov.viewRadius);

        Vector3 viewAngleA = fov.DirectionFromAngle(-fov.viewAngle / 2);
        Vector3 viewAngleB = fov.DirectionFromAngle(fov.viewAngle / 2);

        Handles.DrawLine(fov.transform.position, fov.transform.position + viewAngleA * fov.viewRadius);
        Handles.DrawLine(fov.transform.position, fov.transform.position + viewAngleB * fov.viewRadius);
    }
}
