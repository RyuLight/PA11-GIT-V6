using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private float xSpeed = -4f;
    private GameManager GM;
    // Start is called before the first frame update
    void Start()
    {
        GM = GameObject.Find("GameManager").GetComponent<GameManager>();   
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(xSpeed*Time.deltaTime, 0, 0f));
        if (transform.position.y < -5)
        {
            Destroy(this.gameObject);
        }
        if (transform.position.x < -9)
        {
            GM.ScoreUpdate(1);
            Destroy(this.gameObject);
        }
    }
}
