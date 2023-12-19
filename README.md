# How to enable entry in one column when clicking a button in another column of the same row
We can enable an entry in one column when clicking a button in another column of the same row by changing the EmployeeStatus property of the entry in the button click.

Refer the below code example in which an Entry and a Button is loaded as column element using [DataGridTemplateColumn](https://help.syncfusion.com/cr/maui/Syncfusion.Maui.DataGrid.DataGridTemplateColumn.html) in [SfDataGrid](https://www.syncfusion.com/maui-controls/maui-datagrid).

##### Behavior
 ```XML
 <syncfusion:SfDataGrid  ItemsSource="{Binding Employees}"
                        AutoGenerateColumnsMode="None"
                        ColumnWidthMode="Auto"
                        DefaultColumnWidth="155">
    <syncfusion:SfDataGrid.Columns>
        <syncfusion:DataGridTextColumn MappingName="IDNumber"
                                       HeaderText="ID Number" />
        <syncfusion:DataGridTemplateColumn MappingName="Employee ID">
            <syncfusion:DataGridTemplateColumn.CellTemplate>
                    <DataTemplate>
                        <Entry IsEnabled="{Binding EmployeeStatus}"
                               Text="{Binding EmployeeID}"
                               TextColor="Black" />
                    </DataTemplate>
                </syncfusion:DataGridTemplateColumn.CellTemplate>
        </syncfusion:DataGridTemplateColumn>

    <syncfusion:DataGridTemplateColumn MappingName="Name">
        <syncfusion:DataGridTemplateColumn.CellTemplate>
            <DataTemplate>
                    <Button Text="{Binding Name}"
                            TextColor="Black">
                        <Button.Behaviors>
                            <behaviors:DataGridBehavior />
                        </Button.Behaviors>
                    </Button>
                </DataTemplate>
        </syncfusion:DataGridTemplateColumn.CellTemplate>
    </syncfusion:DataGridTemplateColumn>
    </syncfusion:SfDataGrid.Columns>

</syncfusion:SfDataGrid>
 ```
 
##### xaml.cs 
The below code illustrates how to enable the EmployeeStatus property of an entry when the button on the same row is clicked. 
 ```XML
 protected override void OnAttachedTo(Button button)
 {
     base.OnAttachedTo(button);
     button.Clicked += OnButtonClicked;
 }

 protected override void OnDetachingFrom(Button button)
 {
     base.OnDetachingFrom(button);
     button.Clicked -= OnButtonClicked;
 }

 private void OnButtonClicked(object sender, EventArgs e)
 {
     var data = ((sender as Button).BindingContext as Employee);
     data.EmployeeStatus = true;
 }

 ```
 

[View sample in GitHub](https://github.com/SyncfusionExamples/How-to-enable-entry-in-one-column-when-clicking-a-button-in-another-column-of-the-same-row/tree/master)

Take a moment to explore this [documentation](https://help.syncfusion.com/maui/datagrid/overview), where you can find more information about Syncfusion .NET MAUI DataGrid (SfDataGrid) with code examples. Please refer to this [link](https://www.syncfusion.com/maui-controls/maui-datagrid) to learn about the essential features of Syncfusion .NET MAUI DataGrid (SfDataGrid).

##### Conclusion

I hope you enjoyed learning about How to enable entry in one column when clicking a button in another column of the same row? in .NET MAUI DataGrid (SfDataGrid).

You can refer to our [.NET MAUI DataGrid’s feature tour](https://www.syncfusion.com/maui-controls/maui-datagrid) page to learn about its other groundbreaking feature representations. You can also explore our [.NET MAUI DataGrid Documentation](https://help.syncfusion.com/maui/datagrid/getting-started) to understand how to present and manipulate data. 
For current customers, you can check out our .NET MAUI components on the [License and Downloads](https://www.syncfusion.com/sales/teamlicense) page. If you are new to Syncfusion, you can try our 30-day [free trial](https://www.syncfusion.com/downloads/maui) to explore our .NET MAUI DataGrid and other .NET MAUI components.

If you have any queries or require clarifications, please let us know in the comments below. You can also contact us through our [support forums](https://www.syncfusion.com/forums), [Direct-Trac](https://support.syncfusion.com/create) or [feedback portal](https://www.syncfusion.com/feedback/maui?control=sfdatagrid), or the feedback portal. We are always happy to assist you!
