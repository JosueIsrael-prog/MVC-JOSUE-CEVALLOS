<ContentPage xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
             xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
             x:Class="CevallosJosueExamenP2.DatosPersonalesPage"
             Title="Datos personales">
    <Grid RowDefinitions="*,*" ColumnDefinitions="*,*">
        <Label Text="Primer Nombre" Grid.Row="0" Grid.Column="0" />
        <Label Text="Segundo Nombre" Grid.Row="0" Grid.Column="1" />
        <Label Text="Primer Apellido" Grid.Row="1" Grid.Column="0" Style="{StaticResource ApellidoStyle}" />
        <Label Text="Segundo Apellido" Grid.Row="1" Grid.Column="1" Style="{StaticResource ApellidoStyle}" />
    </Grid>
</ContentPage>