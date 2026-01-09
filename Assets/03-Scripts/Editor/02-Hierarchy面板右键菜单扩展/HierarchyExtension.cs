using UnityEngine;
using UnityEditor;
public class HierarchyExtension : Editor
{
    /*
     * 只要根目录是"GameObject",他就会出现在Hierarchy面板的右键菜单里
     * 此时，你的调用方法可以加一个名为MenuCommand的参数。
     * 因为Hierarchy面板的右键菜单里内容过多，可以通过参数调整一下菜单项所在的位置，这里就不详细解释了
     * 
     */

    [MenuItem("GameObject/Sample/Create Empty", false, 10)]
    public static void CreateEmpty(MenuCommand menuCommand)
    {
        //创建新物体
        GameObject gameObject = new GameObject("GameObject");
        //设置父节点
        GameObjectUtility.SetParentAndAlign(gameObject, menuCommand.context as GameObject);
        //支持撤销操作
        Undo.RegisterCreatedObjectUndo(gameObject, "Create Game Object");
        //选中物体
        Selection.activeObject = gameObject;
    }
}