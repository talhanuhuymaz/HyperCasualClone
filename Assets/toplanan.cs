using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class toplanan : MonoBehaviour
{
    bool isgathered;
    int index;
    public toplayici toplayici;

    void Start()
    {
        isgathered = false;
    }

    void Update()
    {
        if (isgathered == true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }

        }

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "block")
        {
            toplayici.Risedown();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }

    public bool Getisgathered()
    {

        return isgathered;
    }

    public void Yesgathered()
    {
        isgathered = true;
    }

    public void Indexsettings(int index)
    {
        this.index = index;

    }
}
