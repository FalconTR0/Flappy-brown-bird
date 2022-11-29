using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class hareket : MonoBehaviour
{
    bool isMute;
    public AudioSource seskontrol;
    public AudioClip coinses;
    public AudioClip jumpses;
    public bool isDead;

    public float velocity = 1f;
    public Rigidbody2D rb2D;

    public GameManager managerGame;

    public GameObject DeathScreen;

    private void Start()
    {
        Time.timeScale = 1;
        seskontrol = GetComponent<AudioSource>();
    }

    void Update()
    {
        //Týklamayý Al
        if (Input.GetMouseButtonDown(0))
        {
            //Havada Kuþu Sýçrats
            rb2D.velocity = Vector2.up * velocity;
            seskontrol.PlayOneShot(jumpses);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "ScoreArea")
        {
            seskontrol.PlayOneShot(coinses);
            managerGame.UpdateScore();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "DeathArea")
        {
            isDead = true;
            Time.timeScale = 0;

            DeathScreen.SetActive(true);
        }
    }
}
