using UnityEngine;

public class CoinNotifier : MonoBehaviour
{
    public delegate void CoinCollectedHandler(string coinType);
    public event CoinCollectedHandler OnCoinCollected;
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
        if (gameObject.CompareTag("Type 1"))
        {
            OnCoinCollected?.Invoke("Type 1");
            gameObject.SetActive(false);
        }
        else if (gameObject.CompareTag("Type 2"))
        {
            OnCoinCollected?.Invoke("Type 2");
            gameObject.SetActive(false);
        }
    }
}
