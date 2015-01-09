using GalaSoft.MvvmLight;
using JsonRazor.Model;

namespace JsonRazor.ViewModel
{
    /// <summary>
    /// This class contains properties that the main View can data bind to.
    /// <para>
    /// See http://www.galasoft.ch/mvvm
    /// </para>
    /// </summary>
    public class MainViewModel : ViewModelBase
    {
        private readonly IDataService _dataService;
        private object _parsedModel;
        

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

                    Model = item.Model;
                    Template = item.Template;
                    parseModel();
                    applyTemplate();
                    
                });

            this.PropertyChanged += MainViewModel_PropertyChanged;
        }

        void MainViewModel_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            switch(e.PropertyName)
            {
                case ModelPropertyName:
                    parseModel();
                    applyTemplate();
                    break;

                case TemplatePropertyName:
                    applyTemplate();
                    break;
            }
        }

        

        private void parseModel()
        {
            Messages = "Model Parsed";
        }

        private void applyTemplate()
        {
            Result = "Template Executed";
        }

        ////public override void Cleanup()
        ////{
        ////    // Clean up if needed

        ////    base.Cleanup();
        ////}

        #region Properties
        #region Model
        /// <summary>
        /// The <see cref="Model" /> property's name.
        /// </summary>
        public const string ModelPropertyName = "Model";

        private string _model = string.Empty;

        /// <summary>
        /// Sets and gets the Model property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string Model
        {
            get
            {
                return _model;
            }

            set
            {
                if (_model == value)
                {
                    return;
                }

                _model = value;
                RaisePropertyChanged(ModelPropertyName);
            }
        }
        #endregion
        #region Template
        /// <summary>
        /// The <see cref="Template" /> property's name.
        /// </summary>
        public const string TemplatePropertyName = "Template";

        private string _template = string.Empty;

        /// <summary>
        /// Sets and gets the Template property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string Template
        {
            get
            {
                return _template;
            }

            set
            {
                if (_template == value)
                {
                    return;
                }

                _template = value;
                RaisePropertyChanged(TemplatePropertyName);
            }
        }
        #endregion
        #region Messages
        /// <summary>
        /// The <see cref="Messages" /> property's name.
        /// </summary>
        public const string MessagesPropertyName = "Messages";

        private string _messages = string.Empty;

        /// <summary>
        /// Sets and gets the Messages property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
        public string Messages
        {
            get
            {
                return _messages;
            }

            set
            {
                if (_messages == value)
                {
                    return;
                }

                _messages = value;
                RaisePropertyChanged(MessagesPropertyName);
            }
        }
        #endregion
        #region Result
        /// <summary>
        /// The <see cref="Result" /> property's name.
        /// </summary>
        public const string ResultPropertyName = "Result";

        private string _result = string.Empty;

        /// <summary>
        /// Sets and gets the Result property.
        /// Changes to that property's value raise the PropertyChanged event. 
        /// </summary>
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
                RaisePropertyChanged(ResultPropertyName);
            }
        }
        #endregion
        #endregion


    }
}