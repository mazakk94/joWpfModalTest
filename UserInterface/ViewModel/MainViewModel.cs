﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Data;
using System.Windows.Input;


namespace UserInterface.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase, INotifyPropertyChanged
    {
        
        private ObservableCollection<TestViewModel> _tests;
        private ObservableCollection<IQuestion> _questions;
        private IDAO _dao;

        private MyRelayCommand _addTestCommand;
      
      //  public event PropertyChangedEventHandler PropertyChanged;         ALE NAROBIŁ INBY
       

        
        public ObservableCollection<TestViewModel> Tests
        {
            get { return _tests; }
            set
            {
                _tests = value;
                RaisePropertyChanged("Tests");
            }
        }
         

        public ObservableCollection<IQuestion> Questions
        {
            get { return _questions; }
            set
            {
                _questions = value;
                RaisePropertyChanged("Questions");
            }
        }


        private ObservableCollection<IQuestion> _resultQuestionList;

        public ObservableCollection<IQuestion> ResultQuestionList
        {
            get { return _resultQuestionList; }
            set
            {
                _resultQuestionList = value;
                RaisePropertyChanged("Questions");
            }
        }

        
        private String _testText;
        public String TestText
        {
            get { return _testText; }
            set
            {
                _testText = value;
                //NotifyPropertyChanged("TestText");
                RaisePropertyChanged("TestText");
            }
        }

        /*
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }*/
        
        private void FillTestText()
        {
            _testText = "Init";
        }

        private void Print()
        {
            _testText += "String";
         //   NotifyPropertyChanged("TestText");
        }

        private void GetAllTests()
        {
            foreach (var c in _dao.GetAllTests())
            {
                _tests.Add(new TestViewModel(c));
            }
        }

        private void GetAllQuestions()
        {
            foreach (var c in _dao.GetAllQuestions())
            {
                _questions.Add(c);
            }
        }


       
        private int _selectedIndex;

        public int Index
        {
            get
            {
                return _selectedIndex;
            }

            set
            {
                if (_selectedIndex == value)
                {
                    return;
                }

                _selectedIndex = value;
                _questions.Clear();
                List<int> questionsIds = GetQuestionsIds(_selectedIndex);

                GetQuestions(questionsIds);
                //GetQuestions(_selectedIndex);
                //GetAllQuestions();
                //tutaj robie reset pytań i dodaje z aktualnego indeksu

                //Items[_selectedIndex] = (Convert.ToInt32(Items[_selectedIndex]) + 1).ToString();
                //RaisePropertyChanged(() => Index);
            }
        }


        
       private void GetQuestions(List<int> questionsIds)
       {
           foreach (var id in questionsIds)
           {
               _questions.Add(_dao.GetQuestion(id));
           }
       }

       private List<int> GetQuestionsIds(int _selectedIndex)
       {
           List<int> ids = new List<int>();
           foreach (var test in _dao.GetAllTests())
           {
               if (test.Id == _selectedIndex)
               {
                   ids = test.QuestionsIds;
               }
           }
           return ids;
       }


        
        /*
       private void RaisePropertyChanged(string propertyName)
       {
           if (PropertyChanged != null)
           {
               PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
           }
       }*/

       public ICommand AddTestCommand
       {
           get { return _addTestCommand; }
       }

       private void AddTestToList()
       {
           ITest test = _dao.CreateNewTest();
           TestViewModel qvm = new TestViewModel(test);
           _dao.AddTest(test);
           Tests.Add(qvm);
           EditedTest = qvm;
       }

       private ICommand _saveNewTestCommand;

       public ICommand SaveNewTestCommand
       {
           get { return _saveNewTestCommand; }
       }

       private TestViewModel _editedTest;

       public TestViewModel EditedTest
       {
           get { return _editedTest; }
           set
           {
               _editedTest = value;
               RaisePropertyChanged("EditedTest");
           }
       }

       private void SaveTest()
       {
           _tests.Add(_editedTest);
       }

       private bool CanSaveTest()
       {
           if (EditedTest == null)
               return false;

           if (EditedTest.HasErrors)
               return false;

           return true;
       }

       private MyRelayCommand _printTextCommand;

       public MyRelayCommand PrintTextCommand
       {
           get { return _printTextCommand; }
       }


       private MyRelayCommand _filterDataCommand;

       public MyRelayCommand FilterDataCommand
       {
           get { return _filterDataCommand; }
       }

       private MyRelayCommand _selectedItemChangedCommand;

       public MyRelayCommand SelectedItemChangedCommand
       {
           get { return _selectedItemChangedCommand; }
       }

       private ListCollectionView _view;

       private string _filterData;

       public string FilterData
       {
           get { return _filterData; }
           set
           {
               _filterData = value;
               RaisePropertyChanged("FilterData");
           }
       }
        
        /*
        private void DoFilterData()
        {
            if (FilterData.Length > 0)
            {
                _view.Filter = (c) => ((testViewModel)c).Name.Contains(FilterData);
            }
            else
            {
                _view.Filter = null;
            }
        }
         * */

        private RelayCommand _grouptestsCommand;

        public RelayCommand GrouptestsCommand
        {
            get { return _grouptestsCommand; }
        }

        /*
        private void GroupByPrice()
        {
            _view.SortDescriptions.Add(new SortDescription("Price", 
                ListSortDirection.Ascending));
            _view.GroupDescriptions.Add(new PropertyGroupDescription("Price"));
        }
         * */



        private readonly IDataService _dataService;

        private string _someString;

        public string SomeString
        {
            get
            {
                return _someString;
            }

            set
            {
                if (_someString == value)
                {
                    return;
                }

                _someString = value;
                RaisePropertyChanged(() => SomeString);
            }
        }

        private string _result;
        private string _resultv2;

       

        public string Result
        {
            get
            {
                return _result;
            }

            set
            {
                if (_result == value)
                {
                    return;
                }

                _result = value;
                RaisePropertyChanged(() => Result);
            }
        }


        public string Resultv2
        {
            get
            {
                return _resultv2;
            }

            set
            {
                if (_resultv2 == value)
                {
                    return;
                }

                _resultv2 = value;
                RaisePropertyChanged(() => Resultv2);
            }
        }

        private List<Tuple<string, string>> _resultList;

        public List<Tuple<string, string>> ResultList
        {
            get
            {
                return _resultList;
            }

            set
            {
                if (_resultList == value)
                {
                    return;
                }

                _resultList = value;
                RaisePropertyChanged(() => ResultList);
            }
        }
        
        /// <summary>
        /// Initializes a new instance of the MainViewModel class.
        /// </summary>
        public MainViewModel(IDataService dataService)
        {
            _dataService = dataService;
            _dataService.GetData(
              (item, error) =>
              {
                  if (error != null)
                  {
                      // Report error here
                      return;
                  }
              });

            SomeString = "Some Placeholder Text - modify if you want";
            Result = "Output Placeholder Result";
            Resultv2 = "Output v2";
            ResultList = new List<Tuple<string, string>>();
            ResultList.Add(new Tuple<string, string>("a", "1"));
            //ResultList.Add(new Tuple<string, string>("b", "2"));

            //może _resultList?
            

            _tests = new ObservableCollection<TestViewModel>();
            _questions = new ObservableCollection<IQuestion>();
            _resultQuestionList = new ObservableCollection<IQuestion>();

            CreateNewTestCommand =
              new GalaSoft.MvvmLight.Command.RelayCommand(
                () =>
                Messenger.Default.Send<Helpers.OpenWindowMessage>(
                  new Helpers.OpenWindowMessage() { Type = Helpers.WindowType.kNewTest, Argument = SomeString }));


            OpenModalDialog =
              new GalaSoft.MvvmLight.Command.RelayCommand(
                () =>
                Messenger.Default.Send<Helpers.OpenWindowMessage>(
                  new Helpers.OpenWindowMessage() { Type = Helpers.WindowType.kModal, Argument = SomeString }));
            OpenNonModalDialog =
              new GalaSoft.MvvmLight.Command.RelayCommand(
                () =>
                Messenger.Default.Send<Helpers.OpenWindowMessage>(
                  new Helpers.OpenWindowMessage() { Type = Helpers.WindowType.kNonModal, Argument = SomeString }));
            
            Messenger.Default.Register<string>(this, s => Result = s);
            Messenger.Default.Register<string>(this, "token", s => Resultv2 = s);
            //Messenger.Default.Register<List<string>>(this, "list", s => ResultList = s);
            Messenger.Default.Register<List<Tuple<string, string>>>(this, "tuplelist", s => ResultList = s);
            Messenger.Default.Register<ObservableCollection<IQuestion>>(this, "questionList", s => ResultQuestionList = s);

            _dao = new DataAccessObject.DAO();
            _view = (ListCollectionView)CollectionViewSource.GetDefaultView(_tests);
            FilterData = "";
            GetAllTests();
            GetAllQuestions();
            FillTestText();
            _addTestCommand = new MyRelayCommand(param => this.AddTestToList());
            _saveNewTestCommand = new MyRelayCommand(param => this.SaveTest(),
                                                  param => this.CanSaveTest());
            //_filterDataCommand = new RelayCommand(param => this.DoFilterData());
            //_grouptestsCommand = new RelayCommand(param => this.GroupByPrice());
            //_selectedItemChangedCommand = new MyRelayCommand(param => this.)
            _printTextCommand = new MyRelayCommand(param => this.Print());


        }

        public RelayCommand CreateNewTestCommand { get; private set; }
        public RelayCommand OpenModalDialog { get; private set; }
        public RelayCommand OpenNonModalDialog { get; private set; }
    }
}