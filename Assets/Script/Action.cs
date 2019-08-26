using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// 事件函数
/// </summary>
public class Action : MonoBehaviour
{
    // Start is called before the first frame update
    GameObject loginPanel;
    void Start()
    {
        loginPanel = GameObject.Find("loginPanel");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    /// <summary>
    /// 显示 隐藏 注册面板
    /// </summary>
    /// <param name="game"></param>
    public void LoginPanelShowHidd()
    {
        Debug.Log("show login");
        UTool.showOrHidd(loginPanel);
    }
    /// <summary>
    /// 进入菜单场景
    /// </summary>
    public void LoadSceneMenu()
    {
        SceneManager.LoadScene("Menu");
    }
    /// <summary>
    /// 进入房间场景
    /// </summary>
    public void LoadSceneRoom()
    {
        SceneManager.LoadScene("Room");
    }
    public void LoadSceneStart()
    {
        SceneManager.LoadScene("Start");
    }
}
