using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SecondaryOrbit : MonoBehaviour
{
    [SerializeField] Transform moon;
    [SerializeField] Transform parent;
    void Start()
    {
        moon.SetParent(parent);
    }

    // Update is called once per frame
    void Update()
    {
        moon.transform.RotateAround(parent.position,Vector3.down, 20 * Time.deltaTime);
    }
}
