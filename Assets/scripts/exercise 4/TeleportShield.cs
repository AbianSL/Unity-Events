using UnityEngine;

public class TeleportShield : MonoBehaviour
{
    public NearNotifier nearNotifier;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private Vector3 teleportPosition;
    void Start()
    {
        teleportPosition = GameObject.FindWithTag("TeleportPoint").transform.position;
        nearNotifier.OnNear += Teleport;
    }

    // Update is called once per frame
    void Update()
    {

    }
    
    void Teleport()
    {
        transform.position = teleportPosition;
    }
}
