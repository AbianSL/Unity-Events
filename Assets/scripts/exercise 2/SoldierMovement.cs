using Unity.VisualScripting;
using UnityEngine;

public class SoldierMovement : MonoBehaviour
{
    public float force = 10f;
    public CylinderNotifier triggerActivated;
    private Vector3 direction;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject cylinderObject = GameObject.FindWithTag("Cylinder");
        if (cylinderObject != null)
        {
            direction = Vector3.Normalize(cylinderObject.transform.position - transform.position);
        }
        triggerActivated.OnCylinderTriggered += MoveTowardsCylinder;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void MoveTowardsCylinder()
    {
        GetComponent<Rigidbody>().AddForce(direction * force, ForceMode.VelocityChange);
    }
}
