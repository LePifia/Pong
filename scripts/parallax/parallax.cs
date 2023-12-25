using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class parallax : MonoBehaviour
{
    Vector2 startingPosition;

    float startZ;


    [SerializeField]
    Vector2 movement => (Vector2)MainCamera.transform.position - startingPosition;

    [SerializeField]
    Camera MainCamera;

    float distanceFromSubject => startZ - startZ;

    float clippingPlane => (MainCamera.transform.position.z + (distanceFromSubject > 0 ? MainCamera.farClipPlane : MainCamera.nearClipPlane));

    float parallaxFactor => Mathf.Abs((distanceFromSubject)  / clippingPlane);

    // Start is called before the first frame update
    void Start()
    {
        MainCamera = Camera.main;
        startingPosition = transform.position;
        startZ = transform.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 newPos = startingPosition + movement * parallaxFactor;
        transform.position = new Vector3(newPos.x, newPos.y, startZ);
    }
}
