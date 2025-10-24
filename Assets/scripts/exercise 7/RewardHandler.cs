using UnityEngine;

public class RewardHandler : MonoBehaviour
{
    public CoinCounterWithReward coinCounterM;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject rewardImage;
    private long frames = 0;
    void Start()
    {
        coinCounterM.OnRewardEarned += HandleRewardEarned;
    }

    // Update is called once per frame
    void Update()
    {
        if (frames % 240 == 0)
        {
            rewardImage.SetActive(false);
            frames = 1;
        }
        frames++;
    }

    void HandleRewardEarned()
    {
        Debug.Log("Reward Earned!");
        rewardImage.SetActive(true);
        frames = 1;
    }
}
