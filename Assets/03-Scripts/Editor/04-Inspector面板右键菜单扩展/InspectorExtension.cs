using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEditor;
public class InspectorExtension : MonoBehaviour
{
    /*
     * 只要根目录是"CONTEXT/[组件名]",他就会出现在Inspector面板相应组件的右键菜单里
     * 你也可以点击右上角的三个点来选择菜单项
     */

    [MenuItem("CONTEXT/Transform/缩放设为10")]
    public static void TransformTest(MenuCommand menuCommand)
    {
        Transform transform = (Transform)menuCommand.context;
        transform.localScale = new Vector3(10, 10, 10);
    }
}