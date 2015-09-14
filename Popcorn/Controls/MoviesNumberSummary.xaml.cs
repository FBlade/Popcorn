﻿using System.Windows;

namespace Popcorn.Controls
{
    /// <summary>
    /// Interaction logic for MoviesNumberSummary.xaml
    /// </summary>
    public partial class MoviesNumberSummary
    {
        /// <summary>
        /// Max number property
        /// </summary>
        public static readonly DependencyProperty MaxNumberOfMoviesProperty =
            DependencyProperty.Register("MaxNumberOfMovies",
                typeof (double), typeof (MoviesNumberSummary),
                new PropertyMetadata(0d, OnNumberOfMoviesChanged));

        /// <summary>
        /// Current number property
        /// </summary>
        public static readonly DependencyProperty CurrentNumberOfMoviesProperty =
            DependencyProperty.Register("CurrentNumberOfMovies",
                typeof (double), typeof (MoviesNumberSummary),
                new PropertyMetadata(0d, OnNumberOfMoviesChanged));

        /// <summary>
        /// The maximum number of movies
        /// </summary>
        public double MaxNumberOfMovies
        {
            private get { return (double) GetValue(MaxNumberOfMoviesProperty); }
            set { SetValue(MaxNumberOfMoviesProperty, value); }
        }

        /// <summary>
        /// The current number of movies
        /// </summary>
        public double CurrentNumberOfMovies
        {
            private get { return (double) GetValue(CurrentNumberOfMoviesProperty); }
            set { SetValue(CurrentNumberOfMoviesProperty, value); }
        }

        /// <summary>
        /// Initialize a new instance of MoviesNumberSummary
        /// </summary>
        public MoviesNumberSummary()
        {
            InitializeComponent();
        }

        /// <summary>
        /// On number of movies changed
        /// </summary>
        /// <param name="d">Dependency object</param>
        /// <param name="e">Event args</param>
        private static void OnNumberOfMoviesChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var moviesNumberSummary = d as MoviesNumberSummary;
            moviesNumberSummary?.DisplayMoviesNumberSummary();
        }

        /// <summary>
        /// Display movies summary
        /// </summary>
        private void DisplayMoviesNumberSummary()
        {
            if (CurrentNumberOfMovies.Equals(MaxNumberOfMovies))
            {
                MaxMovies.Visibility = Visibility.Collapsed;
                CurrentMovies.Visibility = Visibility.Visible;

                CurrentMovies.Text =
                    $"{CurrentNumberOfMovies}";
            }
            else
            {
                MaxMovies.Visibility = Visibility.Visible;
                CurrentMovies.Visibility = Visibility.Visible;

                CurrentMovies.Text =
                    $"{CurrentNumberOfMovies}";
                MaxMovies.Text =
                    $"{MaxNumberOfMovies}";
            }
        }
    }
}