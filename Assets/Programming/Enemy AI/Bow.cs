using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bow : MonoBehaviour
{
    float arrowSpeed = 100;
    public GameObject arrow;
    Vector3 arrowNextPosition;

    void Shoot()
    {
        GameObject tempArrow = Instantiate(arrow, transform.position, transform.rotation) as GameObject;
        //Rigidbody tempRigidBodyArrow = tempArrow.GetComponent<Rigidbody>();
        //tempRigidBodyArrow.AddForce(tempRigidBodyArrow.transform.forward * arrowSpeed);

        Vector3 mouse = Input.mousePosition;
        Ray castPoint = Camera.main.ScreenPointToRay(mouse);
        RaycastHit hit = new RaycastHit();
        if (Physics.Raycast(castPoint, out hit))
        {

            arrowNextPosition = hit.point;
            //arrow.transform.rotation = hit.transform.rotation;
            //Debug.Log(tempArrow.transform.position);
            //Debug.Log(arrowNextPosition);
            tempArrow.transform.position = arrowNextPosition;
            tempArrow.transform.rotation = arrow.transform.rotation;
            //Vector3 tempVect = hit.point - tempArrow.transform.position;
            //tempVect = tempVect.normalized * 30f * Time.deltaTime;
            //tempRigidBodyArrow.AddForce(tempVect * arrowSpeed);

            //tempRigidBodyArrow.MovePosition(tempArrow.transform.position + tempVect);
            //tempArrow.transform.position = Vector3.MoveTowards(tempArrow.transform.position, arrowNextPosition, 0.5f * Time.deltaTime);
        }


        //targetObject is mouse click

        Destroy(tempArrow, 1f);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Wait());

        }
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(0.1f);
        Shoot();
    }
}

// Create a temporary Arrow, a copy of the original one
// Get Mouse Click Position (where the cursor is, while shooting)
// Move tempArrow toward the position of the cursor, if it hits an enemy
// Destroy temparrow