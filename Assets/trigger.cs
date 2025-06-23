using UnityEngine;

public class trigger : MonoBehaviour
{
    public Logic mogli;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        mogli = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logic>(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.layer == 3)
        {
            mogli.addscore(1);
        }
        
    }
}
