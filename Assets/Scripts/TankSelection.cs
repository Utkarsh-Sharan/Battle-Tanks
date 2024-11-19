using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    [SerializeField] private TankSpawner _tankSpawner;

    public void RedTankSelected()
    {
        _tankSpawner.CreateTank(TankTypes.RED_TANK);
        this.gameObject.SetActive(false);
    }

    public void BlueTankSelected()
    {
        _tankSpawner.CreateTank(TankTypes.BLUE_TANK);
        this.gameObject.SetActive(false);
    }

    public void GreenTankSelected()
    {
        _tankSpawner.CreateTank(TankTypes.GREEN_TANK);
        this.gameObject.SetActive(false);
    }
}
