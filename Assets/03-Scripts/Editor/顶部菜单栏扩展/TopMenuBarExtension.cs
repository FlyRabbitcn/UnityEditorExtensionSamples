using UnityEngine;
using UnityEditor;
public class TopMenuBarExtension : Editor
{
    /*
     * 使用MenuItem特性即可在顶部菜单栏添加一个选项。
     * 点击此选项，便可执行特定的方法，需要注意的是，该方法必须是静态方法。
     */

    [MenuItem("Sample/顶部菜单栏/打开持久化存储文件夹")]
    public static void OpenPersistentDataFolder()
    {
        EditorUtility.RevealInFinder(Application.persistentDataPath);
    }


    [MenuItem("Sample/顶部菜单栏/显示选中物体的名称")]
    public static void ShowSelectedGameObjectName()
    {
        string name = Selection.activeGameObject.name;
        EditorUtility.DisplayDialog("选中物体", $"你选中的物体的名称为{name}", "ok");
    }

    /*
     * 你可以给一个菜单项添加验证方法，如果此方法不返回true，这个菜单选项就是灰色的，不能选中。
     * 这里的范例是你必须选中了一个物体才能验证通过。
     */

    [MenuItem("Sample/顶部菜单栏/显示选中物体的名称", true)]
    public static bool ShowSelectedGameObjectName_Validate()
    {
        if (Selection.activeGameObject == null)
        {
            return false;
        }

        return true;
    }
}