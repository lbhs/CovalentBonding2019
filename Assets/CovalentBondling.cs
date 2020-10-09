using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CovalentBondling : MonoBehaviour
{
    public void SnapIntoPlace()
    {
        var e = GameObject.FindGameObjectsWithTag("e-");
        var p = GameObject.FindGameObjectsWithTag("proton");

        float nextEPos = -.63f;
        foreach (var Eitem in e)
        {
            Eitem.transform.position = new Vector3(nextEPos,0,0);
            nextEPos += 1.26f;
            Eitem.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Eitem.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }

        float nextPPosX=0;
        float nextPPosY =.52f;
        bool next=true;
        foreach (var Pitem in p)
        {
            if (next)
            {
                Pitem.transform.position = new Vector3(nextPPosX, nextPPosY, 0);
                nextPPosY = -.52f;
            }
            else
            {
                Pitem.transform.position = new Vector3(nextPPosX, nextPPosY, 0);
                nextPPosY = .52f;
                nextPPosX += 1.3f;
            }
            next = !next;
            Pitem.gameObject.GetComponent<Rigidbody>().velocity = Vector3.zero;
            Pitem.gameObject.GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
        }
    }
}
