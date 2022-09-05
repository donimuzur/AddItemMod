using AddItemMod.UI;
using MelonLoader;
using System;
using System.Collections.Generic;
using System.Linq;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace AddItemMod
{

    public static class BuildInfo
    {
        public const string Name = "AddItemMod";
        public const string Description = "Mod to Add Item";
        public const string Author = "donimuzur"; // Author of the Mod.  (MUST BE SET)
        public const string Company = null; // Company that made the Mod.  (Set as null if none)
        public const string Version = "2.3.0"; // Version of the Mod.  (MUST BE SET)
        public const string DownloadLink = null; // Download Link for the Mod.  (Set as null if none)    
    }

    public class AddItemMod : MelonMod
    {

        bool finished = false;
        public GameManager gameManager = null;
        public InputManager inputManager = null;
        public GameObject selectedBuilding = null;
        public static int sliderValue = 100;
        public override void OnApplicationStart()
        {
            MelonLogger.Msg("AddItemMod Started");
        }
        public override void OnSceneWasLoaded(int buildIndex, string sceneName)
        {
            finished = false;
            sliderValue = 100;
        }
        public override void OnUpdate()
        {
            if (SceneManager.GetActiveScene().name != "Frontier") return;

            var gameManagerObj = GameObject.Find("GameManager");
            if (gameManagerObj != null)
            {
                inputManager = gameManagerObj.GetComponent<InputManager>();
                selectedBuilding = inputManager.selectedObject;
                if (selectedBuilding != null && !finished)
                {
                    GameObject.Destroy(GameObject.Find("AddItemButton"));
                    var getUIpausWindowList = Resources.FindObjectsOfTypeAll(Il2CppType.From(typeof(UIPauseWindow)));

                    if (getUIpausWindowList != null && getUIpausWindowList.Count > 0)
                    {
                        var getUIpausWindow = getUIpausWindowList[0].TryCast<UIPauseWindow>();
                        var getResumeButton = getUIpausWindow.gameObject.transform.FindChild("Pivot").FindChild("Main Panel").FindChild("Button_Resume");
                        if (getResumeButton != null)
                        {
                            var getUIBuildingInfoWindowStorageModuleCollapsible = GameObject.FindObjectOfType<UIBuildingInfoWindowStorageModuleCollapsible>();
                            if (getUIBuildingInfoWindowStorageModuleCollapsible != null)
                            {
                                GameObject windowCanvas = GameObject.FindObjectOfType<UIWindowManager>().gameObject;
                                var uiPanel = createUIPanel(windowCanvas, 600, 1000, null);
                                uiPanel.name = "AddItemPanel";

                                var panelComponent1 = uiPanel.AddComponent<UIDragable>();
                                panelComponent1.rectTransformToDrag = uiPanel.GetComponent<RectTransform>();

                                Sprite btnSprite = getResumeButton.GetComponent<Image>().sprite;
                                GameObject uiButton = UIControls.CreateButton(new UIControls.Resources { standard = btnSprite });
                                uiButton.name = "AddItemButton";

                                GameObject gameObject1 = new GameObject("AddItemButtonText");
                                var component11 = gameObject1.AddComponent<RectTransform>();

                                var component12 = gameObject1.AddComponent<Text>();
                                component12.text = "Open Menu";
                                component12.fontSize = 14;
                                component12.fontStyle = FontStyle.Bold;
                                component12.color = Color.white;
                                component12.AssignDefaultFont();
                                component12.alignment = TextAnchor.MiddleCenter;

                                gameObject1.transform.SetParent(uiButton.transform, false);

                                var buttonActionuiButton = uiButton.GetComponent<Button>();
                                buttonActionuiButton.onClick.AddListener(delegate
                                {
                                    uiPanel.SetActive(true);
                                });

                                var component3 = uiButton.AddComponent<HorizontalLayoutGroup>();
                                component3.childAlignment = TextAnchor.MiddleCenter;

                                var uiButtonlayoutElement = uiButton.AddComponent<LayoutElement>();
                                uiButtonlayoutElement.ignoreLayout = false;

                                uiButton.transform.SetParent(getUIBuildingInfoWindowStorageModuleCollapsible.gameObject.transform, false);
                                var uiButtonRectTransofrm = uiButton.GetComponent<RectTransform>();
                                uiButtonRectTransofrm.sizeDelta = new Vector2(80, 35);
                                uiButtonRectTransofrm.localPosition = new Vector3(400, -71, 0);


                                var panelComponent2 = uiPanel.AddComponent<GridLayoutGroup>();
                                panelComponent2.padding = new RectOffset(20, 20, 20, 100);
                                panelComponent2.spacing = new Vector2(5, 5);
                                panelComponent2.cellSize = new Vector2(80, 80);

                                
                                uiPanel.transform.SetParent(windowCanvas.transform, false);
                                uiPanel.SetActive(false);

                                #region addItemButton
                                //Usable Items
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemHideCoat(), "Add Hide Coats");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemCarcass(), "Add Carcasses");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemTool(), "Add Tool");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemWeapon(), "Add Weapon");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemSimpleWeapon(), "Add Crude Weapon");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemHeavyWeapon(), "Add Heavy Weapon");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemShield(), "Add Shield");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemHauberk(), "Add Hauberk");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemPlatemail(), "Add Plate Mail");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemBow(), "Add Bow");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemCrossbow(), "Add Crossbow");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemArrow(), "Add Arrows");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemShoes(), "Add Shoes");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemLinenClothes(), "Add Linen Clothes");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemWheatBeer(), "Add Beer");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemBasket(), "Add Basket");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemFurniture(), "Add Furniture");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemSoap(), "Add Soap");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemCandle(), "Add Candle");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemSpice(), "Add Spice");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemPottery(), "Add Pottery");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemGlass(), "Add Glassware");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemBarrel(), "Add Barrel");


                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemBerries(), "Add Berries");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemMeat(), "Add Meat");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemSmokedMeat(), "Add Smoked Meat");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemBeans(), "Add Beans");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemGreens(), "Add Greens");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemRootVegetable(), "Add Vegetables");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemBread(), "Add Bread");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemFish(), "Add Fish");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemSmokedFish(), "Add Smoked Fish");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemMushroom(), "Add Mushrooms");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemNuts(), "Add Nuts");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemFruit(), "Add Fruits");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemPreservedVeg(), "Add Preserved Vegetables");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemPreserves(), "Add Preserves");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemEggs(), "Add Eggs");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemMilk(), "Add Milk");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemCheese(), "Add Cheese");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemMedicine(), "Add Medicine");

                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemFirewood(), "Add Firewood");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemPlanks(), "Add Planks");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemFlour(), "Add Flour");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemHide(), "Add Pelts");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemTallow(), "Add Tallow");

                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemLogs(), "Add Wood");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemStone(), "Add Stone");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemRoots(), "Add Medicinal Roots");

                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemGrain(), "Add Grain");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemWater(), "Add Water");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemFlax(), "Add Flax");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemHerbs(), "Add Herbs");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemWillow(), "Add Willow");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemHoney(), "Add Honey");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemWax(), "Add Wax");

                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemIron(), "Add Iron");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemGoldIngot(), "Add Gold");

                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemHeavyTool(), "Add Heavy Tool");
                                CreateUIButton(uiPanel, getResumeButton.GetComponent<Image>().sprite, new ItemBrick(), "Add Brick");


                                var uiCloseButton = createCloseButton(uiPanel, getResumeButton.GetComponent<Image>().sprite);
                                var uiCloseButtonRectTransofrm = uiCloseButton.GetComponent<RectTransform>();
                                uiCloseButtonRectTransofrm.anchoredPosition = Vector3.zero;
                                uiCloseButtonRectTransofrm.localPosition = new Vector3(0, -250, 0);

                                var uiSlider = createSlider(uiPanel);
                                var uiSliderRectTransofrm = uiSlider.GetComponent<RectTransform>();
                                uiSliderRectTransofrm.anchoredPosition = Vector3.zero;
                                uiSliderRectTransofrm.localPosition = new Vector3(120, -190, 0);
                                #endregion

                                finished = true;

                            }

                        }
                    }
                }
                else if (selectedBuilding == null)
                {
                    finished = false;
                    sliderValue = 100;
                }
            }
        }
        public GameObject createUIPanel(GameObject canvas, float height, float width, Sprite BgSprite = null)
        {
            UIControls.Resources uiResources = new UIControls.Resources();

            uiResources.background = BgSprite;

            GameObject uiPanel = UIControls.CreatePanel(uiResources);
            uiPanel.transform.SetParent(canvas.transform, UIControls.createSpriteFrmTexture(UIControls.createDefaultTexture("#000000FF")));

            RectTransform rectTransform = uiPanel.GetComponent<RectTransform>();

            rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Vertical, height);
            rectTransform.SetSizeWithCurrentAnchors(RectTransform.Axis.Horizontal, width);
            // You can also use rectTransform.sizeDelta = new Vector2(width, height);

            return uiPanel;
        }
        GameObject createSlider(GameObject uiPanel)
        {
            UIControls.Resources uiResources = new UIControls.Resources();

            uiResources.background = UIControls.createSpriteFrmTexture(UIControls.createDefaultTexture("#9E9E9EFF"));
            uiResources.standard = UIControls.createSpriteFrmTexture(UIControls.createDefaultTexture("#7AB900FF"));
            uiResources.knob = UIControls.createSpriteFrmTexture(UIControls.createDefaultTexture("#191919FF"));

            GameObject uiSlider = UIControls.CreateSlider(uiResources);
            uiSlider.name = "AddItemSlider";

            var slider = uiSlider.GetComponent<Slider>();
            slider.maxValue = 10000;
            slider.minValue = 100;
            slider.value = 100;
            slider.onValueChanged.AddListener(delegate { 
                sliderValue = (int)Math.Round((Decimal)slider.value);
                var getUISliderText = GameObject.Find("AddItemSliderText");
                if(getUISliderText != null)
                {
                    var getText = getUISliderText.GetComponent<Text>();
                    getText.text = sliderValue.ToString();
                }
            });

            var uiSliderlayoutElement = uiSlider.AddComponent<LayoutElement>();
            uiSliderlayoutElement.ignoreLayout = true;
            uiSliderlayoutElement.preferredWidth = 300;
            uiSliderlayoutElement.preferredHeight = 40;
            uiSliderlayoutElement.minHeight = 40;
            uiSliderlayoutElement.minWidth = 300;
            
            var uiSliderRectTransform = uiSlider.GetComponent<RectTransform>();
            uiSliderRectTransform.sizeDelta = new Vector2(300, 40);

            uiSlider.transform.SetParent(uiPanel.transform, false);

            GameObject uiSliderText = new GameObject("AddItemSliderText");
            var component11 = uiSliderText.AddComponent<RectTransform>();

            var uiSliderTextlayoutElement = uiSliderText.AddComponent<LayoutElement>();
            uiSliderTextlayoutElement.ignoreLayout = true;
            uiSliderTextlayoutElement.preferredWidth = 100;
            uiSliderTextlayoutElement.preferredHeight = 40;
            uiSliderTextlayoutElement.minHeight = 40;
            uiSliderTextlayoutElement.minWidth = 100;

            var component12 = uiSliderText.AddComponent<Text>();
            component12.text = "100";
            component12.fontSize = 14;
            component12.fontStyle = FontStyle.Bold;
            component12.color = Color.black;
            component12.AssignDefaultFont();
            component12.alignment = TextAnchor.MiddleCenter;
            uiSliderText.transform.SetParent(uiPanel.transform, false);

            var uiSliderTextRectTransofrm = uiSliderText.GetComponent<RectTransform>();
            uiSliderTextRectTransofrm.anchoredPosition = Vector3.zero;
            uiSliderTextRectTransofrm.localPosition = new Vector3(300, -190, 0);

            return uiSlider;
        }
        GameObject createCloseButton(GameObject parent, Sprite sprite)
        {
            GameObject uiCloseButton = UIControls.CreateButton(new UIControls.Resources { standard = sprite });
            uiCloseButton.name = "AddItemCloseButton";
           
            GameObject gameObject1 = new GameObject("AddItemCloseButtonText");
            var component11 = gameObject1.AddComponent<RectTransform>();

            var component12 = gameObject1.AddComponent<Text>();
            component12.text = "Close Menu";
            component12.fontSize = 14;
            component12.fontStyle = FontStyle.Bold;
            component12.color = Color.white;
            component12.AssignDefaultFont();
            component12.alignment = TextAnchor.MiddleCenter;

            var buttonAddItemTemplatelayoutElement = uiCloseButton.AddComponent<LayoutElement>();
            buttonAddItemTemplatelayoutElement.ignoreLayout = true;
            buttonAddItemTemplatelayoutElement.preferredWidth = 130;
            buttonAddItemTemplatelayoutElement.preferredHeight = 30;
            buttonAddItemTemplatelayoutElement.minHeight = 30;
            buttonAddItemTemplatelayoutElement.minWidth = 130;

            var buttonActionuiButton = uiCloseButton.GetComponent<Button>();
            buttonActionuiButton.onClick.AddListener(delegate
            {
                parent.SetActive(false);
            });

            gameObject1.transform.SetParent(uiCloseButton.transform, false);
            
            uiCloseButton.transform.SetParent(parent.transform, false);

            return uiCloseButton;
        }
        void CreateUIButton(GameObject parent, Sprite background, Item item, string text)
        {
            GameObject uiBtnAddItem = UIControls.CreateButton(new UIControls.Resources { standard = background });
            uiBtnAddItem.name = "Add" + item.name + "Button";

            var buttonAddItemTemplatebuttonAction = uiBtnAddItem.GetComponent<Button>();
            buttonAddItemTemplatebuttonAction.onClick.AddListener(delegate
            {
                var gameManagerAddItemObject = GameObject.Find("GameManager");
                if (gameManagerAddItemObject != null)
                {
                    var inputManagerAddItem = gameManagerAddItemObject.GetComponent<InputManager>();
                    if (inputManagerAddItem != null)
                    {
                        var selectedObj = inputManagerAddItem.selectedObject;
                        if(selectedObj != null)
                        {
                            var selectedBuilding = selectedObj.GetComponent<Building>();
                            if (selectedBuilding != null)
                            {
                                var itemBundle = new ItemBundle(item, Convert.ToUInt32(sliderValue), 100);
                                selectedBuilding.storage.AddItems(itemBundle);
                            }
                        }                        
                    }
                }
            });

            var buttonAddItemTemplatelayoutElement = uiBtnAddItem.AddComponent<LayoutElement>();
            buttonAddItemTemplatelayoutElement.ignoreLayout = false;
            buttonAddItemTemplatelayoutElement.preferredWidth = 80;
            buttonAddItemTemplatelayoutElement.preferredHeight = 80;
            buttonAddItemTemplatelayoutElement.minHeight = 80;
            buttonAddItemTemplatelayoutElement.minWidth= 80;

            GameObject buttonAddItemTemplategameObject1 = new GameObject("buttonAddItemTemplateIcon"+item.name);
            var buttonAddItemTemplategameObject11 = buttonAddItemTemplategameObject1.AddComponent<RectTransform>();
            buttonAddItemTemplategameObject11.sizeDelta = new Vector2(80, 80);

            var buttonAddItemTemplategameObject12 = buttonAddItemTemplategameObject1.AddComponent<Image>();
            buttonAddItemTemplategameObject12.sprite = item.icon;
            buttonAddItemTemplategameObject12.preserveAspect = true;
            buttonAddItemTemplategameObject12.transform.SetParent(uiBtnAddItem.transform, false);

            GameObject buttonAddItemTemplategameObject2 = new GameObject("buttonAddItemTemplateText"+item.name);
            var buttonAddItemTemplatecomponent21 = buttonAddItemTemplategameObject2.AddComponent<RectTransform>();

            var buttonAddItemTemplatecomponent22 = buttonAddItemTemplategameObject2.AddComponent<Text>();
            buttonAddItemTemplatecomponent22.text = text;
            buttonAddItemTemplatecomponent22.fontSize = 12;
            buttonAddItemTemplatecomponent22.fontStyle = FontStyle.Bold;
            buttonAddItemTemplatecomponent22.color = Color.white;
            buttonAddItemTemplatecomponent22.AssignDefaultFont();
            buttonAddItemTemplatecomponent22.alignment = TextAnchor.MiddleCenter;

            buttonAddItemTemplatecomponent22.transform.SetParent(uiBtnAddItem.transform, false);

            uiBtnAddItem.transform.SetParent(parent.transform, false);
        }
    }
}

