using UnityEngine;

public class NearNotifier : MonoBehaviour
{
    public delegate void NearHandler();
    public event NearHandler OnNear;
    public float detectionRadius = 5f;
    private GameObject cube;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cube = GameObject.FindGameObjectWithTag("Cube");
    }

    // Update is called once per frame
    void Update()
    {
        if (cube != null)
        {
            float distance = Vector3.Distance(transform.position, cube.transform.position);
            if (distance <= detectionRadius)
            {
                OnNear?.Invoke();
            }
        }
    }
    
}
