using Fluentis.Framework.Core;
using Fluentis.Framework.Mvvm;
using Fluentis.Framework.Mvvm.Behaviors;
using Fluentis.Framework.Mvvm.OData4;
using Fluentis.Framework.Mvvm.ViewModels;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using Prism.Commands;
using Prism.Interactivity.InteractionRequest;
using Prism.Regions;
using Fluentis.Framework.Mvvm.InteractionRequest;
using System.Collections.Specialized;
using Fluentis.FluentisErp.Mvvm.SD.SalesInvoices.ViewModels;
using Fluentis.FluentisErp.Mvvm.Models.SD.SalesInvoices;
using Microsoft.Extensions.Logging;
using Fluentis.Arm.Mvvm.Models.SH.Scripting;


/*START EDIT ZONE [USING]*/

/*END EDIT ZONE*/
namespace DEMO.FluentisErp.Mvvm.SD.SalesInvoices.ViewModels
{
    public partial class CustomSalesInvoiceFilterViewModel : Fluentis.FluentisErp.Mvvm.SD.SalesInvoices.ViewModels.SalesInvoiceFilterViewModel
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
        public CustomSalesInvoiceFilterViewModel()
        {

            #region Widget properties initialization

            #endregion
            // START WIZARD CODE [CustomSalesInvoiceFilterViewModel]

            // END WIZARD CODE
            /*START EDIT ZONE [CustomSalesInvoiceFilterViewModel]*/
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
                MappedGridColumnFormattingRules.Add(Key, new List<Tuple<string, Dictionary<string, object>>>()
                {Tuple.Create(ValidationExpression, Rules)});
        }

        public override void AddSearchMode()
        {
            Action baseMethod = () => { base.AddSearchMode(); };

            // START WIZARD CODE [AddSearchMode]

            // END WIZARD CODE
            /*START EDIT ZONE [AddSearchMode]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        public override void GetFormQuery()
        {
            Action baseMethod = () => { base.GetFormQuery(); };

            // START WIZARD CODE [GetFormQuery]

            // END WIZARD CODE
            /*START EDIT ZONE [GetFormQuery]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        public override void OnDeleteObjects(int[] objectIds)
        {
            Action baseMethod = () => { base.OnDeleteObjects(objectIds); };

            // START WIZARD CODE [OnDeleteObjects]

            // END WIZARD CODE
            /*START EDIT ZONE [OnDeleteObjects]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        public override void OnPropertyChanged(string propertyName)
        {
            Action baseMethod = () => { base.OnPropertyChanged(propertyName); };

            // START WIZARD CODE [OnPropertyChanged]

            // END WIZARD CODE
            /*START EDIT ZONE [OnPropertyChanged]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void AutoFilterTab(object state)
        {
            Action baseMethod = () => { base.AutoFilterTab(state); };

            // START WIZARD CODE [AutoFilterTab]

            // END WIZARD CODE
            /*START EDIT ZONE [AutoFilterTab]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override Expression CustomizeFilterExpression(Expression filterExpression)
        {
            Expression basefilterExpression = base.CustomizeFilterExpression(filterExpression);
            // START WIZARD CODE [CustomizeFilterExpression]

            // END WIZARD CODE
            /*START EDIT ZONE [CustomizeFilterExpression]*/
            /*END EDIT ZONE*/
            return basefilterExpression;
        }

        protected override Dictionary<string, string> GetNewFormOtherParameters()
        {
            Dictionary<string, string> baseNewFormOtherParameters = base.GetNewFormOtherParameters();
            // START WIZARD CODE [GetNewFormOtherParameters]

            // END WIZARD CODE
            /*START EDIT ZONE [GetNewFormOtherParameters]*/
            /*END EDIT ZONE*/
            return baseNewFormOtherParameters;
        }

        protected override Dictionary<string, string> GetOpenFormOtherParameters(int objectId, bool readWrite)
        {
            Dictionary<string, string> baseFormOtherParameters = base.GetOpenFormOtherParameters(objectId, readWrite);
            // START WIZARD CODE [GetOpenFormOtherParameters]

            // END WIZARD CODE
            /*START EDIT ZONE [GetOpenFormOtherParameters]*/
            /*END EDIT ZONE*/
            return baseFormOtherParameters;
        }

        protected override bool GetPrintCommandStatus()
        {
            bool basePrintCommandStatus = base.GetPrintCommandStatus();
            // START WIZARD CODE [GetPrintCommandStatus]

            // END WIZARD CODE
            /*START EDIT ZONE [GetPrintCommandStatus]*/
            /*END EDIT ZONE*/
            return basePrintCommandStatus;
        }

        protected override void InitializeCommands()
        {
            Action baseMethod = () => { base.InitializeCommands(); };

            // START WIZARD CODE [InitializeCommands]

            // END WIZARD CODE
            /*START EDIT ZONE [InitializeCommands]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void InitializeInteractionRequests()
        {
            Action baseMethod = () => { base.InitializeInteractionRequests(); };

            // START WIZARD CODE [InitializeInteractionRequests]

            // END WIZARD CODE
            /*START EDIT ZONE [InitializeInteractionRequests]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override bool IsDeleteCommandEnabled()
        {
            bool baseIsDeleteCommandEnabled = base.IsDeleteCommandEnabled();
            // START WIZARD CODE [IsDeleteCommandEnabled]

            // END WIZARD CODE
            /*START EDIT ZONE [IsDeleteCommandEnabled]*/
            baseIsDeleteCommandEnabled = false;
            /*END EDIT ZONE*/
            return baseIsDeleteCommandEnabled;
        }

        protected override bool IsOpenCommandEnabled()
        {
            bool baseIsOpenCommandEnabled = base.IsOpenCommandEnabled();
            // START WIZARD CODE [IsOpenCommandEnabled]

            // END WIZARD CODE
            /*START EDIT ZONE [IsOpenCommandEnabled]*/
            /*END EDIT ZONE*/
            return baseIsOpenCommandEnabled;
        }

        protected override bool IsOpenDiagramCommandEnabled()
        {
            bool baseIsOpenDiagramCommandEnabled = base.IsOpenDiagramCommandEnabled();
            // START WIZARD CODE [IsOpenDiagramCommandEnabled]

            // END WIZARD CODE
            /*START EDIT ZONE [IsOpenDiagramCommandEnabled]*/
            /*END EDIT ZONE*/
            return baseIsOpenDiagramCommandEnabled;
        }

        protected override bool IsOpenGanttVisualizerEnabled()
        {
            bool baseIsOpenGanttVisualizerEnabled = base.IsOpenGanttVisualizerEnabled();
            // START WIZARD CODE [IsOpenGanttVisualizerEnabled]

            // END WIZARD CODE
            /*START EDIT ZONE [IsOpenGanttVisualizerEnabled]*/
            /*END EDIT ZONE*/
            return baseIsOpenGanttVisualizerEnabled;
        }

        protected override bool IsOpenSelectionInGanttEnabled()
        {
            bool baseIsOpenSelectionInGanttEnabled = base.IsOpenSelectionInGanttEnabled();
            // START WIZARD CODE [IsOpenSelectionInGanttEnabled]

            // END WIZARD CODE
            /*START EDIT ZONE [IsOpenSelectionInGanttEnabled]*/
            /*END EDIT ZONE*/
            return baseIsOpenSelectionInGanttEnabled;
        }

        protected override bool IsSearchCommandEnabled()
        {
            bool baseIsSearchCommandEnabled = base.IsSearchCommandEnabled();
            // START WIZARD CODE [IsSearchCommandEnabled]

            // END WIZARD CODE
            /*START EDIT ZONE [IsSearchCommandEnabled]*/
            /*END EDIT ZONE*/
            return baseIsSearchCommandEnabled;
        }

        protected override bool IsViewCommandEnabled()
        {
            bool baseIsViewCommandEnabled = base.IsViewCommandEnabled();
            // START WIZARD CODE [IsViewCommandEnabled]

            // END WIZARD CODE
            /*START EDIT ZONE [IsViewCommandEnabled]*/
            /*END EDIT ZONE*/
            return baseIsViewCommandEnabled;
        }

        protected override void LoadDiagrams()
        {
            Action baseMethod = () => { base.LoadDiagrams(); };

            // START WIZARD CODE [LoadDiagrams]

            // END WIZARD CODE
            /*START EDIT ZONE [LoadDiagrams]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void LoadGanttTemplates()
        {
            Action baseMethod = () => { base.LoadGanttTemplates(); };

            // START WIZARD CODE [LoadGanttTemplates]

            // END WIZARD CODE
            /*START EDIT ZONE [LoadGanttTemplates]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void LoadReports()
        {
            Action baseMethod = () => { base.LoadReports(); };

            // START WIZARD CODE [LoadReports]

            // END WIZARD CODE
            /*START EDIT ZONE [LoadReports]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnAllowInsertChanged(bool previousValue)
        {
            Action baseMethod = () => { base.OnAllowInsertChanged(previousValue); };

            // START WIZARD CODE [OnAllowInsertChanged]

            // END WIZARD CODE
            /*START EDIT ZONE [OnAllowInsertChanged]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnAssignToTask(object args)
        {
            Action baseMethod = () => { base.OnAssignToTask(args); };

            // START WIZARD CODE [OnAssignToTask]

            // END WIZARD CODE
            /*START EDIT ZONE [OnAssignToTask]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnCreateNewTask(object args)
        {
            Action baseMethod = () => { base.OnCreateNewTask(args); };

            // START WIZARD CODE [OnCreateNewTask]

            // END WIZARD CODE
            /*START EDIT ZONE [OnCreateNewTask]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnFilterWidgetLoaded(FilterWidgetDescriptor filterWidgetDescriptor)
        {
            Action baseMethod = () => { base.OnFilterWidgetLoaded(filterWidgetDescriptor); };

            // START WIZARD CODE [OnFilterWidgetLoaded]

            // END WIZARD CODE
            /*START EDIT ZONE [OnFilterWidgetLoaded]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnFilterWidgetsCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Action baseMethod = () => { base.OnFilterWidgetsCollectionChanged(sender, e); };

            // START WIZARD CODE [OnFilterWidgetsCollectionChanged]

            // END WIZARD CODE
            /*START EDIT ZONE [OnFilterWidgetsCollectionChanged]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnNew(object arg)
        {
            Action baseMethod = () => { base.OnNew(arg); };

            // START WIZARD CODE [OnNew]
            UtilityMvvm.DispatchIfNotOnUIThread(() =>
            {
                Configuration.ConfirmationNotification.Raise(new Confirmation { Content = "Vuoi creare una nuova fattura?" }, c => { { if (c.Confirmed) { baseMethod(); } } { } });
            });
            return;
            // END WIZARD CODE
            /*START EDIT ZONE [OnNew]*/

            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnOpen(object arg)
        {
            Action baseMethod = () => { base.OnOpen(arg); };

            // START WIZARD CODE [OnOpen]

            // END WIZARD CODE
            /*START EDIT ZONE [OnOpen]*/


            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnOpenDiagram(object args)
        {
            Action baseMethod = () => { base.OnOpenDiagram(args); };

            // START WIZARD CODE [OnOpenDiagram]

            // END WIZARD CODE
            /*START EDIT ZONE [OnOpenDiagram]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnOpenGanttVisualizer(object args)
        {
            Action baseMethod = () => { base.OnOpenGanttVisualizer(args); };

            // START WIZARD CODE [OnOpenGanttVisualizer]

            // END WIZARD CODE
            /*START EDIT ZONE [OnOpenGanttVisualizer]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnOpenObjects(int[] objectIds)
        {
            Action baseMethod = () => { base.OnOpenObjects(objectIds); };

            // START WIZARD CODE [OnOpenObjects]

            // END WIZARD CODE
            /*START EDIT ZONE [OnOpenObjects]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnOpenSelectionInGantt(object obj)
        {
            Action baseMethod = () => { base.OnOpenSelectionInGantt(obj); };

            // START WIZARD CODE [OnOpenSelectionInGantt]

            // END WIZARD CODE
            /*START EDIT ZONE [OnOpenSelectionInGantt]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnPrint(object arg)
        {
            Action baseMethod = () => { base.OnPrint(arg); };

            // START WIZARD CODE [OnPrint]

            // END WIZARD CODE
            /*START EDIT ZONE [OnPrint]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnPrintPreview(object arg)
        {
            Action baseMethod = () => { base.OnPrintPreview(arg); };

            // START WIZARD CODE [OnPrintPreview]

            // END WIZARD CODE
            /*START EDIT ZONE [OnPrintPreview]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnResultsWidgetViewModelChanged(IResultsWidgetViewModel previousResultsWidgetViewModel)
        {
            Action baseMethod = () => { base.OnResultsWidgetViewModelChanged(previousResultsWidgetViewModel); };

            // START WIZARD CODE [OnResultsWidgetViewModelChanged]

            // END WIZARD CODE
            /*START EDIT ZONE [OnResultsWidgetViewModelChanged]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnSearch(object arg)
        {
            Action baseMethod = () => { base.OnSearch(arg); };

            // START WIZARD CODE [OnSearch]

            // END WIZARD CODE
            /*START EDIT ZONE [OnSearch]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnSearchTextWidgetChanged(object arg)
        {
            Action baseMethod = () => { base.OnSearchTextWidgetChanged(arg); };

            // START WIZARD CODE [OnSearchTextWidgetChanged]

            // END WIZARD CODE
            /*START EDIT ZONE [OnSearchTextWidgetChanged]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnSelectedGanttTemplateChanged(GanttTemplateDescription obj)
        {
            Action baseMethod = () => { base.OnSelectedGanttTemplateChanged(obj); };

            // START WIZARD CODE [OnSelectedGanttTemplateChanged]

            // END WIZARD CODE
            /*START EDIT ZONE [OnSelectedGanttTemplateChanged]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnSelectedReportChanged(Report previousValue)
        {
            Action baseMethod = () => { base.OnSelectedReportChanged(previousValue); };

            // START WIZARD CODE [OnSelectedReportChanged]

            // END WIZARD CODE
            /*START EDIT ZONE [OnSelectedReportChanged]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnView(object arg)
        {
            Action baseMethod = () => { base.OnView(arg); };

            // START WIZARD CODE [OnView]

            // END WIZARD CODE
            /*START EDIT ZONE [OnView]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OnViewObjects(int[] objectIds)
        {
            Action baseMethod = () => { base.OnViewObjects(objectIds); };

            // START WIZARD CODE [OnViewObjects]

            // END WIZARD CODE
            /*START EDIT ZONE [OnViewObjects]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void OpenGanttForm(Dictionary<string, string> extraParams = null)
        {
            Action baseMethod = () => { base.OpenGanttForm(extraParams); };

            // START WIZARD CODE [OpenGanttForm]

            // END WIZARD CODE
            /*START EDIT ZONE [OpenGanttForm]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void RefreshCommandRights()
        {
            Action baseMethod = () => { base.RefreshCommandRights(); };

            // START WIZARD CODE [RefreshCommandRights]

            // END WIZARD CODE
            /*START EDIT ZONE [RefreshCommandRights]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void RefreshResultsWidgets()
        {
            Action baseMethod = () => { base.RefreshResultsWidgets(); };

            // START WIZARD CODE [RefreshResultsWidgets]

            // END WIZARD CODE
            /*START EDIT ZONE [RefreshResultsWidgets]*/
            /*END EDIT ZONE*/
            baseMethod();
        }

        protected override void ResultsSelectedItems_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            Action baseMethod = () => { base.ResultsSelectedItems_CollectionChanged(sender, e); };

            // START WIZARD CODE [ResultsSelectedItems_CollectionChanged]

            // END WIZARD CODE
            /*START EDIT ZONE [ResultsSelectedItems_CollectionChanged]*/
            /*END EDIT ZONE*/
            baseMethod();
        }
    }
}