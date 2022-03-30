using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanManager : MonoBehaviour
{
    public GameObject human;
    public float value;
    public Vector3 sizeChange;

    public void MoveLeft()
    {
        value = value-2f;
        human.transform.position = new Vector3(value,0, 0);
    }
    public void RotateLeft()
    {
        human.transform.Rotate(20f, 10f, 10f);
    }
    public void Grow()
    {
        human.transform.localScale = human.transform.localScale + sizeChange;
    }
    public void ResetHuamn() {
        human.transform.position=new Vector3(0,0,0);
        human.transform.rotation=Quaternion.Euler(new Vector3(0,0,0));
        human.transform.localScale=new Vector3(1,1,1);
    }
}
