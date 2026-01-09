using UnityEditor;
using UnityEngine;
public class ProjectExtension : MonoBehaviour
{

    /*
     * 只要根目录是"Assets",他就会出现在Project面板的右键菜单里
     * 此时，你的调用方法可以加一个名为MenuCommand的参数。
     */

    [MenuItem("Assets/Sample/Project Menu Test")]
    public static void ProjectMenuTest(MenuCommand menuCommand)
    {
        Debug.Log("你触发了Project面板的一个自定义菜单项");
    }
}