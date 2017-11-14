using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Microsoft.WindowsAzure.MobileServices;
using System.Collections.ObjectModel;

namespace Practica9
{
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<_13090353> Items { get; set; }
        public static MobileServiceClient cliente;
        public static IMobileServiceTable<_13090353> Table;
        public static MobileServiceUser Usuario;

        public MainPage()
        {
            InitializeComponent();
            cliente = new MobileServiceClient(AzureConnection.AzureUrl);
            Login();
            Table = cliente.GetTable<_13090353>();
        }

        public async void Login() {
            Usuario = await App.Authenticator.Authenticate();
            if (App.Authenticator != null) {

                if (Usuario != null) {

                    await DisplayAlert("Usuario Autenticado", Usuario.UserId, "Ok");
                }
                LeerTabla();
            }
        }

        async void ListView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;
            await Navigation.PushAsync(new UpdatePage(e.SelectedItem as _13090353));
        }

        private void Insertar_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new InsertPage());
        }

        private void Eliminados_Clicked(object sender, EventArgs e)
        {
            LeerEliminados(); ;
        }

        public async void LeerTabla()
        {
            try
            {
                IEnumerable<_13090353> elementos = await Table.ToEnumerableAsync();
                Items = new ObservableCollection<_13090353>(elementos);
                BindingContext = this;
                Lista.ItemsSource = Items;
                Insertar.IsEnabled = true;
                Insertar.IsVisible = true;
                Eliminados.IsEnabled = true;
                Eliminados.IsVisible = true;

            }
            catch (Exception ex)
            {
                await DisplayAlert("Importante", "Conexion a la base de datos no encontrada comuniquese con el servicio de azure", "ok");

            }
        }

        public async void LeerEliminados()
        {
            try { 
            IEnumerable<_13090353> elementos = await Table.IncludeDeleted().Where(_13090353 => _13090353.Deleted == true).ToEnumerableAsync();
            Items = new ObservableCollection<_13090353>(elementos);
            BindingContext = this;
            Lista.ItemsSource = Items;
            DB.IsEnabled = true;
            DB.IsVisible = true;

            }
            catch (Exception ex)
            {
                await DisplayAlert("Importante", "Conexion a la base de datos no encontrada comuniquese con el servicio de azure", "ok");

    }
}
        private void DB_Clicked(object sender, EventArgs e)
        {
            LeerTabla();      
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            if (Usuario != null) {
                LeerTabla();
            }
        }
    }
}
