using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float _speed = 5.0f;
    Animator anim;
    float Idle_walk_ratio;
    float Walk_run_ratio;

    void Start()
    {
        Managers.Input.KeyAction -= OnKeyboard;
        Managers.Input.KeyAction += OnKeyboard;

        anim = gameObject.GetComponent<Animator>();
    }

    void Update()
    {
        
   
    }

    void OnKeyboard()
    {
        //walk
        if (Input.GetKey(KeyCode.W))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.4f);
            transform.position += Vector3.forward * Time.deltaTime * _speed;
            Idle_walk_ratio = Mathf.Lerp(Idle_walk_ratio, 1, 5.0f * Time.deltaTime);
            anim.SetFloat("Idle_walk_ratio", 1);
            anim.Play("Idle_walk");
        }
        if (Input.GetKey(KeyCode.S) )
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.4f);
            transform.position += Vector3.back * Time.deltaTime * _speed;
            Idle_walk_ratio = Mathf.Lerp(Idle_walk_ratio, 1, 5.0f * Time.deltaTime);
            anim.SetFloat("Idle_walk_ratio", 1);
            anim.Play("Idle_walk");
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.4f);
            transform.position += Vector3.left * Time.deltaTime * _speed;
            Idle_walk_ratio = Mathf.Lerp(Idle_walk_ratio, 1, 5.0f * Time.deltaTime);
            anim.SetFloat("Idle_walk_ratio", 1);
            anim.Play("Idle_walk");
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.4f);
            transform.position += Vector3.right * Time.deltaTime * _speed;
            Idle_walk_ratio = Mathf.Lerp(Idle_walk_ratio, 1, 5.0f * Time.deltaTime);
            anim.SetFloat("Idle_walk_ratio", 1);
            anim.Play("Idle_walk");
        }


        //run
        if (Input.GetKey(KeyCode.W) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.forward), 0.4f);
            transform.position += Vector3.forward * Time.deltaTime * _speed;
            Walk_run_ratio = Mathf.Lerp(Walk_run_ratio, 1, 5.0f * Time.deltaTime);
            anim.SetFloat("Walk_run_ratio", 1);
            anim.Play("Walk_run");
        }
        if (Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.back), 0.4f);
            transform.position += Vector3.back * Time.deltaTime * _speed;
            Walk_run_ratio = Mathf.Lerp(Walk_run_ratio, 1, 5.0f * Time.deltaTime);
            anim.SetFloat("Walk_run_ratio", 1);
            anim.Play("Walk_run");
        }
        if (Input.GetKey(KeyCode.A) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.left), 0.4f);
            transform.position += Vector3.left * Time.deltaTime * _speed;
            Walk_run_ratio = Mathf.Lerp(Walk_run_ratio, 1, 5.0f * Time.deltaTime);
            anim.SetFloat("Walk_run_ratio", 1);
            anim.Play("Walk_run");
        }
        if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.LeftShift))
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.right), 0.4f);
            transform.position += Vector3.right * Time.deltaTime * _speed;
            Walk_run_ratio = Mathf.Lerp(Walk_run_ratio, 1, 5.0f * Time.deltaTime);
            anim.SetFloat("Walk_run_ratio", 1);
            anim.Play("Walk_run");
        }
       
    }


}
