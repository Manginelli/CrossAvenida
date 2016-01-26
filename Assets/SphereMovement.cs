using UnityEngine;
using System.Collections;


// Somente controla os movimentos do cubo para esquerda e direita
public class SphereMovement : MonoBehaviour
{

    Animator playerAnim;
    int moveFowardHash = Animator.StringToHash("Press W");
    int moveRightHash = Animator.StringToHash("Press D");
    int moveLeftHash = Animator.StringToHash("Press A");
    Transform playerTransf;

    void Start()
    {
        playerTransf = (Transform)gameObject.GetComponent("Transform");
        playerAnim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {

        if (!GameManagement.isStop)
        {
            // 6f e -6f são os limites para onde o jogador pode andar
            if (Input.GetKeyDown("a") && playerTransf.position.x > -5.5f)
            {
                playerAnim.SetTrigger(moveLeftHash);
                //playerTransf.position = new Vector3(playerTransf.position.x - 2f,
                //                                     playerTransf.position.y,
                //                                     playerTransf.position.z);

            }
            else if (Input.GetKeyDown("d") && playerTransf.position.x < 5.5f)
            {
                playerAnim.SetTrigger(moveRightHash);
                //playerTransf.position = new Vector3(playerTransf.position.x + 2f,
                //                                     playerTransf.position.y,
                //                                     playerTransf.position.z);
            }
            if (Input.GetKeyDown("w"))
            {
                playerAnim.SetTrigger(moveFowardHash);
                Score.IncreaseScore();
            }
        }

        

    }

    void OnTriggerEnter()
    {
        GameManagement.Stop();

    }

}