using UnityEngine;

public class CoinSpin : MonoBehaviour
{
    [SerializeField] private float rotationSpeed = 180f;

    [SerializeField] private float floatSpeed = 1f;
    [SerializeField] private float floatHeight = 0.5f;

    [SerializeField] private string message = "Coin collected! Score: ";
    [SerializeField] private int coinValue = 1;

    private Vector3 startPosition;

    void Start()
    {
        startPosition = transform.position;
    }

    void Update()
    {
        transform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);

        float offsetY = Mathf.PingPong(Time.time * floatSpeed, floatHeight);
        transform.position = startPosition + new Vector3(0f, offsetY, 0f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.AddScore(coinValue);
            Debug.Log(message + GameManager.Instance.score);
            Destroy(gameObject);
        }
    }
}