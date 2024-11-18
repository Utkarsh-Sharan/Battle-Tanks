using UnityEngine;

public class TankController
{
    private TankModel _tankModel;
    private TankView _tankView;

    private Rigidbody _tankBody;

    public TankController(TankModel tankModel, TankView tankView)
    {
        _tankModel = tankModel;
        _tankView = GameObject.Instantiate<TankView>(tankView);
        _tankBody = _tankView.GetRigidBody();

        _tankModel.SetTankController(this);
        _tankView.SetTankController(this);
    }

    public void Move(float movement, float movementSpeed)
    {
        _tankBody.velocity = _tankView.transform.forward * movement * movementSpeed;
    }

    public void Rotate(float rotate, float rotationSpeed)
    {
        Vector3 vector = new Vector3(0f, rotate * rotationSpeed, 0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        _tankBody.MoveRotation(_tankBody.rotation * deltaRotation);
    }

    public TankModel GetTankModel()
    {
        return _tankModel;
    }
}
