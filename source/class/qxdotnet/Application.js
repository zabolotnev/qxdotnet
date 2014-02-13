
/* ***
@asset(qxdotnet/*)
@asset(qx/icon/Oxygen/48/status*)
*/

qx.Class.define("qxdotnet.Application",
{
    extend: qx.application.Standalone,

    /*
    *****************************************************************************
    MEMBERS
    *****************************************************************************
    */

    members:
    {
        /**
        * This method contains the initial application code and gets called 
        * during startup of the application
        * 
        */

        requestCounter: 0,
        isLoading: false,
        loadingControl: new qx.ui.container.Composite(),
        controls: new Array(),
        events: new Array(),

        getControls: function() {
            return this.controls;
        },

        setRequestId: function(id) {
            this.requestCounter = id;
        },


        escapeXMLAttribute: function(attr) {
            if (attr) {
                var result = attr.toString()
                    .replace(/\&/g, "&amp;")
                    .replace(/\"/g, "&quot;")
                    .replace(/\</g, "&lt;")
                    .replace(/\>/g, "&gt;")
                    .replace(/\n/g, "&amp;#10;")
                    .replace(/\r/g, "&amp;#13;");
                return result;
            }
            else {
                return "";
            }
        },

        showLoading: function() {
            var root = this.getRoot();
            this.loadingControl.setOpacity(0);
            qx.event.Timer.once(this.showLoading2, this, 500);

            root.add(this.loadingControl,
            {
                left: 0,
                top: 0,
                width: "100%",
                height: "100%"
            });
        },


        showLoading2: function() {
            this.loadingControl.setOpacity(0.5);
        },

        hideLoading: function() {
            if (!this.isLoading) {
                return;
            }

            var root = this.getRoot();
            root.remove(this.loadingControl);
        },


        ev: function(control, name) {
            for (var i in this.events) {
                var ev = this.events[i];

                if (ev.control === control && ev.name == name) {
                    return ev;
                }
            }

            var event =
            {
                control: control,
                name: name
            };

            event.propname = new Array();
            event.propvalue = new Array();

            event.pr = function(propName, propAccessor) {
                if (this.propname.indexOf(propName) == -1) {
                    this.propname.push(propName);
                }

                this.propvalue[propName] = propAccessor;
            };

            if (!this.isLoading) {
                this.events.push(event);
            }

            return event;
        },

        sendTimeout: null,

        send: function() {
            if (this.isLoading) {
                return;
            }

            this.showLoading();
            var xmlhttp;

            if (window.XMLHttpRequest) {// code for IE7+, Firefox, Chrome, Opera, Safari
                xmlhttp = new XMLHttpRequest();
            }
            else {// code for IE6, IE5
                xmlhttp = new ActiveXObject("Microsoft.XMLHTTP");
            }

            xmlhttp.onreadystatechange = function() {
                if (xmlhttp.readyState != 4) return;

                var app = qx.core.Init.getApplication();

                clearTimeout(app.sendTimeout);
                app.isLoading = true;

                if (xmlhttp.status == 200) {
                    if (xmlhttp.getResponseHeader("Content-Type").indexOf("application/javascript") == -1) {
                        app.hideLoading();
                        app.isLoading = false;

                        var messageWin = window.open("about:blank");
                        messageWin.document.write(xmlhttp.responseText);
                        return;
                    }

                    try {
                        var response = String(xmlhttp.responseText)
                        //alert(response);
                        eval(response);

                        var ctr = app.getControls();
                        for (var i in ctr) {
                            var c = ctr[i];

                            if (c) {
                                c._id_ = i;
                            }
                        }
                    }
                    catch (ex) {
                        if (app.requestCounter == 0) {
                            alert("Internal server error. Try again.");
                        } else {
                            //alert("Script error: " + ex);
                            history.go(0);
                        }
                    }
                    finally {
                        app.hideLoading();
                        app.isLoading = false;
                    }
                }
                else {
                    app.hideLoading();
                    app.isLoading = false;

                    var messageWin = window.open("about:blank");
                    messageWin.document.write(xmlhttp.responseText);
                }
            };

            this.sendTimeout = setTimeout(function() {
                var app = qx.core.Init.getApplication();
                app.hideLoading();
                app.isLoading = false;
                alert("Communication error!");
            },
            30000);

            var params = "req=" + this.requestCounter;

            if (this.events.length > 0) {
                var evData = "<ev>";

                for (var i in this.events) {
                    var ev = this.events[i];

                    if (ev.propname) {
                        evData += "<e _id=\"" + ev.control + "\" ";
                        evData += "_n=\"" + ev.name + "\" ";

                        for (var j = 0; j < ev.propname.length; j++) {
                            var name = ev.propname[j];

                            if (name) {
                                var propRef = "var App = qx.core.Init.getApplication();var ctr = App.getControls();" + ev.propvalue[name];
                                var value = eval(propRef);
                                value = this.escapeXMLAttribute(value);
                                evData += name + "=\"" + value + "\" ";
                            }
                        }

                        evData += "/>";
                    }
                }

                evData += "</ev>";
                params = params + "&ev=" + encodeURIComponent(evData);
            }

            this.isLoading = false;

            xmlhttp.open("POST", ApplicationName, true);
            xmlhttp.setRequestHeader("Content-type", "application/x-www-form-urlencoded");
            xmlhttp.setRequestHeader("Content-length", params.length);
            xmlhttp.setRequestHeader("Connection", "close");
            xmlhttp.send(params);

            this.events = new Array();

            this.requestCounter++;
        },


        main: function() {
            // Call super class
            this.base(arguments);

            // Enable logging in debug variant
            if (qx.core.Environment.get("qx.debug")) {
                // support native logging capabilities, e.g. Firebug for Firefox
                qx.log.appender.Native;

                // support additional cross-browser console. Press F7 to toggle visibility
                qx.log.appender.Console;
            }

            this.loadingControl.setLayout(new qx.ui.layout.Canvas());
            this.loadingControl.setBackgroundColor("#D5D5D5");
            this.loadingControl.setOpacity(0.5);
            var img = new qx.ui.basic.Image("resource/qxdotnet/loading.gif");
            img.width = 64;
            img.height = 64;

            this.loadingControl.add(img,
            {
                left: "50%",
                top: "50%",
                width: "100%",
                height: "100%"
            });

            this.requestCounter = 0;
            this.send();
        },


        gts: function(e) {
            var r = "";

            for (var j in e) {
                var i = e[j];

                if (r != "") {
                    r += ";";
                }

                r += i.minIndex + "," + i.maxIndex;
            }

            return r;
        },

        prepareReferences: function() {
            var a;
            a = new qx.application.AbstractGui();
            a = new qx.application.Basic();
            a = new qx.application.Inline();
            a = new qx.application.Mobile();
            a = new qx.application.Native();
            a = new qx.application.Standalone();
            a = new qx.bom.Blocker();
            a = new qx.bom.FileReader();
            a = new qx.bom.Font();
            a = new qx.bom.GeoLocation();
            a = new qx.bom.History();
            a = new qx.bom.htmlarea.HtmlArea();
            a = new qx.bom.htmlarea.manager.Command();
            a = new qx.bom.htmlarea.manager.UndoRedo();
            a = new qx.bom.media.Abstract();
            a = new qx.bom.media.Audio();
            a = new qx.bom.media.Video();
            a = new qx.bom.Shortcut();
            a = new qx.bom.webfonts.Manager();
            a = new qx.bom.webfonts.Validator();
            a = new qx.bom.webfonts.WebFont();
            a = new qx.bom.WebWorker();
            a = new qx.core.Object();
            a = new qx.data.Array();
            a = new qx.data.controller.Form();
            a = new qx.data.controller.List();
            a = new qx.data.controller.Object();
            a = new qx.data.controller.Tree();
            a = new qx.data.controller.website.List();
            a = new qx.event.AcceleratingTimer();
            a = new qx.event.dispatch.AbstractBubbling();
            a = new qx.event.dispatch.Direct();
            a = new qx.event.dispatch.DomBubbling();
            a = new qx.event.dispatch.MouseCapture();
            a = new qx.html.Blocker();
            a = new qx.html.Canvas();
            a = new qx.html.Element();
            a = new qx.html.Flash();
            a = new qx.html.Iframe();
            a = new qx.html.Image();
            a = new qx.html.Input();
            a = new qx.html.Label();
            a = new qx.html.Root();
            a = new qx.ui.basic.Atom();
            a = new qx.ui.basic.Image();
            a = new qx.ui.basic.Label();
            a = new qx.ui.container.Composite();
            a = new qx.ui.container.Resizer();
            a = new qx.ui.container.Scroll();
            a = new qx.ui.container.SlideBar();
            a = new qx.ui.container.Stack();
            a = new qx.ui.control.ColorPopup();
            a = new qx.ui.control.ColorSelector();
            a = new qx.ui.control.DateChooser();
            a = new qx.ui.core.Blocker();
            a = new qx.ui.core.ColumnData();
            a = new qx.ui.core.Command();
            a = new qx.ui.core.DragDropCursor();
            a = new qx.ui.core.EventHandler();
            a = new qx.ui.core.FocusHandler();
            a = new qx.ui.core.LayoutItem();
            a = new qx.ui.core.scroll.AbstractScrollArea();
            a = new qx.ui.core.scroll.NativeScrollBar();
            a = new qx.ui.core.scroll.ScrollBar();
            a = new qx.ui.core.scroll.ScrollPane();
            a = new qx.ui.core.selection.Abstract();
            a = new qx.ui.core.selection.ScrollArea();
            a = new qx.ui.core.selection.Widget();
            a = new qx.ui.core.Spacer();
            a = new qx.ui.core.Widget();
            a = new qx.ui.decoration.Abstract();
            a = new qx.ui.decoration.Decorator();
            a = new qx.ui.form.AbstractField();
            a = new qx.ui.form.AbstractSelectBox();
            a = new qx.ui.form.Button();
            a = new qx.ui.form.CheckBox();
            a = new qx.ui.form.ComboBox();
            a = new qx.ui.form.core.AbstractVirtualBox();
            a = new qx.ui.form.DateField();
            a = new qx.ui.form.Form();
            a = new qx.ui.form.HoverButton();
            a = new qx.ui.form.List();
            a = new qx.ui.form.ListItem();
            a = new qx.ui.form.MenuButton();
            a = new qx.ui.form.PasswordField();
            a = new qx.ui.form.RadioButton();
            a = new qx.ui.form.RadioButtonGroup();
            a = new qx.ui.form.RadioGroup();
            a = new qx.ui.form.renderer.AbstractRenderer();
            a = new qx.ui.form.renderer.Double();
            a = new qx.ui.form.renderer.Single();
            a = new qx.ui.form.renderer.SinglePlaceholder();
            a = new qx.ui.form.RepeatButton();
            a = new qx.ui.form.Resetter();
            a = new qx.ui.form.SelectBox();
            a = new qx.ui.form.Slider();
            a = new qx.ui.form.Spinner();
            a = new qx.ui.form.SplitButton();
            a = new qx.ui.form.TextArea();
            a = new qx.ui.form.TextField();
            a = new qx.ui.form.ToggleButton();
            a = new qx.ui.form.validation.AsyncValidator();
            a = new qx.ui.form.validation.Manager();
            a = new qx.ui.form.VirtualComboBox();
            a = new qx.ui.form.VirtualSelectBox();
            a = new qx.ui.groupbox.CheckGroupBox();
            a = new qx.ui.groupbox.GroupBox();
            a = new qx.ui.groupbox.RadioGroupBox();
            a = new qx.ui.indicator.ProgressBar();
            a = new qx.ui.layout.Abstract();
            a = new qx.ui.layout.Atom();
            a = new qx.ui.layout.Basic();
            a = new qx.ui.layout.Canvas();
            a = new qx.ui.layout.Dock();
            a = new qx.ui.layout.Flow();
            a = new qx.ui.layout.Grid();
            a = new qx.ui.layout.Grow();
            a = new qx.ui.layout.HBox();
            a = new qx.ui.layout.VBox();
            a = new qx.ui.list.List();
            a = new qx.ui.menu.AbstractButton();
            a = new qx.ui.menu.Button();
            a = new qx.ui.menu.CheckBox();
            a = new qx.ui.menu.Manager();
            a = new qx.ui.menu.Menu();
            a = new qx.ui.menu.RadioButton();
            a = new qx.ui.menu.Separator();
            a = new qx.ui.menubar.Button();
            a = new qx.ui.menubar.MenuBar();
            a = new qx.ui.popup.Manager();
            a = new qx.ui.popup.Popup();
            a = new qx.ui.root.Abstract();
            a = new qx.ui.root.Application();
            a = new qx.ui.root.Inline();
            a = new qx.ui.root.Page();
            a = new qx.ui.splitpane.Pane();
            a = new qx.ui.style.Stylesheet();
            a = new qx.ui.table.celleditor.AbstractField();
            a = new qx.ui.table.celleditor.CheckBox();
            a = new qx.ui.table.celleditor.ComboBox();
            a = new qx.ui.table.celleditor.Dynamic();
            a = new qx.ui.table.celleditor.PasswordField();
            a = new qx.ui.table.celleditor.SelectBox();
            a = new qx.ui.table.celleditor.TextField();
            a = new qx.ui.table.cellrenderer.Abstract();
            a = new qx.ui.table.cellrenderer.AbstractImage();
            a = new qx.ui.table.cellrenderer.Boolean();
            a = new qx.ui.table.cellrenderer.Conditional();
            a = new qx.ui.table.cellrenderer.Date();
            a = new qx.ui.table.cellrenderer.Debug();
            a = new qx.ui.table.cellrenderer.Default();
            a = new qx.ui.table.cellrenderer.Dynamic();
            a = new qx.ui.table.cellrenderer.Html();
            a = new qx.ui.table.cellrenderer.Image();
            a = new qx.ui.table.cellrenderer.Number();
            a = new qx.ui.table.cellrenderer.Password();
            a = new qx.ui.table.cellrenderer.Replace();
            a = new qx.ui.table.cellrenderer.String();
            a = new qx.ui.table.columnmenu.Button();
            a = new qx.ui.table.columnmenu.MenuItem();
            a = new qx.ui.table.columnmodel.Basic();
            a = new qx.ui.table.columnmodel.Resize();
            a = new qx.ui.table.columnmodel.resizebehavior.Abstract();
            a = new qx.ui.table.columnmodel.resizebehavior.Default();
            a = new qx.ui.table.headerrenderer.Default();
            a = new qx.ui.table.headerrenderer.HeaderCell();
            a = new qx.ui.table.headerrenderer.Icon();
            a = new qx.ui.table.model.Abstract();
            a = new qx.ui.table.model.Filtered();
            a = new qx.ui.table.model.Remote();
            a = new qx.ui.table.model.Simple();
            a = new qx.ui.table.pane.CellEvent();
            a = new qx.ui.table.pane.Clipper();
            a = new qx.ui.table.pane.FocusIndicator();
            a = new qx.ui.table.pane.Header();
            a = new qx.ui.table.pane.Model();
            a = new qx.ui.table.pane.Pane();
            a = new qx.ui.table.pane.Scroller();
            a = new qx.ui.table.rowrenderer.Default();
            a = new qx.ui.table.selection.Manager();
            a = new qx.ui.table.selection.Model();
            a = new qx.ui.table.Table();
            a = new qx.ui.tabview.Page();
            a = new qx.ui.tabview.TabButton();
            a = new qx.ui.tabview.TabView();
            a = new qx.ui.toolbar.Button();
            a = new qx.ui.toolbar.CheckBox();
            a = new qx.ui.toolbar.MenuButton();
            a = new qx.ui.toolbar.Part();
            a = new qx.ui.toolbar.RadioButton();
            a = new qx.ui.toolbar.Separator();
            a = new qx.ui.toolbar.SplitButton();
            a = new qx.ui.toolbar.ToolBar();
            a = new qx.ui.tooltip.Manager();
            a = new qx.ui.tooltip.ToolTip();
            a = new qx.ui.tree.core.AbstractItem();
            a = new qx.ui.tree.core.AbstractTreeItem();
            a = new qx.ui.tree.core.FolderOpenButton();
            a = new qx.ui.tree.Tree();
            a = new qx.ui.tree.TreeFile();
            a = new qx.ui.tree.TreeFolder();
            a = new qx.ui.tree.VirtualTree();
            a = new qx.ui.tree.VirtualTreeItem();
            a = new qx.ui.treevirtual.DefaultDataCellRenderer();
            a = new qx.ui.treevirtual.SelectionManager();
            a = new qx.ui.treevirtual.SimpleTreeDataCellRenderer();
            a = new qx.ui.treevirtual.SimpleTreeDataModel();
            a = new qx.ui.treevirtual.SimpleTreeDataRowRenderer();
            a = new qx.ui.treevirtual.TreeVirtual();
            a = new qx.ui.virtual.behavior.Prefetch();
            a = new qx.ui.virtual.cell.Abstract();
            a = new qx.ui.virtual.cell.AbstractImage();
            a = new qx.ui.virtual.cell.AbstractWidget();
            a = new qx.ui.virtual.cell.Boolean();
            a = new qx.ui.virtual.cell.Cell();
            a = new qx.ui.virtual.cell.CellStylesheet();
            a = new qx.ui.virtual.cell.Date();
            a = new qx.ui.virtual.cell.Html();
            a = new qx.ui.virtual.cell.Image();
            a = new qx.ui.virtual.cell.Number();
            a = new qx.ui.virtual.cell.String();
            a = new qx.ui.virtual.cell.WidgetCell();
            a = new qx.ui.virtual.core.Axis();
            a = new qx.ui.virtual.core.CellEvent();
            a = new qx.ui.virtual.core.Pane();
            a = new qx.ui.virtual.core.Scroller();
            a = new qx.ui.virtual.layer.Abstract();
            a = new qx.ui.virtual.layer.AbstractBackground();
            a = new qx.ui.virtual.layer.CellSpanManager();
            a = new qx.ui.virtual.layer.Column();
            a = new qx.ui.virtual.layer.GridLines();
            a = new qx.ui.virtual.layer.HtmlCell();
            a = new qx.ui.virtual.layer.HtmlCellSpan();
            a = new qx.ui.virtual.layer.Row();
            a = new qx.ui.virtual.layer.WidgetCell();
            a = new qx.ui.virtual.layer.WidgetCellSpan();
            a = new qx.ui.virtual.selection.Abstract();
            a = new qx.ui.virtual.selection.CellLines();
            a = new qx.ui.virtual.selection.CellRectangle();
            a = new qx.ui.virtual.selection.Column();
            a = new qx.ui.virtual.selection.Row();
            a = new qx.ui.window.Desktop();
            a = new qx.ui.window.Manager();
            a = new qx.ui.window.Window();
            a = new qx.util.AliasManager();
            a = new qx.util.DeferredCall();
            a = new qx.util.DeferredCallManager();
            a = new qx.util.format.DateFormat();
            a = new qx.util.format.NumberFormat();
            a = new qx.util.fsm.FiniteStateMachine();
            a = new qx.util.fsm.State();
            a = new qx.util.fsm.Transition();
            a = new qx.util.LibraryManager();
            a = new qx.util.ObjectPool();
            a = new qx.util.placement.Placement();
            a = new qx.util.ResourceManager();
            a = new qx.util.StringBuilder();
            a = new qx.util.TimerManager();
            a = new qx.util.ValueManager();
            a = new qxdotnet.table.RemoteDataModel();
            a = new uploadwidget.UploadButton();
            a = new uploadwidget.UploadForm();
            a = new uploadwidget.UploadField();
        }
    }
});

if (!Array.prototype.indexOf)

    Array.prototype.indexOf = function(searchElement, fromIndex) {
        for (var i = fromIndex || 0, length = this.length; i < length; i++)
            if (this[i] === searchElement) return i;
        return -1;
    };