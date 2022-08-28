using MelonLoader;
using System;
using System.Linq;
using UnityEngine;
using UnityEngine.UI;

namespace AddItemMod
{

    public static class BuildInfo
    {
        public const string Name = "AddItemMod";
        public const string Description = "Mod to Add Item";
        public const string Author = "donimuzur"; // Author of the Mod.  (MUST BE SET)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "2.0.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)    
    }

    public class AddItemMod : MelonMod
    {

        private GameManager component = null;
        private GameObject obj = null;
        private GameObject buttonTemplate = null;
        public override void OnApplicationStart()
        {
            MelonLogger.Msg("AddItemMod Started");
        }
        public override void OnUpdate()
        {
            if (Input.GetKeyUp(KeyCode.RightControl) && Input.GetKeyUp(KeyCode.Alpha6))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemBread(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightControl) && Input.GetKeyUp(KeyCode.Alpha7))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemMeat(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightControl) && Input.GetKeyUp(KeyCode.Alpha8))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemEggs(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightControl) && Input.GetKeyUp(KeyCode.Alpha9))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemFruit(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightControl) && Input.GetKeyUp(KeyCode.Alpha0))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemTool(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightAlt) && Input.GetKeyUp(KeyCode.Alpha6))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemPlatemail(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightAlt) && Input.GetKeyUp(KeyCode.Alpha7))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemShield(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightAlt) && Input.GetKeyUp(KeyCode.Alpha8))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemHeavyWeapon(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightAlt) && Input.GetKeyUp(KeyCode.Alpha9))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemCrossbow(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightAlt) && Input.GetKeyUp(KeyCode.Alpha0))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemShoes(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightAlt) && Input.GetKeyUp(KeyCode.M))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemGoldIngot(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightAlt) && Input.GetKeyUp(KeyCode.Comma))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemStone(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }
            if (Input.GetKeyUp(KeyCode.RightAlt) && Input.GetKeyUp(KeyCode.Period))
            {
                var component = GameObject.Find("GameManager").GetComponent<GameManager>();
                if (component != null)
                {
                    var getBuilding = component.debugManager.inputManager.selectedObject.GetComponent<Building>();
                    if (getBuilding != null)
                    {
                        ItemBundle itemBundle = new ItemBundle(new ItemLogs(), 100, 100);
                        getBuilding.storage.AddItems(itemBundle);
                    }
                }
            }

            if (obj != null)
            {
                return;
            }
            var Button_Resume = GameObject.Find("Button_Resume");
            if (Button_Resume != null)
            {
                buttonTemplate = GameObject.Instantiate(Button_Resume);
            }
            var getTowncenter = GameObject.FindObjectOfType<UIBuildingInfoWindowStorageModuleCollapsible>();
            if (getTowncenter != null)
            {
                MelonLogger.Msg("Creating UI AddItemButton");
                
                obj = getTowncenter.gameObject;
            }
            if (obj != null && buttonTemplate != null)
            {
            
                buttonTemplate.transform.DetachChildren();
                buttonTemplate.name = "AddItemButton";

                var buttonAction = buttonTemplate.GetComponent<Button>();
                RectTransform toDestroy1 = buttonTemplate.GetComponent<RectTransform>();
                GameObject.Destroy(toDestroy1);

                var toDestroy2 = buttonTemplate.GetComponent<LayoutElement>();
                GameObject.Destroy(toDestroy2);

                buttonTemplate.AddComponent<RectTransform>();

                var buttonTemplatelayoutElement = buttonTemplate.AddComponent<LayoutElement>();
                buttonTemplatelayoutElement.ignoreLayout = true;

                GameObject gameObject2 = new GameObject("AddItemButtonText");
                var component21 = gameObject2.AddComponent<RectTransform>();

                var component22 = gameObject2.AddComponent<Text>();
                component22.text = "Open Menu";
                component22.fontSize = 14;
                component22.fontStyle = FontStyle.Bold;
                component22.color = Color.white;
                component22.AssignDefaultFont();
                component22.alignment = TextAnchor.MiddleCenter;

                gameObject2.transform.SetParent(buttonTemplate.transform, false);

                var component3 = buttonTemplate.AddComponent<HorizontalLayoutGroup>();
                component3.childAlignment = TextAnchor.MiddleCenter;

                var buttonTemplateRectTransofrm = buttonTemplate.GetComponent<RectTransform>();
                buttonTemplateRectTransofrm.sizeDelta = new Vector2(150, 25);

                buttonTemplate.transform.SetParent(obj.transform, false);
                
                buttonTemplate.transform.localPosition = new Vector3(150, 0, 0);

                buttonTemplate.SetActiveRecursively(true);
            }
        }
    }

}

