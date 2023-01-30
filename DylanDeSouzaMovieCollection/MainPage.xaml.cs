using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DylanDeSouzaMovieCollection
{
    public class MovieOwner
    {
        public string name;
        public int age;
        public string email;
        public List<string> movies;

        public MovieOwner(string name, int age, string email, List<string> movies)
        {
            this.name = name;
            this.age = age;
            this.email = email;
            this.movies = movies;
        }

        
    }

    enum content_rating { CTC, G, PG, M, MA, R, X }

    public class Movie
    {
        public string name;
        public int duration;
        public int released;
        public string cast;
        public int rating;

        public Movie(string name, int duration, int released, string cast, int rating)
        {
            this.name = name;
            this.duration = duration;
            this.released = released;
            this.cast = cast;
            this.rating = rating;
        }
    }

    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }
    }
}
