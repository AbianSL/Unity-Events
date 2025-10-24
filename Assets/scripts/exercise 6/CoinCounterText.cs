using NUnit;
using UnityEngine;
using UnityEngine.UI;

public class CoinCounterText : MonoBehaviour
{
    public Text counterText;
    private long coinCount = 0;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject[] notifiers = GameObject.FindGameObjectsWithTag("Type 1");
        foreach (GameObject notifierObj in notifiers)
        {
            CoinNotifier notifier = notifierObj.GetComponent<CoinNotifier>();
            if (notifier != null)
            {
                notifier.OnCoinCollected += HandleCoinCollected;
            }
        }

        GameObject[] notifiers2 = GameObject.FindGameObjectsWithTag("Type 2");
        foreach (GameObject notifierObj in notifiers2)
        {
            CoinNotifier notifier = notifierObj.GetComponent<CoinNotifier>();
            if (notifier != null)
            {
                notifier.OnCoinCollected += HandleCoinCollected;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
    }

    void HandleCoinCollected(string coinType)
    {
        if (coinType == "Type 1")
        {
            coinCount += 5;
            Debug.Log("Coin Count: " + coinCount);
            counterText.text = coinCount.ToString();
        }
        else if (coinType == "Type 2")
        {
            coinCount += 10;
            Debug.Log("Coin Count: " + coinCount);
            counterText.text = coinCount.ToString();
        }
    }
}
