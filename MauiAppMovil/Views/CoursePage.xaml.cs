﻿using MauiAppMovil.Models;
using MauiAppMovil.Services;
using MauiAppMovil.ViewModels;

namespace MauiAppMovil.Views
{
    public partial class CoursePage : ContentPage
    {
        private CourseViewModel ViewModel => BindingContext as CourseViewModel;

        public CoursePage()
        {
            InitializeComponent();

            Loaded += async (s, e) =>
            {
                await ViewModel.LoadCoursesAsync(); // ← Only once when the page is loaded
            };
        }

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            await ViewModel.LoadCoursesAsync(); // ← This ensures the list is refreshed every time the page appears
        }

        private async void OnAddCourseClicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new CourseFormPage());
        }

        private async void OnDeleteClicked(object sender, EventArgs e)
        {
            if (sender is Button button && button.CommandParameter is int courseId)
            {
                bool confirm = await DisplayAlert("Eliminar", "¿Seguro que deseas eliminar este curso?", "Sí", "No");
                if (!confirm) return;

                using var client = new HttpClient();
                var response = await client.DeleteAsync($"{AppConstants.ApiBaseUrl}/course/{courseId}");

                if (response.IsSuccessStatusCode)
                {
                    await DisplayAlert("Eliminado", "Curso eliminado correctamente", "OK");
                    await ViewModel.LoadCoursesAsync(); // Refresh the list after deletion
                }
                else
                {
                    await DisplayAlert("Error", "No se pudo eliminar el curso", "OK");
                }
            }
        }

        private async void OnEditClicked(object sender, EventArgs e)
        {
            if (sender is Button button && button.CommandParameter is Course course)
            {
                await Navigation.PushAsync(new CourseFormPage(course)); // ← Send the course to edit
            }
        }
    }
}
