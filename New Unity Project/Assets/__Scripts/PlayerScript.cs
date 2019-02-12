using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    private Rigidbody rb;
    public float speed;
    public Text scoreText;
    private int score;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        score = 0;
        scoreText.text = "Score: " + score;
    }

    private void FixedUpdate()
    {
        float moveUp = Input.GetAxis("Vertical");
        float moveSide = Input.GetAxis("Horizontal");

        Vector3 move = new Vector3(moveSide, 0.0f, moveUp);

        rb.AddForce(move*speed);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            Properties property = other.gameObject.GetComponent<Properties>();
            score += property.PointValue;   
        }
        scoreText.text = "Score: " + score;
    }
}
