using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour {

    //Vector3 dir = Vector3.zero;
    //float speed = 100.0f;

    // Use this for initialization
    void Start()
    {
        //Physics.gravity = Vector3.zero;
    }



    float speed = 10.0f;

    void Update()
    {
        Vector3 dir = Vector3.zero;

        // we assume that device is held parallel to the ground
        // and Home button is in the right hand

        // remap device acceleration axis to game coordinates:
        //  1) XY plane of the device is mapped onto XZ plane
        //  2) rotated 90 degrees around Y axis
        dir.x = -Input.acceleration.y;
        dir.z = Input.acceleration.x;

        // clamp acceleration vector to unit sphere
        if (dir.sqrMagnitude > 1)
            dir.Normalize();

        // Make it move 10 meters per second instead of 10 meters per frame...
        dir -= Input.gyro.gravity;
        dir *= Time.deltaTime;

        // Move object
        GameObject.Find("Planes").transform.Translate(dir * speed);
    }



    // Update is called once per frame
    //void Update()
    //{

    //    ////////dir = Vector3.zero;

    //    ////////dir = Input.acceleration;

    //    ////////// clamp acceleration vector to unit sphere
    //    ////////if (dir.sqrMagnitude > 1)
    //    ////////{
    //    ////////    dir.Normalize();
    //    ////////}

    //    //////////dir *= Time.deltaTime;

    //    //////////Rigidbody rig;
    //    //////////try { rig = gameObject.GetComponent<Rigidbody>(); } catch { Debug.LogError("Missing Compenent"); return; }

    //    ////////////rig.AddForce(dir * speed);
    //    //////////rig.AddForce(dir);
    //    ////////Debug.Log(dir);
    //    ////////Debug.Log(dir * speed);
    //}

    private void OnGUI()
       {
           Debug.Log("X-Accel: " + Input.acceleration.x.ToString());
           Debug.Log("Y-Accel: " + Input.acceleration.y.ToString());
           Debug.Log("Z-Accel: " + Input.acceleration.z.ToString());
       }

    //float speed = 10F;
    //Rigidbody rb;

    //void Start()
    //{
    //    rb = GetComponent<Rigidbody>();
    //}

    //void FixedUpdate()
    //{
    //    Vector3 acc = Input.acceleration;
    //    rb.AddForce(acc.x * speed, 0, acc.y * speed);
    //}
}
