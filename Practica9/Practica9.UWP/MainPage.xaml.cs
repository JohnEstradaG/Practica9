using Microsoft.WindowsAzure.MobileServices;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

namespace Practica9.UWP
{
    public sealed partial class MainPage : SQLAzure
    {
        private MobileServiceUser usuario;

        public async Task<MobileServiceUser> Authenticate()
        {
            try
            {
                usuario = await Practica9.MainPage.cliente.LoginAsync(MobileServiceAuthenticationProvider.MicrosoftAccount, "tesh.azurewebsites.net");
                if (usuario != null)
                {

                    await new MessageDialog(usuario.UserId, "Bienvenido").ShowAsync();
                }
            }
            catch (Exception ex)
            {

                await new MessageDialog(ex.Message, "Error de Mensaje").ShowAsync();
            }
            return usuario;
        }
        public MainPage()
        {
            this.InitializeComponent();
            Practica9.App.Init((SQLAzure)this);
            LoadApplication(new Practica9.App());
        }
    }
}
