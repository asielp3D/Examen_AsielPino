using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camara : MonoBehaviour
{
    private Transform target;
    public Vector3 offset;
    public Vector2 limitX;
    public Vector2 limitY;
    public float interpolationRatio;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Mario").GetComponent<Transform>();
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if(target != null)
        {
            Vector3 desiredPosition = target.position + offset;
            float clampX = Mathf.Clamp (desiredPosition.x, limitX.x , limitX.y);
            float clampY = Mathf.Clamp (desiredPosition.y, limitY.x , limitY.y);
            Vector3 clampedPosition = new Vector3 (clampX, clampY, desiredPosition.z);
            Vector3 lerpedPosition = Vector3.Lerp(transform.position, clampedPosition, interpolationRatio);
            transform.position = lerpedPosition;
       }
    }
}