using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectionMarker : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float lifetime = 1f;

    void Start()
    {
        Destroy(gameObject, lifetime);
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
