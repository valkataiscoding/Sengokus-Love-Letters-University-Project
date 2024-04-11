using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShootArrow : MonoBehaviour
{
    private RaycastHit hit;
    Animator enemyAnimator;
    public Animator characterAnimator;
    private int deaths = 0;
    public string scene;

    public int score = 0;


    public AK.Wwise.Event BowReleaseEvent;
    public AK.Wwise.Event ArrowShootEvent;
    public AK.Wwise.Event BanditDyingEvent;


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
            characterAnimator.SetTrigger("Active");
            BowReleaseEvent.Post(gameObject);
        }
    }

    void Shoot()
    {
        //characterAnimator.Play("Shoot"); 

        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit))
        {
            if (hit.collider.gameObject.layer == 8 && hit.collider.gameObject.GetComponent<EnemyShot>().isHit == false)
            {
                enemyAnimator = hit.collider.gameObject.GetComponent<Animator>();
                ArrowShootEvent.Post(gameObject);
                enemyAnimator.Play("Dying Backwards");
                BanditDyingEvent.Post(gameObject);

                if (hit.collider.gameObject.GetComponent<NPCWaypoint>() != null)
                {
                    var agent = hit.collider.gameObject.GetComponent("NavMeshAgent");
                    Destroy(agent);
                    hit.collider.gameObject.GetComponent<NPCWaypoint>().enabled = false;
                }

                Destroy(hit.collider.gameObject, 5f);
                deaths++;

                score++;
                hit.collider.gameObject.GetComponent<EnemyShot>().isHit = true;
            }

            if (deaths == 50)
            {
                SceneManager.LoadScene(scene);
            }
        }
    }
}
