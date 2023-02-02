using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    public Transform target;
    // Start is called before the first frame update
    void Start()
    {
        //this.transform.forward = this.transform.rotation(0, -105, 0);
        this.transform.LookAt(target);
        this.transform.Rotate(0, 105, 0);
    }

    // Update is called once per frame
    void Update()
    {
        float rotateSpeed = 5 * Time.deltaTime;
        Vector3 direc = target.transform.position - this.transform.position;
        Quaternion targetRotation = Quaternion.LookRotation(direc);
        this.transform.localRotation = Quaternion.Slerp(this.transform.rotation, targetRotation, rotateSpeed);
    }
}
