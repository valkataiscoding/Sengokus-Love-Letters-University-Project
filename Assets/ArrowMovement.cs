using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrowMovement : MonoBehaviour
{
    public GameObject targetObject;
    Vector3 targetObjectNextPosition;
    float targetObjectHeight;
    //public GameObject arrow;

    RaycastHit hit;

    void Start()
    {
        targetObjectNextPosition = targetObject.transform.position;
        targetObjectHeight = targetObject.GetComponent<MeshRenderer>().bounds.size.y;
    }

    void Update()
    {
        GameObject tempArrow = Instantiate(targetObject, transform.position, transform.rotation) as GameObject;

        if (Input.GetMouseButtonUp(0))
        {

            Vector3 worldMousePosition = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 100f));

            Vector3 direction = worldMousePosition - Camera.main.transform.position;

            if (Physics.Raycast(Camera.main.transform.position, direction, out hit, 100f))
            {

                Debug.DrawLine(Camera.main.transform.position, hit.point, Color.green, 0.5f);

                if (hit.collider.gameObject.tag == "Enemy")
                {

                    targetObjectNextPosition = hit.point + new Vector3(0f, targetObjectHeight / 2f, 0f);

                }

                //targetObject.transform.position = targetObjectNextPosition;

            }
            else
            {

                Debug.DrawLine(Camera.main.transform.position, worldMousePosition, Color.red, 0.5f);

            }

        }

        Debug.DrawLine(targetObject.transform.position, targetObjectNextPosition, Color.blue, 0.5f);
        tempArrow.transform.position = Vector3.MoveTowards(targetObject.transform.position, targetObjectNextPosition, 30f * Time.deltaTime);
        //WaitAndDisable();
        //tempArrow.transform.position = Vector3.MoveTowards(targetObject.transform.position, targetObjectNextPosition, 30f * Time.deltaTime);

    }

    public void WaitAndDisable()
    {
        StartCoroutine(Wait());
    }

    IEnumerator Wait()
    {
        yield return new WaitForSeconds(2f);
    }
}
