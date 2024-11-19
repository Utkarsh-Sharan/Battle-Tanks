using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    [System.Serializable]
    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankTypes tankType;
        public Material tankColor;
    }

    [SerializeField] private List<Tank> _tankList;
    [SerializeField] private TankView _tankView;

    private TankModel tankModel;
    private TankController tankController;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CreateTank(TankTypes tankType)
    {
        switch (tankType)
        {
            case TankTypes.RED_TANK:
                tankModel = new TankModel(_tankList[0].tankType, _tankList[0].tankColor, _tankList[0].movementSpeed, _tankList[0].rotationSpeed);
                tankController = new TankController(tankModel, _tankView);
                break;
            case TankTypes.BLUE_TANK:
                tankModel = new TankModel(_tankList[1].tankType, _tankList[1].tankColor, _tankList[1].movementSpeed, _tankList[1].rotationSpeed);
                tankController = new TankController(tankModel, _tankView);
                break;
            case TankTypes.GREEN_TANK:
                tankModel = new TankModel(_tankList[0].tankType, _tankList[2].tankColor, _tankList[2].movementSpeed, _tankList[2].rotationSpeed);
                tankController = new TankController(tankModel, _tankView);
                break;
        }
    }
}
