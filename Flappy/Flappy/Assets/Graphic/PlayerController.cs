using UnityEngine.SceneManagement;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private Vector2 flapForce = new Vector2(0, 100);
    [SerializeField]
    private GameObject endScreen;
    [SerializeField]
    private TextMeshProUGUI pointsCount;
    [SerializeField]
    private AudioSource audioSource;

    public int Points = 0;

    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
    }

    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Flap();
        }
    }

    private void Flap()
    {
        rb.AddForce(flapForce);
    }

    public void Failed()
    {
        audioSource.pitch = -0.35f;
        pointsCount.text = Points.ToString();
        endScreen.SetActive(true);
        Time.timeScale = 0f;
    }

    public void Restart()
    {
        audioSource.pitch = 1f;
        SceneManager.LoadScene(1);
        Time.timeScale = 1f;
    }
    public void Quit()
    {
        Application.Quit();
    }
}

