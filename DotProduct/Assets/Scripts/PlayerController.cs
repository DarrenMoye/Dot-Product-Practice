using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    void Update()
    {
        Up();
        Right();
        Left();
        Down();

        RotateLeft();
        RotateRight();
    }

    public void Up()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            for (int i = 0; i < 10; i++)
            {
                gameObject.transform.position += new Vector3(0f, 0f, 0.001f);
            }
        }
    }

    public void Right()
    {
        if (Input.GetKey(KeyCode.RightArrow))
        {
            for (int i = 0; i < 10; i++)
            {
                gameObject.transform.position += new Vector3(0.001f, 0f, 0f);
            }
        }
    }

    public void Left()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            for (int i = 0; i < 10; i++)
            {
                gameObject.transform.position += new Vector3(-0.001f, 0f, 0f);
            }
        }
    }

    public void Down()
    {
        if (Input.GetKey(KeyCode.DownArrow))
        {
            for (int i = 0; i < 10; i++)
            {
                gameObject.transform.position += new Vector3(0f, 0f, -0.001f);
            }
        }
    }

    public void RotateRight()
    {
        if (Input.GetKey("e"))
        {
            for (int i = 0; i < 10; i++)
            {
                gameObject.transform.Rotate(0f, 0.01f, 0f);
            }
        }
    }

    public void RotateLeft()
    {
        if (Input.GetKey("q"))
        {
            for (int i = 0; i < 10; i++)
            {
                gameObject.transform.Rotate(0f, -0.01f, 0f);
            }
        }
    }
}


