<Shell xmlns="http://schemas.microsoft.com/dotnet/2021/maui"
       xmlns:x="http://schemas.microsoft.com/winfx/2009/xaml"
       xmlns:local="clr-namespace:CevallosJosueExamenP2"
       x:Class="CevallosJosueExamenP2.AppShell"
       Title="CevallosJosueExamenP2">

    <TabBar>
        <!-- Pestaña para Recarga -->
        <Tab Title="Recarga" Icon="icon_recarga.png">
            <ShellContent ContentTemplate="{DataTemplate local:RecargaTelefonicaPage}" />
        </Tab>

        <!-- Pestaña para Datos Personales -->
        <Tab Title="Datos" Icon="icon_datos.png">
            <ShellContent ContentTemplate="{DataTemplate local:DatosPersonalesPage}" />
        </Tab>
    </TabBar>
</Shell>