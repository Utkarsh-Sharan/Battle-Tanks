using UnityEngine;

public class TankModel
{
    private TankController _tankController;

    [SerializeField] private TankTypes _tankType;
    private Material _tankColor;

    private float _movementSpeed;
    private float _rotationSpeed;

    public TankModel(TankTypes tankType, Material tankColor, float movement, float rotation) 
    {
        _tankType = tankType;
        _tankColor = tankColor;
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

    public Material GetTankColor()
    {
        return _tankColor;
    }
}
