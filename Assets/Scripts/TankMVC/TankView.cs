using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankView : MonoBehaviour
{
    [SerializeField] private Rigidbody _tankBody;
    [SerializeField] private MeshRenderer[] _children;

    private TankController _tankController;

    private float _movement;
    private float _rotation;

    // Start is called before the first frame update
    void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f, 3f, -4f);
    }

    // Update is called once per frame
    void Update()
    {
        Movement();

        if(_movement != 0)
        {
            _tankController.Move(_movement, _tankController.GetTankModel().GetMovementSpeed());
        }

        if(_rotation != 0)
        {
            _tankController.Rotate(_rotation, _tankController.GetTankModel().GetRotationSpeed());
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

    public void ChangeColor(Material color)
    {
        foreach(MeshRenderer child in _children)
        {
            child.material = color;
        }
    }
}
