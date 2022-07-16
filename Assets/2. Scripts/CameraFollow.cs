using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    Vector3 offset;
    private void Start() {
        offset = transform.position - target.position;
    }
    private void LateUpdate() {
        transform.position = offset + target.position;
    }
}
