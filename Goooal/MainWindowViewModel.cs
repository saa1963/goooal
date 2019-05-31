﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;

namespace Goooal
{
    public class MainWindowViewModel: NotifyPropertyChanged
    {
        private TimeSpan initIntervalValue = new TimeSpan(0, 1, 0);
        private readonly TimeSpan second = new TimeSpan(0, 0, 1);
        private DispatcherTimer m_Timer;

        public MainWindowViewModel()
        {
            Interval = initIntervalValue;
            SetTimer();
        }

        public void ResetTimer()
        {
            if (m_Timer.IsEnabled)
            {
                m_Timer.Stop();
            }
            Interval = initIntervalValue;
        }

        public void SwitchTimer()
        {
            if (!m_Timer.IsEnabled)
            {
                m_Timer.Start();
            }
            else
            {
                m_Timer.Stop();
            }
        }

        private void SetTimer()
        {
            m_Timer = new DispatcherTimer();
            m_Timer.Tick += M_Timer_Tick;
            m_Timer.Interval = new TimeSpan(0, 0, 1);
        }

        private void M_Timer_Tick(object sender, EventArgs e)
        {
            if (Interval.Ticks > 0)
            {
                Interval = Interval.Subtract(second);
            }
            else
            {
                m_Timer.Stop();
            }
        }

        private string m_Team1 = "Команда1";
        public string Team1
        {
            get => m_Team1;
            set
            {
                m_Team1 = value;
                OnPropertyChanged("Team1");
            }
        }
        private string m_Team2 = "Команда2";
        public string Team2
        {
            get => m_Team2;
            set
            {
                m_Team2 = value;
                OnPropertyChanged("Team2");
            }
        }
        private int m_Fouls1 = 0;
        public int Fouls1
        {
            get => m_Fouls1;
            set
            {
                m_Fouls1 = value;
                OnPropertyChanged("Fouls1");
            }
        }
        private int m_Fouls2 = 0;
        public int Fouls2
        {
            get => m_Fouls2;
            set
            {
                m_Fouls2 = value;
                OnPropertyChanged("Fouls2");
            }
        }
        private string m_PlayName = "Название игры";
        public string PlayName
        {
            get => m_PlayName;
            set
            {
                m_PlayName = value;
                OnPropertyChanged("PlayName");
            }
        }
        private int m_Score1 = 0;
        public int Score1
        {
            get => m_Score1;
            set
            {
                m_Score1 = value;
                OnPropertyChanged("Score1");
            }
        }
        private int m_Score2 = 0;
        public int Score2
        {
            get => m_Score2;
            set
            {
                m_Score2 = value;
                OnPropertyChanged("Score2");
            }
        }
        private TimeSpan m_Interval;
        public TimeSpan Interval
        {
            get => m_Interval;
            set
            {
                m_Interval = value;
                OnPropertyChanged("Interval");
            }
        }
        public RelayCommand Score2IncCommand
        {
            get => new RelayCommand(s => Score2 = Score2 + 1);
        }
        public RelayCommand Score2DecCommand
        {
            get => new RelayCommand(s => Score2 = Score2 - 1);
        }
    }
}
