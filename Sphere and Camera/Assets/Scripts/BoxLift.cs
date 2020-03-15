using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class BoxLift : MonoBehaviour
{

    public Vector3 delta;
    Vector3 startPosition;
    private void Start()
    {
        startPosition = transform.position;
    }
    private void OnTriggerEnter(Collider other)
 
    {
        float velocity = 5f / delta.sqrMagnitude;
        float change = (Mathf.Sin(Time.timeSinceLevelLoad * velocity) + 1f) / 2f;
        Rigidbody rigidbody = transform.GetComponent<Rigidbody>();
        rigidbody.position = Vector3.Lerp(startPosition, startPosition + delta, change);
    }
    private void OnDrawGizmos()
    {
        Gizmos.color = Color.gray;
        if (Selection.activeTransform == transform)
        {
            Gizmos.color = Color.gray;
        }
        Vector3 ghostPosition = transform.position + delta;
        Vector3 ghostSize = transform.rotation * transform.localScale * 2f;

        Gizmos.DrawWireCube(transform.position + delta, Vector3.one);
    }
}
