using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    [SerializeField] private Rigidbody _tankBody;

    private TankController _tankController;

    private float _movement;
    private float _rotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if(_movement != 0)
        {
            _tankController.Move(_movement, 30);    //will give speed with model later.
        }

        if(_rotation != 0)
        {
            _tankController.Rotate(_rotation, 20);  //will give rotation with model later.
        }
    }

    private void Movement()
    {
        _movement = Input.GetAxis("Vertical");
        _rotation = Input.GetAxis("Horizontal");
    }

    public void SetTankController(TankController tankController)
    {
        _tankController = tankController;
    }

    public Rigidbody GetRigidBody()
    {
        return _tankBody;
    }
}
