using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    public float VelocidadeAndar = 5;
    public float VelocidadeRodar = 5;
    CharacterController _characterController;
    private float InputAndar;
    private float InputRodar;
    // Start is called before the first frame update
    void Start()
    {
        _characterController = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        InputAndar = Input.GetAxis("Vertical");
        InputRodar = Input.GetAxis("Horizontal");

        Vector3 novaPosicao = transform.forward * VelocidadeAndar * InputAndar;

        novaPosicao.y = Physics.gravity.y;

        _characterController.Move(novaPosicao * Time.deltaTime);

        _characterController.transform.Rotate(_characterController.transform.up * VelocidadeRodar * InputAndar);
    }
}
