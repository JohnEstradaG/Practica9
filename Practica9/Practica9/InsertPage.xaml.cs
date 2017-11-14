using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Practica9
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class InsertPage : ContentPage
    {
        public InsertPage()
        {
            InitializeComponent();
        }

        private async void Insert_Clicked(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nombre.Text))
            {
               await DisplayAlert("Importante", "Ingresa Tu Nombre", "Ok");
            }
            else
            {
                if (string.IsNullOrEmpty(Ape_pat.Text))
                {
                   await DisplayAlert("Importante", "Ingresa Tu Apellido Paterno", "Ok");
                }
                else
                {
                    if (string.IsNullOrEmpty(Ape_mat.Text))
                    {
                       await DisplayAlert("Importante", "Ingresa Tu Apellido Materno", "Ok");
                    }
                    else
                    {
                        if (string.IsNullOrEmpty(Direccion.Text))
                        {
                          await  DisplayAlert("Importante", "Ingresa Tu Direccion", "Ok");
                        }
                        else
                        {
                            if (string.IsNullOrEmpty(Telefono.Text))
                            {
                               await DisplayAlert("Importante", "Ingresa Tu Numero de Telefono", "Ok");
                            }
                            else
                            {
                                if (string.IsNullOrEmpty(Carrera.Text))
                                {
                                  await  DisplayAlert("Importante", "Ingresa Tu Carrera", "Ok");
                                }
                                else
                                {
                                    if (string.IsNullOrEmpty(Semestre.Text))
                                    {
                                      await  DisplayAlert("Importante", "Ingresa Tu Semestre", "Ok");
                                    }
                                    else
                                    {
                                        if (string.IsNullOrEmpty(Correo.Text))
                                        {
                                          await  DisplayAlert("Importante", "Ingresa Tu Correo", "Ok");
                                        }
                                        else
                                        {
                                            if (string.IsNullOrEmpty(Github.Text))
                                            {
                                              await  DisplayAlert("Importante", "Ingresa Tu Github", "Ok");
                                            }
                                            else
                                            {
                                                if (Telefono.Text.Length == 10)
                                                {

                                                    if (Correo.Text.Contains("@hotmail.com"))
                                                    {
                                                        try
                                                        {
                                                            var datos = new _13090353
                                                            {
                                                                Nombre = Nombre.Text,
                                                                ApellidoPaterno = Ape_pat.Text,
                                                                ApellidoMaterno = Ape_mat.Text,
                                                                Direccion = Direccion.Text,
                                                                Telefono = Telefono.Text,
                                                                Carrera = Carrera.Text,
                                                                Semestre = Semestre.Text,
                                                                Correo = Correo.Text,
                                                                Github = Github.Text
                                                            };
                                                            await MainPage.Table.InsertAsync(datos);
                                                            await Navigation.PopAsync();
                                                        }
                                                        catch (Exception ex)
                                                        {

                                                          await  DisplayAlert("Importante", "Ya Existe el Usuario", "Ok");

                                                        }
                                                    }
                                                    else
                                                    {

                                                        if (Correo.Text.Contains("@gmail.com"))
                                                        {
                                                            try
                                                            {
                                                                var datos = new _13090353
                                                                {
                                                                    Nombre = Nombre.Text,
                                                                    ApellidoPaterno = Ape_pat.Text,
                                                                    ApellidoMaterno = Ape_mat.Text,
                                                                    Direccion = Direccion.Text,
                                                                    Telefono = Telefono.Text,
                                                                    Carrera = Carrera.Text,
                                                                    Semestre = Semestre.Text,
                                                                    Correo = Correo.Text,
                                                                    Github = Github.Text
                                                                };
                                                                await MainPage.Table.InsertAsync(datos);
                                                                await Navigation.PushAsync(new MainPage());
                                                            }
                                                            catch (Exception ex)
                                                            {

                                                               await DisplayAlert("Importante", "Ya Existe el Usuario", "Ok");

                                                            }
                                                        }
                                                        else
                                                        {
                                                            if (Correo.Text.Contains("@outlook.com"))
                                                            {
                                                                try
                                                                {
                                                                    var datos = new _13090353
                                                                    {
                                                                        Nombre = Nombre.Text,
                                                                        ApellidoPaterno = Ape_pat.Text,
                                                                        ApellidoMaterno = Ape_mat.Text,
                                                                        Direccion = Direccion.Text,
                                                                        Telefono = Telefono.Text,
                                                                        Carrera = Carrera.Text,
                                                                        Semestre = Semestre.Text,
                                                                        Correo = Correo.Text,
                                                                        Github = Github.Text
                                                                    };
                                                                    await MainPage.Table.InsertAsync(datos);
                                                                    await Navigation.PushAsync(new MainPage());
                                                                }
                                                                catch (Exception ex)
                                                                {

                                                                  await DisplayAlert("Importante", "Ya Existe el Usuario", "Ok");

                                                                }
                                                            }
                                                            else
                                                            {
                                                               await DisplayAlert("Importante", "Su Correo debe de contener \n@hotmail.com \n@outlook.com \n@gmail.com", "Ok");
                                                            }
                                                        }
                                                    }
                                                }
                                                else
                                                {
                                                   await DisplayAlert("Importante", "El Numero de telefono debe Tener 10 Digitos", "Ok");
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}