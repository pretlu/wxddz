using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// unity工具类
/// </summary>
public static class UTool
{

    public static void showUI(GameObject gameObject)
    {
        gameObject.GetComponent<CanvasGroup>().alpha = 1;
        gameObject.GetComponent<CanvasGroup>().interactable = true;
        gameObject.GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
    public static void hiddUI(GameObject gameObject)
    {
        gameObject.GetComponent<CanvasGroup>().alpha = 0;
        gameObject.GetComponent<CanvasGroup>().interactable = false;
        gameObject.GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
    /// <summary>
    /// 显示或隐藏游戏对象
    /// </summary>
    /// <param name="game"></param>
    public static void showOrHidd(GameObject game)
    {
        if (game.GetComponent<CanvasGroup>().alpha == 0)
        {
            showUI(game);
        }
        else
        {
            hiddUI(game);
        }
    }
}
