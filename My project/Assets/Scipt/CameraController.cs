using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class CameraController : MonoBehaviour
{
    [SerializeField] private Camera cam;
    [Header("Move")] [SerializeField] private float moveSpeed;
    [SerializeField] private Transform coner1;
    [SerializeField] private Transform coner2;
    [SerializeField] private float xInput;
    [SerializeField] private float zInput;
    [Header("Zoom")] [SerializeField] private float zoomSpeed;
    [SerializeField] private float zoomModifier;
    [SerializeField] private float minZoomDist;
    [SerializeField] private float maxZoomDist;
    [SerializeField] private float dist;

    public static CameraController instance;

    private void Awake()
    {
        instance = this;
        cam = Camera.main;
    }

    void Start()
    {
        moveSpeed = 50;
        zoomSpeed = 25;
        minZoomDist = 15;
        maxZoomDist = 50;
    }

    private void MoveByKB()
    {
        xInput = Input.GetAxis("Horizontal");
        zInput = Input.GetAxis("Vertical");

        Vector3 dir = (transform.forward * zInput) + (transform.right * xInput);

        transform.position += dir * moveSpeed * Time.deltaTime;
        transform.position = Clamp(coner1.position, coner2.position);
    }

    private Vector3 Clamp(Vector3 lowerLeft, Vector3 topRight)
    {
        Vector3 pos = new Vector3(Mathf.Clamp(transform.position.x, lowerLeft.x, topRight.x), transform.position.y,
            Mathf.Clamp(transform.position.z, lowerLeft.z, topRight.z));

        return pos;
    }

    private void Zoom()
    {
        zoomModifier = Input.GetAxis("Mouse ScrollWheel");
        if (Input.GetKey(KeyCode.Z))
        {
            zoomModifier = 0.01f;
        }
        if (Input.GetKey(KeyCode.X))
        {
            zoomModifier = -0.01f;
        }

        dist = Vector3.Distance(transform.position, cam.transform.position);
        if (dist < minZoomDist && zoomModifier > 0f)
        {
            return; // too close!!!!!!
        }
        else if (dist > maxZoomDist && zoomModifier < 0f)
        {
            return; // too far !!!!!!
        }

        {
            cam.transform.position += cam.transform.forward * zoomModifier * zoomSpeed;
        }
    }
    void Update()
    {
        MoveByKB();
        Zoom();
    }
}
