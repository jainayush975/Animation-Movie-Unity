using UnityEngine;
using System.Collections;

public class sm_rocket_01 : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
      transform.Translate(Vector3.right * Time.deltaTime*50);

    }
}