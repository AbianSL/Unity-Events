using UnityEngine;

public class FaceCube : MonoBehaviour
{
    public NearNotifier nearNotifier;
    private Vector3 directionToFace;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject cubeToFace = GameObject.FindGameObjectWithTag("CubeToFace");
        directionToFace = (cubeToFace.transform.position - transform.position).normalized;
        Debug.Log("Name of this object: " + gameObject.name);
        nearNotifier.OnNear += FaceTowardsCube;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void FaceTowardsCube()
    {
        transform.LookAt(transform.position + directionToFace);
    }
}
