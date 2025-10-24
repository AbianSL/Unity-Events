using UnityEngine;

public class CylinderNotifier : MonoBehaviour
{
  public delegate void CylinderTriggered();
  public event CylinderTriggered OnCylinderTriggered;
  // Start is called once before the first execution of Update after the MonoBehaviour is created
  void Start()
  {

  }

  // Update is called once per frame
  void Update()
  {

  }

  void OnTriggerEnter(Collider other)
  {
    if (other.CompareTag("Cube"))
    {
      OnCylinderTriggered();
    }
  }
}

