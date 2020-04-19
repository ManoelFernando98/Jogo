using UnityEngine;
using System.Collections;

public class CameraFollow : MonoBehaviour {

    // Use this for initialization
    
    public GameObject targetObject;
    private float distanceToTarget;
    private void Start()
    {
        distanceToTarget = transform.position.x - targetObject.transform.position.x;

    }
    private void Update()
    {
        float targetObjectX = targetObject.transform.position.x;
        Vector3 newCameraPosition = transform.position;
        newCameraPosition.x = targetObjectX + distanceToTarget;
        transform.position = newCameraPosition;


    }
    
}
