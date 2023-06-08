using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Animations;

public class MoveController : MonoBehaviour
{
    public Animator animator;
    [SerializeField]
    private float maxSpeed = 300f;

    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        speed = maxSpeed;
        if (Input.GetKey(KeyCode.RightArrow)){
            animator.SetBool("isWalking", true);
        }
        else if (Input.GetKey(KeyCode.LeftArrow)){
            animator.SetBool("isWalking", true);
            speed *= -1;
        }
        else
        {
            animator.SetBool("isWalking", false);
            speed = 0f;
        }
        Vector3 newPosition = new Vector3(this.transform.position.x + speed * Time.deltaTime, this.transform.position.y, this.transform.position.z);
        transform.LookAt(newPosition);
        this.transform.position = newPosition;
    }
}
