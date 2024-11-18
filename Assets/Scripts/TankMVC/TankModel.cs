using UnityEngine;

public class TankModel
{
    private TankController _tankController;

    private float _movementSpeed;
    private float _rotationSpeed;

    public TankModel(float movement, float rotation) 
    {
        _movementSpeed = movement;
        _rotationSpeed = rotation;
    }

    public void SetTankController(TankController tankController)
    {
        _tankController = tankController;
    }

    public float GetMovementSpeed()
    {
        return _movementSpeed;
    }

    public float GetRotationSpeed()
    {
        return _rotationSpeed;
    }
}
