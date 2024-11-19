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

    // Start is called before the first frame update
    void Start()
    {
        CreateTank();
    }

    private void CreateTank()
    {
        //only spawning red tank for now.
        TankModel tankModel = new TankModel(_tankList[0].tankType, _tankList[0].tankColor, _tankList[0].movementSpeed, _tankList[0].rotationSpeed);
        TankController tankController = new TankController(tankModel, _tankView);
    }
}
