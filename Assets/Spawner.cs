using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject pillar;
    public float Spawnrate = 2;
    private float timer = 0;
    public float heightoffset = 3;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawner();
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < Spawnrate)
        {
            timer = timer + Time.deltaTime;
        }
        else
        {
            spawner();
            timer = 0;
        }
    }

    void spawner()
    {
        float lowestpoint = transform.position.y - heightoffset;
        float highestpoint = transform.position.y + heightoffset;
        Instantiate(pillar, new Vector3(transform.position.x,Random.Range(lowestpoint,highestpoint),0), transform.rotation);
    }
}
