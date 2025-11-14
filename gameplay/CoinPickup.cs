using UnityEngine;

public class CoinPickup : MonoBehaviour
{
    [SerializeField] AudioClip coinPickupSFX;
    [SerializeField] int coinValue = 100;

    bool wasCollected = false;
    
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player" && !wasCollected)
        {
            wasCollected = true;
            GameSession gameSession = UnityEngine.Object.FindFirstObjectByType<GameSession>();
            if (gameSession != null)
            {
                gameSession.IncreaseScore(coinValue);
            }
            AudioSource.PlayClipAtPoint(coinPickupSFX, Camera.main.transform.position);
            Destroy(gameObject);
        }
    }
}
