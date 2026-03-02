using Fluentis.Arm.Mvvm.Models.BusinessObjects;
using Fluentis.Arm.Mvvm.Models.Dictionary;
using Fluentis.Arm.Mvvm.Models.Security;
using Fluentis.FluentisErp.Mvvm.Models.ExtraData;
using Fluentis.FluentisErp.Mvvm.SH.ViewModels;
using Fluentis.Framework.Core;
using Fluentis.Framework.Mvvm;
using Fluentis.Framework.Mvvm.Algorithms;
using Fluentis.Framework.Mvvm.Behaviors;
using Fluentis.Framework.Mvvm.InteractionRequest;
using Fluentis.Framework.Mvvm.Models;
using Fluentis.Framework.Mvvm.OData4;
using Fluentis.Framework.Mvvm.ViewModels;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Linq.Expressions;
using System.Windows.Input;
using System.Xml.Linq;
using ObjectLoaderHelper = Fluentis.Framework.Mvvm.ViewModels.OData4.ObjectLoaderHelper;
using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Regions;
using Fluentis.FluentisErp.Mvvm.SD.SalesDeliveryNotes.ReadWrite.ViewModels;
using Fluentis.FluentisErp.Mvvm.Models.SD.SalesDeliveryNotes;
using DEMO.FluentisErp.Mvvm.SD.SalesDeliveryNotes.ReadWrite.Models;
using Microsoft.Extensions.Logging;
using Fluentis.Arm.Mvvm.Models.SH.Scripting;

/*START EDIT ZONE [USING]*/
/*END EDIT ZONE*/
namespace DEMO.
{
    public partial class CustomSalesDeliveryNoteViewModel : Fluentis.FluentisErp.Mvvm.SD.SalesDeliveryNotes.ReadWrite.ViewModels.SalesDeliveryNoteViewModel
    {
        // to check current platform use this condition Fluentis.Framework.Mvvm.Configuration.Platform 
        //    values can be ClientPlatform.Html,ClientPlatform.Wpf,ClientPlatform.Xamarin 
        #region Storage variables

        #endregion
        #region Dependency properties

        #endregion
        #region Pubblic properties
        public Dictionary<string, string> MappedProperties = new Dictionary<string, string>();
        public Dictionary<string, string> MappedGridProperties = new Dictionary<string, string>();
        public Dictionary<string, string> MappedGridColumnProperties = new Dictionary<string, string>();
        public Dictionary<string, List<Tuple<string, Dictionary<string, object>>>> MappedGridColumnFormattingRules = new Dictionary<string, List<Tuple<string, Dictionary<string, object>>>>(); public Dictionary<string, string> MappedTabProperties = new Dictionary<string, string>();
        #endregion
        #region Custom Storage variables
        /*START EDIT ZONE [Storage variables]*/
        /*END EDIT ZONE*/
        #endregion
        #region Custom Dependency properties
        /*START EDIT ZONE [Dependency properties]*/
        /*END EDIT ZONE*/
        #endregion
        #region Custom properties
        /*START EDIT ZONE [Custom properties]*/
        /*END EDIT ZONE*/
        #endregion
        /*START EDIT ZONE [Class context]*/
        /*END EDIT ZONE*/
        public CustomSalesDeliveryNoteViewModel()
        {
            #region Widget properties initialization

            #endregion
            // START WIZARD CODE [CustomSalesDeliveryNoteViewModel]
            // END WIZARD CODE
            /*START EDIT ZONE [CustomSalesDeliveryNoteViewModel]*/
            /*END EDIT ZONE*/
        }

        /// <summary> For Text of ObjectTarget you must set directly property binded to ViewModel or to CurrentObject
        /// <example>For example:
        /// <code>
        ///	   SetWidgetProperty("SalesInvoiceType", "IsEnabled", false);
        ///	   SetWidgetProperty("YourReference", "Text", "MYTEST");
        ///	   SetWidgetProperty("YourReference", "Width", 300);
        ///	   SetWidgetProperty("PhysicalInventory.Date#From", "DateTime", DateTime.Now.ToString(System.Globalization.CultureInfo.InvariantCulture));
        ///	   SetWidgetProperty("PhysicalInventory.Date#To", "DateTime", DateTime.Now.AddDays(1).ToString(System.Globalization.CultureInfo.InvariantCulture));	
        /// </code>
        /// </example>
        /// </summary>
        /// <param name = "TargetWidget">filterTarget o ObjectTarget property name, for range widget you must add #From or #To</param>
        /// <param name = "Name">Accepted values for Name
        /// Common property widget
        ///  IsVisible,IsReadOnly,IsEnabled,Width,Height
        ///  
        /// Simple property widget
        ///  Background,Foreground,FontFamily,FontSize,FontStyle
        ///
        /// Specific type 
        ///   Text &#38; Numeric : Text
        ///          Boolean : IsChecked</param>
        /// <param name = "Value">property value</param>
        protected void SetWidgetProperty(string TargetWidget, string Name, object Value)
        { }

        /// <summary>
        /// <example>For example:
        /// <code>
        ///	   SetGridProperty("ResultItems", "IsVisible", false);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name = "CollectionTarget">property name used by Grid for ItemSources</param>
        /// <param name = "Name">property name
        ///   Accepted values for Name
        ///    IsVisible,Width,Height,IsReadOnly</param>
        /// <param name = "Value">value to set</param>
        protected void SetGridProperty(string CollectionTarget, string Name, object Value)
        { }

        /// <summary>
        /// <example>For example:
        /// <code>
        /// SetTabProperty("PosItemsTab", "IsVisible", true);
        /// SetTabProperty("PosItemsTab", "Text", "Hello World!");
        /// SetTabProperty("PosItemsTab", "Image", "Fluentis.Portal.Mvvm.Images.Images._16x16.Folder - Closed.png");
        ///	IImagesResolver imagesResolver = Configuration.Resolve&#62;IImagesResolver&gt;();
        /// imagesResolver.GetImages(new List&#62;int&gt;{460}, (images, state2) =>
        /// {
        ///    SetTabProperty("PosItemsTab", "Image", images.FirstOrDefault());
        /// }, null);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name = "TargetTab">Tab Path</param>
        /// <param name = "Name">property name
        ///   Accepted values for Name
        ///    IsVisible,Text,Image</param>
        /// <param name = "Value">value to set</param>
        protected void SetTabProperty(string TargetTab, string Name, object Value)
        { }

        /// <summary>
        /// <example>For example:
        /// <code>
        /// SetColumnGridProperty("ResultItems", "Code","IsVisible", false);
        /// </code>
        /// </example>
        /// </summary>
        /// <param name = "CollectionTarget">property name used by Grid for ItemSources</param>
        /// <param name = "FieldTarget">field name used to bind a column</param>
        /// <param name = "Name">property name
        ///   Accepted values for Name
        ///    IsVisible,Width,IsReadOnly</param>
        /// <param name = "Value">value to set</param>
        protected void SetColumnGridProperty(string CollectionTarget, string FieldTarget, string Name, object Value)
        { }

        /// <summary>  Invoked by framework when you can invoke the function SetColumnGridProperty
        /// <example>For example:
        /// <code>
        ///  if (ItemsSource == "ResultItems")
        ///  {
        ///     SetColumnGridProperty("ResultItems", "Code", "IsVisible", false);
        ///  }
        /// </code>
        /// </example>
        /// </summary>
        public void MappedGridColumnPropertiesApplied(string ItemsSource)
        {
            // START WIZARD CODE [MappedGridColumnPropertiesApplied]
            // END WIZARD CODE
            /*START EDIT ZONE [MappedGridColumnPropertiesApplied]*/
            /*END EDIT ZONE*/
        }

        /// <summary>  
        /// <example>For example:
        /// <code>
        ///  SetColumnGridFormattingRules("ResultItems", "PhysicalInventory.Number", "[PhysicalInventory.Number] == 3", new Dictionary&#62;string, object&gt;()
        ///                                {{"TextColor", "Fuchsia"}, 
        ///                                 {"FontSize", 30}, 
        ///                                 {"BackgroundColor", "Orange"}, 
        ///                                 {"FontFamily", "Quicksand-Bold"},
        ///                                 {"TextDecorations", "Underline"}});
        ///  SetColumnGridFormattingRules("ResultItems", "PhysicalInventory.Number", "[PhysicalInventory.Number] == 5", new Dictionary&#62;string, object&gt;()
        ///                                {{"TextColor", "Red"}});
        ///  SetColumnGridFormattingRules("ResultItems", "PhysicalInventory.Date", "[PhysicalInventory.Number] == 2", new Dictionary&#62;string, object&gt;()
        ///                                {{"TextColor", "Red"}});
        /// </code>
        /// </example>
        /// </summary>
        /// <param name = "CollectionTarget">property name used by Grid for ItemSources</param>
        /// <param name = "FieldTarget">field name used to bind a column</param>
        /// <param name = "ValidationExpression">expression to validate rule to generate expression you can use the Grid Wizard for formatting rules</param>
        /// <param name = "Rules">list of rules used to set style
        ///          property can be of if this 
        ///		     TextColor       : named color
        ///		     TextDecorations : underline or Strikethrough
        ///		     BackgroundColor : named color
        ///		     FontSize        : font size
        ///		     FontFamily      : must be installed on target system</param>
        protected void SetColumnGridFormattingRules(string CollectionTarget, string FieldTarget, string ValidationExpression, Dictionary<string, object> Rules)
        {
            string Key = $"TargetModelProperty:{CollectionTarget}#{FieldTarget}";
            if (MappedGridColumnFormattingRules.ContainsKey(Key))
                MappedGridColumnFormattingRules[Key].Add(Tuple.Create(ValidationExpression, Rules));
            else
                MappedGridColumnFormattingRules.Add(Key, new List<Tuple<string, Dictionary<string, object>>>() { Tuple.Create(ValidationExpression, Rules) });
        }

        protected override void OnObjectPropertyChanged(object currentObject, string propertyName)
        {
            Action baseMethod = () =>
            {
                base.OnObjectPropertyChanged(currentObject, propertyName);
            };
            // START WIZARD CODE [OnObjectPropertyChanged]
            // END WIZARD CODE
            /*START EDIT ZONE [OnObjectPropertyChanged]*/
            if (currentObject is Fluentis.FluentisErp.Mvvm.Models.SD.SalesDeliveryNotes.ReadWrite.FSWSalesDeliveryNoteExtraData && ((Fluentis.FluentisErp.Mvvm.Models.SD.SalesDeliveryNotes.ReadWrite.FSWSalesDeliveryNoteExtraData)currentObject).ExtraDataObject != null)
            {
                string extraDataObjectCode = ((Fluentis.FluentisErp.Mvvm.Models.SD.SalesDeliveryNotes.ReadWrite.FSWSalesDeliveryNoteExtraData)currentObject).ExtraDataObject.Code.ToString();
                if (extraDataObjectCode == "Targa")
                {
                    if (((Fluentis.Framework.Mvvm.Models.OData4.BaseODataModel)currentObject).AdditionalData != null)
                    {
                        XDocument extraDataInfo = XDocument.Parse(((Fluentis.Framework.Mvvm.Models.OData4.BaseODataModel)currentObject).AdditionalData);
                        // if (extraDataInfo.Document.Root.Attribute("extraDataValueValue") != null)
                        //  {
                        int? extraDataId = (currentObject as Fluentis.FluentisErp.Mvvm.Models.SD.SalesDeliveryNotes.ReadWrite.FSWSalesDeliveryNoteExtraData).ExtraDataId;
                        var Automezzo = this.ODataService.FSMotorvehicles.Expand(x => x.Account).Where(x => x.Id == extraDataId).FirstOrDefault();
                        //  if (extraDataValue == "ER456DF" && this.CurrentObject != null && this.CurrentObject.Account == null)
                        // {
                        if (Automezzo != null && Automezzo.Account != null)
                            this.CurrentObject.Account = Automezzo.Account;
                        // }
                        // }
                    }
                }
            }

            /*END EDIT ZONE*/
            baseMethod();
        }

        public override void OnSave(Object args)
        {
            Action baseMethod = () =>
            {
                base.OnSave(args);
            };
            // START WIZARD CODE [OnSave]
            // END WIZARD CODE
            /*START EDIT ZONE [OnSave]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        public override void OnPostSave(Boolean savedSuccessfully)
        {
            Action baseMethod = () =>
            {
                base.OnPostSave(savedSuccessfully);
            };
            // START WIZARD CODE [OnPostSave]
            // END WIZARD CODE
            /*START EDIT ZONE [OnPostSave]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override Boolean CanSave(Object args)
        {
            Boolean canSave = base.CanSave(args);
            // START WIZARD CODE [CanSave]
            // END WIZARD CODE
            /*START EDIT ZONE [CanSave]*/
            /*END EDIT ZONE*/
            return canSave;
        }

        protected override void OnCloseWithoutSave(Action<Boolean, Object> callback, Object state)
        {
            Action baseMethod = () =>
            {
                base.OnCloseWithoutSave(callback, state);
            };
            // START WIZARD CODE [OnCloseWithoutSave]
            // END WIZARD CODE
            /*START EDIT ZONE [OnCloseWithoutSave]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnCloseWithSave(Action<Boolean, Object> callback, Object state)
        {
            Action baseMethod = () =>
            {
                base.OnCloseWithSave(callback, state);
            };
            // START WIZARD CODE [OnCloseWithSave]
            // END WIZARD CODE
            /*START EDIT ZONE [OnCloseWithSave]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void RaiseSaveCommandStatusChanged()
        {
            Action baseMethod = () =>
            {
                base.RaiseSaveCommandStatusChanged();
            };
            // START WIZARD CODE [RaiseSaveCommandStatusChanged]
            // END WIZARD CODE
            /*START EDIT ZONE [RaiseSaveCommandStatusChanged]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override Boolean GetPrintCommandStatus()
        {
            Boolean printCommandStatus = base.GetPrintCommandStatus();
            // START WIZARD CODE [GetPrintCommandStatus]
            // END WIZARD CODE
            /*START EDIT ZONE [GetPrintCommandStatus]*/
            /*END EDIT ZONE*/
            return printCommandStatus;
        }

        protected override void OnObjectInitialized()
        {
            Action baseMethod = () =>
            {
                base.OnObjectInitialized();
            };
            // START WIZARD CODE [OnObjectInitialized]
            // END WIZARD CODE
            /*START EDIT ZONE [OnObjectInitialized]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnBeforeAlgorithmCall(Fluentis.Framework.Mvvm.Algorithms.AlgorithmCallInfo algorithmCallInfo)
        {
            Action baseMethod = () =>
            {
                base.OnBeforeAlgorithmCall(algorithmCallInfo);
            };
            // START WIZARD CODE [OnBeforeAlgorithmCall]
            // END WIZARD CODE
            /*START EDIT ZONE [OnBeforeAlgorithmCall]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnAfterAlgorithmCall(Fluentis.Framework.Mvvm.Algorithms.AlgorithmCallInfo algorithmCallInfo)
        {
            Action baseMethod = () =>
            {
                base.OnAfterAlgorithmCall(algorithmCallInfo);
            };
            // START WIZARD CODE [OnAfterAlgorithmCall]
            // END WIZARD CODE
            /*START EDIT ZONE [OnAfterAlgorithmCall]*/
            /*END EDIT ZONE*/
            baseMethod();
        }
    }
}