using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float flyPower;

    public AudioClip flyClip;
    public AudioClip startClip;
    public AudioClip gameOverClip;
    private AudioSource audioSource;

    GameObject obj;
    public GameObject gameController;

    // Start is called before the first frame update
    void Start()
    {
        obj = gameObject;
        audioSource = obj.GetComponent<AudioSource>();
        audioSource.clip = startClip;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))//nhấn chuột trái để tác động lực
        {
            audioSource.clip = flyClip;
            if (!gameController.GetComponent<GameController>().isEndGame)
            {
                audioSource.Play();//âm thanh
            }
            obj.GetComponent<Rigidbody2D>().AddForce(new Vector2(0, flyPower));
        }
    }
    private void OnCollisionEnter2D(Collision2D other)//khi va chạm
    {
        EndGame();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        gameController.GetComponent<GameController>().GamePoint();
    }
    public void EndGame()
    {
        audioSource.clip = gameOverClip;
        audioSource.Play();//phát âm thanh khi chết
        gameController.GetComponent<GameController>().EndGame();
    }

}
