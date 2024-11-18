using UnityEngine;

public class TankController
{
    private TankModel _tankModel;
    private TankView _tankView;

    public TankController(TankModel tankModel, TankView tankView)
    {
        _tankModel = tankModel;
        _tankView = tankView;

        _tankModel.SetTankController(this);
        _tankView.SetTankController(this);

        GameObject.Instantiate(_tankView.gameObject, _tankView.transform.position, Quaternion.identity);
    }
}
