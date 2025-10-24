using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RedSphereMovement : MonoBehaviour
{
    public float force = 5f;
    public CylinderNotifier triggerActivated;
    public GreenSphere greenSphere;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        triggerActivated.OnCylinderTriggered += MoveTowardsSphere;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void MoveTowardsSphere()
    {
        Vector3 direction = (greenSphere.transform.position - transform.position).normalized;
        GetComponent<Rigidbody>().AddForce(direction * force, ForceMode.VelocityChange);
    }
}
