using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : Singleton<GameController>
{
    public void StartLaunch() {
        Rocket.Instance.Launch();
        UIManager.Instance.ShowBuildPanel(false);
    }
}
