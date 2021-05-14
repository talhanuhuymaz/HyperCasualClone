using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toplayici : MonoBehaviour
{
    GameObject manecube;

    int rise;
    void Start()
    {
        manecube = GameObject.Find("Cube");
    }

 
    void Update()
    {
        manecube.transform.position = new Vector3(transform.position.x, rise + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -rise, 0);
    }

    public void Risedown()
    {
        rise--;
    }


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "takepotion" && other.gameObject.GetComponent<toplanan>().Getisgathered()==false)
        {
            rise += 1;

            other.gameObject.GetComponent<toplanan>().Yesgathered();
            other.gameObject.GetComponent<toplanan>().Indexsettings(rise);
            other.gameObject.transform.parent = manecube.transform;
        }
    }
}
