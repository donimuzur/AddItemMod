using MelonLoader;
using System;
using System.Collections.Generic;
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
        private Building selectedBuilding = null;
        private GameObject obj = null;
        private GameObject buttonTemplate = null;
        private GameObject panelTemplate = null;
        private GameObject CopyButton = null;
        private GameObject buttonAddItemTemplate = null;
        private GameObject buttonCloseItemMenu = null;
        private ItemBundle itemBundle = null;
        private  bool isMenuOpen = false;
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
                CopyButton = GameObject.Instantiate(Button_Resume); 
    }
            var Pause_menu = GameObject.FindObjectOfType<UIPauseWindow>();
            if(Pause_menu != null)
            {
                panelTemplate = GameObject.Instantiate(Pause_menu.transform.FindChild("Pivot").gameObject);
            }
            var getTowncenter = GameObject.FindObjectOfType<UIBuildingInfoWindowStorageModuleCollapsible>();
            if (getTowncenter != null)
            {
                MelonLogger.Msg("Creating UI AddItemButton");
                
                obj = getTowncenter.gameObject;
            }
            if (obj != null && buttonTemplate != null)
            {
                MelonLogger.Msg("Creating UI Open Menu Add Item");
                #region Open Menu Button
                buttonTemplate.transform.DetachChildren();
                buttonTemplate.name = "AddItemButton";

                var buttonAction = buttonTemplate.GetComponent<Button>();
                buttonAction.onClick.AddListener(delegate
                {
                    panelTemplate.SetActiveRecursively(true);
                });
                RectTransform toDestroy1 = buttonTemplate.GetComponent<RectTransform>();
                GameObject.Destroy(toDestroy1);

                var toDestroy2 = buttonTemplate.GetComponent<LayoutElement>();
                GameObject.Destroy(toDestroy2);

                buttonTemplate.AddComponent<RectTransform>();

                var buttonTemplatelayoutElement = buttonTemplate.AddComponent<LayoutElement>();
                buttonTemplatelayoutElement.ignoreLayout = false;

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
                #endregion

                MelonLogger.Msg("Creating UI Add Item Menu ");
                #region AddItemMenu

                panelTemplate.transform.DetachChildren();
                panelTemplate.name = "AddItemMenu";

                var panelComponent1 = panelTemplate.AddComponent<UIDragable>();
                panelComponent1.rectTransformToDrag = panelTemplate.GetComponent<RectTransform>();

                panelTemplate.GetComponent<RectTransform>().sizeDelta = new Vector2(700,500);

                var panelComponent2 = panelTemplate.AddComponent<GridLayoutGroup>();
                panelComponent2.padding = new RectOffset(20, 20, 20, 100);
                panelComponent2.spacing = new Vector2(10, 10);

                GameObject windowCanvas = GameObject.FindObjectOfType<UIWindowManager>().gameObject;

                CreateUIButton(new ItemBread());
                CreateUIButton(new ItemMeat());
                CreateUIButton(new ItemEggs());
                CreateUIButton(new ItemFruit());
                CreateUIButton(new ItemTool());

                CreateUIButton(new ItemPlatemail());
                CreateUIButton(new ItemShield());
                CreateUIButton(new ItemHeavyWeapon());
                CreateUIButton(new ItemCrossbow());
                CreateUIButton(new ItemShoes());
                CreateUIButton(new ItemGoldIngot());
                CreateUIButton(new ItemStone());
                CreateUIButton(new ItemLogs());


                createCloseButton();
                
                panelTemplate.transform.SetParent(windowCanvas.transform, false);
                panelTemplate.SetActive(false);
                panelTemplate.SetActiveRecursively(false);
                #endregion
            }
        }
        void createCloseButton()
        {
            buttonCloseItemMenu = GameObject.Instantiate(CopyButton);
            buttonCloseItemMenu.transform.DetachChildren();
            buttonCloseItemMenu.name = "CloseItemMenuButton";

            var buttonAction = buttonCloseItemMenu.GetComponent<Button>();
            buttonAction.onClick.AddListener(delegate
            {
                panelTemplate.SetActiveRecursively(false);
            });

            RectTransform toDestroy1 = buttonCloseItemMenu.GetComponent<RectTransform>();
            GameObject.Destroy(toDestroy1);

            var toDestroy2 = buttonCloseItemMenu.GetComponent<LayoutElement>();
            GameObject.Destroy(toDestroy2);

            buttonCloseItemMenu.AddComponent<RectTransform>();

            var buttonCloseItemMenulayoutElement = buttonCloseItemMenu.AddComponent<LayoutElement>();
            buttonCloseItemMenulayoutElement.ignoreLayout = true;

            GameObject gameObject2 = new GameObject("buttonCloseItemMenuText");
            var component21 = gameObject2.AddComponent<RectTransform>();

            var component22 = gameObject2.AddComponent<Text>();
            component22.text = "Close Menu";
            component22.fontSize = 14;
            component22.fontStyle = FontStyle.Bold;
            component22.color = Color.white;
            component22.AssignDefaultFont();
            component22.alignment = TextAnchor.MiddleCenter;

            gameObject2.transform.SetParent(buttonCloseItemMenu.transform, false);

            var buttonCloseItemMenuRectTransofrm = buttonCloseItemMenu.GetComponent<RectTransform>();
            buttonCloseItemMenuRectTransofrm.sizeDelta = new Vector2(100, 50);

            buttonCloseItemMenu.transform.SetParent(panelTemplate.transform, false);
            buttonCloseItemMenu.transform.localPosition = new Vector3(0, -200, 0);

            buttonCloseItemMenu.SetActiveRecursively(true);
        }
        void CreateUIButton(Item item)
        {
            buttonAddItemTemplate = GameObject.Instantiate(CopyButton);
            buttonAddItemTemplate.name = "Add" + item.name + "Button";
            buttonAddItemTemplate.transform.DetachChildren();

            var buttonAddItemTemplatebuttonAction = buttonAddItemTemplate.GetComponent<Button>();
            buttonAddItemTemplatebuttonAction.onClick.AddListener(delegate
            {
                addItem(item);
            });

            RectTransform buttonAddItemTemplatebuttonActiontoDestroy1 = buttonAddItemTemplate.GetComponent<RectTransform>();
            GameObject.Destroy(buttonAddItemTemplatebuttonActiontoDestroy1);

            var buttonAddItemTemplatetoDestroy2 = buttonAddItemTemplate.GetComponent<LayoutElement>();
            GameObject.Destroy(buttonAddItemTemplatetoDestroy2);

            buttonAddItemTemplate.AddComponent<RectTransform>();

            var buttonAddItemTemplatelayoutElement = buttonAddItemTemplate.AddComponent<LayoutElement>();
            buttonAddItemTemplatelayoutElement.ignoreLayout = false;
            buttonAddItemTemplatelayoutElement.flexibleHeight = 30;

            GameObject buttonAddItemTemplategameObject2 = new GameObject("buttonAddItemTemplateText"+item.name);
            var buttonAddItemTemplatecomponent21 = buttonAddItemTemplategameObject2.AddComponent<RectTransform>();

            var buttonAddItemTemplatecomponent22 = buttonAddItemTemplategameObject2.AddComponent<Text>();
            buttonAddItemTemplatecomponent22.text = item.name;
            buttonAddItemTemplatecomponent22.fontSize = 14;
            buttonAddItemTemplatecomponent22.fontStyle = FontStyle.Bold;
            buttonAddItemTemplatecomponent22.color = Color.white;
            buttonAddItemTemplatecomponent22.AssignDefaultFont();
            buttonAddItemTemplatecomponent22.alignment = TextAnchor.MiddleCenter;

            buttonAddItemTemplategameObject2.transform.SetParent(buttonAddItemTemplate.transform, false);

            var buttonAddItemTemplateRectTransofrm = buttonAddItemTemplate.GetComponent<RectTransform>();
            buttonAddItemTemplateRectTransofrm.sizeDelta = new Vector2(100, 50);

            buttonAddItemTemplate.transform.SetParent(panelTemplate.transform, false);

            buttonAddItemTemplate.SetActiveRecursively(true);
        }

        void addItem(Item item)
        {
            MelonLogger.Msg("SAdasd");
            component = GameObject.Find("GameManager").GetComponent<GameManager>();
            selectedBuilding = component.inputManager.selectedObject.GetComponent<Building>();

            if (selectedBuilding != null)
            {
                MelonLogger.Msg("bisa");
                itemBundle = new ItemBundle(item, 100, 100);
                selectedBuilding.storage.AddItems(itemBundle);
            }
        }
    }

}

