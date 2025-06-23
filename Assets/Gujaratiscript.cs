using UnityEngine;
public class Gujaratiscript : MonoBehaviour
{
    public Rigidbody2D myrigidbody;
    public float Flapstrength;
    public Logic mogli;
    public bool birdisalive = true;
    public AudioSource gaana1;
    public AudioSource gaana2;
    public GameObject bird;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        gaana1.Play();
        mogli = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdisalive==true)
        {

            myrigidbody.linearVelocity = Vector2.up * Flapstrength;
        }
        if(transform.position.y < -15)
        {
            mogli.gameover1();
            birdisalive = false;
            gaana1.Stop();
            gaana2.Play();
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        mogli.gameover1();
        birdisalive = false;
        gaana1.Stop();
        gaana2.Play();
    }
}
