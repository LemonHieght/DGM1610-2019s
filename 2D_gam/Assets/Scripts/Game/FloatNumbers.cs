using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FloatNumbers : MonoBehaviour
{
    public float numberSpeed;
    public int damageNumber;
    public Text displayNumber;
    public float decay;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        displayNumber.text = "" + damageNumber;
        transform.position = new Vector3(transform.position.x, transform.position.y + (numberSpeed * Time.deltaTime), transform.position.z);

        decay -= Time.deltaTime;
        if(decay <= 0)
        {
            Destroy (gameObject);
        }
    }
}
