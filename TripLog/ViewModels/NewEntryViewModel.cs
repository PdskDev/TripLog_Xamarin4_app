﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using TripLog.Models;
using Xamarin.Forms;

namespace TripLog.ViewModels
{
    public class NewEntryViewModel: BaseViewModel
    {
        Command _saveCommand;
        public Command SaveCommand => _saveCommand ?? (_saveCommand = new Command(Save , CanSave));

        void Save()
        {
            var newItem = new TripLogEntry
            {
                Title = Title,
                Latitude = Latitude,
                Longitude = Longitude,
                Date = Date,
                Rating = Rating,
                Notes = Notes
            };

            //TODO : Persist entry
        }

        bool CanSave() => !string.IsNullOrWhiteSpace(Title);

        string _title;
        public string Title
        {
            get => _title;
            set
            {
                _title = value;
                OnPropertyChanged();
                SaveCommand.ChangeCanExecute();
            }
        }

        double _latitde;
        public double Latitude
        {
            get => _latitde;
            set
            {
                _latitde = value;
                OnPropertyChanged();
            }
        }

        double _longitude;
        public double Longitude
        {
            get => _longitude;
            set
            {
                _longitude = value;
                OnPropertyChanged();
            }
        }

        DateTime _date;
        public DateTime Date
        {
            get => _date;
            set
            {
                _date = value;
                OnPropertyChanged();
            }
        }

        int _rating;
        public int Rating
        {
            get => _rating;
            set
            {
                _rating = value;
                OnPropertyChanged();
            }
        }

        string _notes;
        public string Notes
        {
            get => _notes;
            set
            {
                _notes = value;
                OnPropertyChanged();
            }
        }

        public NewEntryViewModel()
        {
            Date = DateTime.Today;
            Rating = 1;
        }
    }
}