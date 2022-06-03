using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptMovement : MonoBehaviour
{
    public float rSpeed = 75f, tSpeed = 12f;
    public float unT, unR;
    public GameObject[] lights = new GameObject[10];
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        unT = Input.GetAxis("Vertical") * tSpeed;
        unR = Input.GetAxis("Horizontal") * rSpeed;
        transform.Translate(0, 0, unT * Time.deltaTime);
        transform.Rotate(0, unR * Time.deltaTime, 0);        
        if(transform.position.z < -27f){
            lights[0].SetActive(true);
            lights[1].SetActive(true);
            lights[2].SetActive(true);
            lights[3].SetActive(false);
            lights[4].SetActive(false);
            lights[5].SetActive(false);
            lights[6].SetActive(false);
            lights[7].SetActive(false);
            lights[8].SetActive(false);
            lights[9].SetActive(false);
        }else if(transform.position.z > -27f && transform.position.z < 4f){
            lights[0].SetActive(false);
            lights[1].SetActive(true);
            lights[2].SetActive(true);
            lights[3].SetActive(true);
            lights[4].SetActive(false);
            lights[5].SetActive(false);
            lights[6].SetActive(false);
            lights[7].SetActive(false);
            lights[8].SetActive(false);
            lights[9].SetActive(false);
        }else if(transform.position.z > 4f && transform.position.z < 35f){
            lights[0].SetActive(false);
            lights[1].SetActive(false);
            lights[2].SetActive(true);
            lights[3].SetActive(true);
            lights[4].SetActive(true);
            lights[5].SetActive(false);
            lights[6].SetActive(false);
            lights[7].SetActive(false);
            lights[8].SetActive(false);
            lights[9].SetActive(false);
        }else if(transform.position.z > 35f && transform.position.z < 65f){
            lights[0].SetActive(false);
            lights[1].SetActive(false);
            lights[2].SetActive(false);
            lights[3].SetActive(true);
            lights[4].SetActive(true);
            lights[5].SetActive(true);
            lights[6].SetActive(false);
            lights[7].SetActive(false);
            lights[8].SetActive(false);
            lights[9].SetActive(false);
        }else if(transform.position.z > 65f && transform.position.z < 92f){
            lights[0].SetActive(false);
            lights[1].SetActive(false);
            lights[2].SetActive(false);
            lights[3].SetActive(false);
            lights[4].SetActive(true);
            lights[5].SetActive(true);
            lights[6].SetActive(true);
            lights[7].SetActive(false);
            lights[8].SetActive(false);
            lights[9].SetActive(false);
        }else if(transform.position.z > 92f && transform.position.z < 120f){
            lights[0].SetActive(false);
            lights[1].SetActive(false);
            lights[2].SetActive(false);
            lights[3].SetActive(false);
            lights[4].SetActive(false);
            lights[5].SetActive(true);
            lights[6].SetActive(true);
            lights[7].SetActive(true);
            lights[8].SetActive(false);
            lights[9].SetActive(false);
        }else if(transform.position.z > 120f && transform.position.z < 180f){
            lights[0].SetActive(false);
            lights[1].SetActive(false);
            lights[2].SetActive(false);
            lights[3].SetActive(false);
            lights[4].SetActive(false);
            lights[5].SetActive(false);
            lights[6].SetActive(true);
            lights[7].SetActive(true);
            lights[8].SetActive(false);
            lights[9].SetActive(false);
        }else if(transform.position.z > 180f){
            lights[0].SetActive(false);
            lights[1].SetActive(false);
            lights[2].SetActive(false);
            lights[3].SetActive(false);
            lights[4].SetActive(false);
            lights[5].SetActive(false);
            lights[6].SetActive(false);
            lights[7].SetActive(true);
            lights[8].SetActive(true);
            lights[9].SetActive(true);
        }

    }
}
