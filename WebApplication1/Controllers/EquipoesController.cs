<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="JCevallls.MainPage"
             xmlns:vm="clr-namespace:JCevallls.ViewModels">
    <ContentPage.BindingContext>
        <vm:CountriesViewModel />
    </ContentPage.BindingContext>

    <VerticalStackLayout>
        <SearchBar Placeholder="Enter country name"
                   SearchCommand="{Binding SearchCountryCommand}"
                   SearchCommandParameter="{Binding Text, Source={RelativeSource Self}}"/>
        <Button Text="Search"
                Command="{Binding SearchCountryCommand}"
                CommandParameter="{Binding Text, Source={RelativeSource Self}}"/>
        <ListView ItemsSource="{Binding Countries}">
            <ListView.ItemTemplate>
                <DataTemplate>
                    <TextCell Text="{Binding CommonName}" Detail="{Binding Region}"/>
                </DataTemplate>
            </ListView.ItemTemplate>
        </ListView>
    </VerticalStackLayout>
</ContentPage>
