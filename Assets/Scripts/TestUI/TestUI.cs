using InterfaceAdapter.Adapter.Login;
using System;
using TMPro;
using Unity;
using UnityEngine;
using UnityEngine.UI;

public class TestUI:MonoBehaviour
{
    [SerializeField]
    private TMP_InputField playerID;
    [SerializeField]
    private Button login;

    private void Awake()
    {
        login.onClick.AddListener(onClickLogin);
    }

    private void onClickLogin()
    {
        ulong id = Convert.ToUInt64(playerID.text);

        IUnityContainer container = GameStart.container;
        var login = container.Resolve<LoginAdapter>();
        login.StartLogin(id);
    }
}
