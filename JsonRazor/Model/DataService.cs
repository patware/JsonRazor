using System;

namespace JsonRazor.Model
{
    public class DataService : IDataService
    {
        public void GetData(Action<DataItem, Exception> callback)
        {
            // Use this to connect to the actual data service

            var item = new DataItem("{'FirstName':'First Name'}", "First Name: @Model.FirstName");
            callback(item, null);
        }
    }
}