qx.Class.define("qxdotnet.table.RemoteDataModel",
{
    extend: qx.ui.table.model.Remote,

    members:
  {
      // overloaded - called whenever the table requests the row count
      _loadRowCount: function() {
          // Call the backend service (example) - using XmlHttp
          var parameters = "?r=grid&id=" + this._id_ + "&m=cnt";
          var req = new qx.io.remote.Request(ApplicationName + parameters, "GET", "application/json");
          // Add listener
          req.addListener("completed", this._onRowCountCompleted, this);

          // send request
          req.send();
      },

      // Listener for request of "_loadRowCount" method
      _onRowCountCompleted: function(response) {
          var result = response.getContent();
          if (result != null) {
              // Apply it to the model - the method "_onRowCountLoaded" has to be called
              this._onRowCountLoaded(result);
          }
      },

      // overloaded - called whenever the table requests new data
      _loadRowData: function(firstRow, lastRow) {
          // Call the backend service (example) - using XmlHttp
          var parameters = "?r=grid&id=" + this._id_ + "&m=d&f=" + firstRow + "&t=" + lastRow;

          // get the column index to sort and the order
          var sortIndex = this.getSortColumnIndex();
          var sortOrder = this.isSortAscending() ? "asc" : "desc";

          // setting the sort parameters - assuming the backend knows these
          parameters += "&so=" + sortOrder + "&si=" + sortIndex;

          var url = ApplicationName + parameters;
          var req = new qx.io.remote.Request(url, "GET", "application/json");

          // Add listener
          req.addListener("completed", this._onLoadRowDataCompleted, this);

          // send request
          req.send();
      },

      // Listener for request of "_loadRowData" method
      _onLoadRowDataCompleted: function(response) {
          var result = response.getContent();
          if (result != null) {
              // Apply it to the model - the method "_onRowDataLoaded" has to be called
              this._onRowDataLoaded(result);
          }
          //var result = "[{ \"c0\" : \"John\", \"c1\" : \"Doe\"  }, { \"c0\" : \"Homer\", \"c1\" : \"Simpson\"  }, { \"c0\" : \"Charlie\", \"c1\" : \"Brown\"  }]";
      }
  }
});