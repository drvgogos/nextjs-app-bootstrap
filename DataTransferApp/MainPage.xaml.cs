using System;
using Microsoft.Maui.Controls;

namespace DataTransferApp;

public partial class MainPage : ContentPage
{
    public MainPage()
    {
        InitializeComponent();
    }

    private async void BluetoothTransfer_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pages.BluetoothTransferPage());
    }

    private async void USBTransfer_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pages.USBTransferPage());
    }

    private async void WiFiTransfer_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pages.WiFiTransferPage());
    }

    private async void QRCodeTransfer_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pages.QRCodeTransferPage());
    }

    private async void WebInterfaceTransfer_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pages.WebInterfaceTransferPage());
    }

    private async void CloudSyncTransfer_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pages.CloudSyncTransferPage());
    }

    private async void NFCTransfer_Clicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Pages.NFCTransferPage());
    }
}
