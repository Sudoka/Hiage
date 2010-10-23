// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------



public partial class MainWindow {
    
    private Gtk.UIManager UIManager;
    
    private Gtk.Action FileAction;
    
    private Gtk.Action NewAction;
    
    private Gtk.Action OpenAction;
    
    private Gtk.Action SaveAction;
    
    private Gtk.Action SaveAsAction;
    
    private Gtk.Action QuitAction;
    
    private Gtk.VBox main_vbox;
    
    private Gtk.MenuBar menubar1;
    
    private Gtk.Frame frame3;
    
    private Gtk.Alignment GtkAlignment;
    
    private Gtk.Table table2;
    
    private Gtk.Label label10;
    
    private Gtk.Label label3;
    
    private Gtk.Label label4;
    
    private Gtk.Label label5;
    
    private Gtk.Label labelHeight;
    
    private Gtk.Label labelLayers;
    
    private Gtk.Label labelMousePos;
    
    private Gtk.Label labelWidth;
    
    private Gtk.Label GtkLabel1;
    
    private Gtk.Frame frame2;
    
    private Gtk.Alignment GtkAlignment1;
    
    private Gtk.Table table3;
    
    private Gtk.ComboBox comboBackgrounds;
    
    private Gtk.Label label1;
    
    private Gtk.Label GtkLabel2;
    
    private Gtk.Frame frame1;
    
    private Gtk.Alignment GtkAlignment2;
    
    private Gtk.Table table1;
    
    private Gtk.Label GtkLabel3;
    
    private Gtk.Frame frame4;
    
    private Gtk.Alignment GtkAlignment3;
    
    private Gtk.VBox vbox6;
    
    private Gtk.HBox hbox6;
    
    private Gtk.RadioButton radioDrawTiles;
    
    private Gtk.RadioButton radioSelectObjects;
    
    private Gtk.RadioButton radioCreateObjects;
    
    private Gtk.Table table4;
    
    private Gtk.Label label2;
    
    private Gtk.SpinButton spinDrawToLayer;
    
    private Gtk.Label GtkLabel7;
    
    protected virtual void Build() {
        Stetic.Gui.Initialize(this);
        // Widget MainWindow
        this.UIManager = new Gtk.UIManager();
        Gtk.ActionGroup w1 = new Gtk.ActionGroup("Default");
        this.FileAction = new Gtk.Action("FileAction", Mono.Unix.Catalog.GetString("File"), null, null);
        this.FileAction.ShortLabel = Mono.Unix.Catalog.GetString("File");
        w1.Add(this.FileAction, null);
        this.NewAction = new Gtk.Action("NewAction", Mono.Unix.Catalog.GetString("New"), null, null);
        this.NewAction.ShortLabel = Mono.Unix.Catalog.GetString("New");
        w1.Add(this.NewAction, null);
        this.OpenAction = new Gtk.Action("OpenAction", Mono.Unix.Catalog.GetString("Open"), null, null);
        this.OpenAction.ShortLabel = Mono.Unix.Catalog.GetString("Open");
        w1.Add(this.OpenAction, null);
        this.SaveAction = new Gtk.Action("SaveAction", Mono.Unix.Catalog.GetString("Save"), null, null);
        this.SaveAction.ShortLabel = Mono.Unix.Catalog.GetString("Save");
        w1.Add(this.SaveAction, null);
        this.SaveAsAction = new Gtk.Action("SaveAsAction", Mono.Unix.Catalog.GetString("Save as"), null, null);
        this.SaveAsAction.ShortLabel = Mono.Unix.Catalog.GetString("Save as");
        w1.Add(this.SaveAsAction, null);
        this.QuitAction = new Gtk.Action("QuitAction", Mono.Unix.Catalog.GetString("Quit"), null, null);
        this.QuitAction.ShortLabel = Mono.Unix.Catalog.GetString("Quit");
        w1.Add(this.QuitAction, null);
        this.UIManager.InsertActionGroup(w1, 0);
        this.AddAccelGroup(this.UIManager.AccelGroup);
        this.Name = "MainWindow";
        this.Title = Mono.Unix.Catalog.GetString("MainWindow");
        this.WindowPosition = ((Gtk.WindowPosition)(2));
        // Container child MainWindow.Gtk.Container+ContainerChild
        this.main_vbox = new Gtk.VBox();
        this.main_vbox.Name = "main_vbox";
        this.main_vbox.Spacing = 6;
        // Container child main_vbox.Gtk.Box+BoxChild
        this.UIManager.AddUiFromString("<ui><menubar name='menubar1'><menu name='FileAction' action='FileAction'><menuitem name='NewAction' action='NewAction'/><menuitem name='OpenAction' action='OpenAction'/><menuitem name='SaveAction' action='SaveAction'/><menuitem name='SaveAsAction' action='SaveAsAction'/><separator/><menuitem name='QuitAction' action='QuitAction'/></menu></menubar></ui>");
        this.menubar1 = ((Gtk.MenuBar)(this.UIManager.GetWidget("/menubar1")));
        this.menubar1.Name = "menubar1";
        this.main_vbox.Add(this.menubar1);
        Gtk.Box.BoxChild w2 = ((Gtk.Box.BoxChild)(this.main_vbox[this.menubar1]));
        w2.Position = 0;
        w2.Expand = false;
        w2.Fill = false;
        // Container child main_vbox.Gtk.Box+BoxChild
        this.frame3 = new Gtk.Frame();
        this.frame3.Name = "frame3";
        this.frame3.ShadowType = ((Gtk.ShadowType)(0));
        // Container child frame3.Gtk.Container+ContainerChild
        this.GtkAlignment = new Gtk.Alignment(0F, 0F, 1F, 1F);
        this.GtkAlignment.Name = "GtkAlignment";
        this.GtkAlignment.LeftPadding = ((uint)(12));
        // Container child GtkAlignment.Gtk.Container+ContainerChild
        this.table2 = new Gtk.Table(((uint)(4)), ((uint)(2)), false);
        this.table2.Name = "table2";
        this.table2.RowSpacing = ((uint)(6));
        this.table2.ColumnSpacing = ((uint)(20));
        // Container child table2.Gtk.Table+TableChild
        this.label10 = new Gtk.Label();
        this.label10.Name = "label10";
        this.label10.Xalign = 0F;
        this.label10.LabelProp = Mono.Unix.Catalog.GetString("Cursor position");
        this.table2.Add(this.label10);
        Gtk.Table.TableChild w3 = ((Gtk.Table.TableChild)(this.table2[this.label10]));
        w3.TopAttach = ((uint)(3));
        w3.BottomAttach = ((uint)(4));
        w3.XOptions = ((Gtk.AttachOptions)(4));
        w3.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table2.Gtk.Table+TableChild
        this.label3 = new Gtk.Label();
        this.label3.Name = "label3";
        this.label3.Xalign = 0F;
        this.label3.LabelProp = Mono.Unix.Catalog.GetString("Width");
        this.table2.Add(this.label3);
        Gtk.Table.TableChild w4 = ((Gtk.Table.TableChild)(this.table2[this.label3]));
        w4.XOptions = ((Gtk.AttachOptions)(4));
        w4.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table2.Gtk.Table+TableChild
        this.label4 = new Gtk.Label();
        this.label4.Name = "label4";
        this.label4.Xalign = 0F;
        this.label4.LabelProp = Mono.Unix.Catalog.GetString("Height");
        this.table2.Add(this.label4);
        Gtk.Table.TableChild w5 = ((Gtk.Table.TableChild)(this.table2[this.label4]));
        w5.TopAttach = ((uint)(1));
        w5.BottomAttach = ((uint)(2));
        w5.XOptions = ((Gtk.AttachOptions)(4));
        w5.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table2.Gtk.Table+TableChild
        this.label5 = new Gtk.Label();
        this.label5.Name = "label5";
        this.label5.Xalign = 0F;
        this.label5.LabelProp = Mono.Unix.Catalog.GetString("Layers");
        this.table2.Add(this.label5);
        Gtk.Table.TableChild w6 = ((Gtk.Table.TableChild)(this.table2[this.label5]));
        w6.TopAttach = ((uint)(2));
        w6.BottomAttach = ((uint)(3));
        w6.XOptions = ((Gtk.AttachOptions)(4));
        w6.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table2.Gtk.Table+TableChild
        this.labelHeight = new Gtk.Label();
        this.labelHeight.Name = "labelHeight";
        this.labelHeight.Xalign = 0F;
        this.labelHeight.LabelProp = Mono.Unix.Catalog.GetString("0");
        this.table2.Add(this.labelHeight);
        Gtk.Table.TableChild w7 = ((Gtk.Table.TableChild)(this.table2[this.labelHeight]));
        w7.TopAttach = ((uint)(1));
        w7.BottomAttach = ((uint)(2));
        w7.LeftAttach = ((uint)(1));
        w7.RightAttach = ((uint)(2));
        w7.XOptions = ((Gtk.AttachOptions)(4));
        w7.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table2.Gtk.Table+TableChild
        this.labelLayers = new Gtk.Label();
        this.labelLayers.Name = "labelLayers";
        this.labelLayers.Xalign = 0F;
        this.labelLayers.LabelProp = Mono.Unix.Catalog.GetString("0");
        this.table2.Add(this.labelLayers);
        Gtk.Table.TableChild w8 = ((Gtk.Table.TableChild)(this.table2[this.labelLayers]));
        w8.TopAttach = ((uint)(2));
        w8.BottomAttach = ((uint)(3));
        w8.LeftAttach = ((uint)(1));
        w8.RightAttach = ((uint)(2));
        w8.XOptions = ((Gtk.AttachOptions)(4));
        w8.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table2.Gtk.Table+TableChild
        this.labelMousePos = new Gtk.Label();
        this.labelMousePos.Name = "labelMousePos";
        this.labelMousePos.Xalign = 1F;
        this.labelMousePos.LabelProp = Mono.Unix.Catalog.GetString("(0,0)");
        this.table2.Add(this.labelMousePos);
        Gtk.Table.TableChild w9 = ((Gtk.Table.TableChild)(this.table2[this.labelMousePos]));
        w9.TopAttach = ((uint)(3));
        w9.BottomAttach = ((uint)(4));
        w9.LeftAttach = ((uint)(1));
        w9.RightAttach = ((uint)(2));
        w9.XOptions = ((Gtk.AttachOptions)(4));
        w9.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table2.Gtk.Table+TableChild
        this.labelWidth = new Gtk.Label();
        this.labelWidth.Name = "labelWidth";
        this.labelWidth.Xalign = 0F;
        this.labelWidth.LabelProp = Mono.Unix.Catalog.GetString("0");
        this.table2.Add(this.labelWidth);
        Gtk.Table.TableChild w10 = ((Gtk.Table.TableChild)(this.table2[this.labelWidth]));
        w10.LeftAttach = ((uint)(1));
        w10.RightAttach = ((uint)(2));
        w10.XOptions = ((Gtk.AttachOptions)(4));
        w10.YOptions = ((Gtk.AttachOptions)(4));
        this.GtkAlignment.Add(this.table2);
        this.frame3.Add(this.GtkAlignment);
        this.GtkLabel1 = new Gtk.Label();
        this.GtkLabel1.Name = "GtkLabel1";
        this.GtkLabel1.LabelProp = Mono.Unix.Catalog.GetString("<b>Map information</b>");
        this.GtkLabel1.UseMarkup = true;
        this.frame3.LabelWidget = this.GtkLabel1;
        this.main_vbox.Add(this.frame3);
        Gtk.Box.BoxChild w13 = ((Gtk.Box.BoxChild)(this.main_vbox[this.frame3]));
        w13.Position = 1;
        w13.Expand = false;
        w13.Fill = false;
        // Container child main_vbox.Gtk.Box+BoxChild
        this.frame2 = new Gtk.Frame();
        this.frame2.Name = "frame2";
        this.frame2.ShadowType = ((Gtk.ShadowType)(0));
        // Container child frame2.Gtk.Container+ContainerChild
        this.GtkAlignment1 = new Gtk.Alignment(0F, 0F, 1F, 1F);
        this.GtkAlignment1.Name = "GtkAlignment1";
        this.GtkAlignment1.LeftPadding = ((uint)(12));
        // Container child GtkAlignment1.Gtk.Container+ContainerChild
        this.table3 = new Gtk.Table(((uint)(3)), ((uint)(2)), false);
        this.table3.Name = "table3";
        this.table3.RowSpacing = ((uint)(6));
        this.table3.ColumnSpacing = ((uint)(6));
        // Container child table3.Gtk.Table+TableChild
        this.comboBackgrounds = Gtk.ComboBox.NewText();
        this.comboBackgrounds.Name = "comboBackgrounds";
        this.table3.Add(this.comboBackgrounds);
        Gtk.Table.TableChild w14 = ((Gtk.Table.TableChild)(this.table3[this.comboBackgrounds]));
        w14.LeftAttach = ((uint)(1));
        w14.RightAttach = ((uint)(2));
        w14.XOptions = ((Gtk.AttachOptions)(4));
        w14.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table3.Gtk.Table+TableChild
        this.label1 = new Gtk.Label();
        this.label1.Name = "label1";
        this.label1.LabelProp = Mono.Unix.Catalog.GetString("Background");
        this.table3.Add(this.label1);
        Gtk.Table.TableChild w15 = ((Gtk.Table.TableChild)(this.table3[this.label1]));
        w15.XOptions = ((Gtk.AttachOptions)(4));
        w15.YOptions = ((Gtk.AttachOptions)(4));
        this.GtkAlignment1.Add(this.table3);
        this.frame2.Add(this.GtkAlignment1);
        this.GtkLabel2 = new Gtk.Label();
        this.GtkLabel2.Name = "GtkLabel2";
        this.GtkLabel2.LabelProp = Mono.Unix.Catalog.GetString("<b>Map properties</b>");
        this.GtkLabel2.UseMarkup = true;
        this.frame2.LabelWidget = this.GtkLabel2;
        this.main_vbox.Add(this.frame2);
        Gtk.Box.BoxChild w18 = ((Gtk.Box.BoxChild)(this.main_vbox[this.frame2]));
        w18.Position = 2;
        // Container child main_vbox.Gtk.Box+BoxChild
        this.frame1 = new Gtk.Frame();
        this.frame1.Name = "frame1";
        this.frame1.ShadowType = ((Gtk.ShadowType)(0));
        // Container child frame1.Gtk.Container+ContainerChild
        this.GtkAlignment2 = new Gtk.Alignment(0F, 0F, 1F, 1F);
        this.GtkAlignment2.Name = "GtkAlignment2";
        this.GtkAlignment2.LeftPadding = ((uint)(12));
        // Container child GtkAlignment2.Gtk.Container+ContainerChild
        this.table1 = new Gtk.Table(((uint)(3)), ((uint)(3)), false);
        this.table1.Name = "table1";
        this.table1.RowSpacing = ((uint)(6));
        this.table1.ColumnSpacing = ((uint)(6));
        this.GtkAlignment2.Add(this.table1);
        this.frame1.Add(this.GtkAlignment2);
        this.GtkLabel3 = new Gtk.Label();
        this.GtkLabel3.Name = "GtkLabel3";
        this.GtkLabel3.LabelProp = Mono.Unix.Catalog.GetString("<b>View</b>");
        this.GtkLabel3.UseMarkup = true;
        this.frame1.LabelWidget = this.GtkLabel3;
        this.main_vbox.Add(this.frame1);
        Gtk.Box.BoxChild w21 = ((Gtk.Box.BoxChild)(this.main_vbox[this.frame1]));
        w21.Position = 3;
        // Container child main_vbox.Gtk.Box+BoxChild
        this.frame4 = new Gtk.Frame();
        this.frame4.Name = "frame4";
        this.frame4.ShadowType = ((Gtk.ShadowType)(0));
        // Container child frame4.Gtk.Container+ContainerChild
        this.GtkAlignment3 = new Gtk.Alignment(0F, 0F, 1F, 1F);
        this.GtkAlignment3.Name = "GtkAlignment3";
        this.GtkAlignment3.LeftPadding = ((uint)(12));
        // Container child GtkAlignment3.Gtk.Container+ContainerChild
        this.vbox6 = new Gtk.VBox();
        this.vbox6.Name = "vbox6";
        this.vbox6.Spacing = 6;
        // Container child vbox6.Gtk.Box+BoxChild
        this.hbox6 = new Gtk.HBox();
        this.hbox6.Name = "hbox6";
        this.hbox6.Spacing = 6;
        // Container child hbox6.Gtk.Box+BoxChild
        this.radioDrawTiles = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Draw tiles"));
        this.radioDrawTiles.CanFocus = true;
        this.radioDrawTiles.Name = "radioDrawTiles";
        this.radioDrawTiles.Active = true;
        this.radioDrawTiles.DrawIndicator = true;
        this.radioDrawTiles.UseUnderline = true;
        this.radioDrawTiles.Group = new GLib.SList(System.IntPtr.Zero);
        this.hbox6.Add(this.radioDrawTiles);
        Gtk.Box.BoxChild w22 = ((Gtk.Box.BoxChild)(this.hbox6[this.radioDrawTiles]));
        w22.Position = 0;
        // Container child hbox6.Gtk.Box+BoxChild
        this.radioSelectObjects = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Select objects"));
        this.radioSelectObjects.CanFocus = true;
        this.radioSelectObjects.Name = "radioSelectObjects";
        this.radioSelectObjects.DrawIndicator = true;
        this.radioSelectObjects.UseUnderline = true;
        this.radioSelectObjects.Group = this.radioDrawTiles.Group;
        this.hbox6.Add(this.radioSelectObjects);
        Gtk.Box.BoxChild w23 = ((Gtk.Box.BoxChild)(this.hbox6[this.radioSelectObjects]));
        w23.Position = 1;
        // Container child hbox6.Gtk.Box+BoxChild
        this.radioCreateObjects = new Gtk.RadioButton(Mono.Unix.Catalog.GetString("Create objects"));
        this.radioCreateObjects.CanFocus = true;
        this.radioCreateObjects.Name = "radioCreateObjects";
        this.radioCreateObjects.DrawIndicator = true;
        this.radioCreateObjects.UseUnderline = true;
        this.radioCreateObjects.Group = this.radioDrawTiles.Group;
        this.hbox6.Add(this.radioCreateObjects);
        Gtk.Box.BoxChild w24 = ((Gtk.Box.BoxChild)(this.hbox6[this.radioCreateObjects]));
        w24.Position = 2;
        this.vbox6.Add(this.hbox6);
        Gtk.Box.BoxChild w25 = ((Gtk.Box.BoxChild)(this.vbox6[this.hbox6]));
        w25.Position = 0;
        w25.Expand = false;
        w25.Fill = false;
        // Container child vbox6.Gtk.Box+BoxChild
        this.table4 = new Gtk.Table(((uint)(2)), ((uint)(2)), false);
        this.table4.Name = "table4";
        this.table4.RowSpacing = ((uint)(6));
        this.table4.ColumnSpacing = ((uint)(6));
        // Container child table4.Gtk.Table+TableChild
        this.label2 = new Gtk.Label();
        this.label2.Name = "label2";
        this.label2.Xalign = 0F;
        this.label2.LabelProp = Mono.Unix.Catalog.GetString("Draw to layer");
        this.table4.Add(this.label2);
        Gtk.Table.TableChild w26 = ((Gtk.Table.TableChild)(this.table4[this.label2]));
        w26.XOptions = ((Gtk.AttachOptions)(4));
        w26.YOptions = ((Gtk.AttachOptions)(4));
        // Container child table4.Gtk.Table+TableChild
        this.spinDrawToLayer = new Gtk.SpinButton(1, 1, 1);
        this.spinDrawToLayer.CanFocus = true;
        this.spinDrawToLayer.Name = "spinDrawToLayer";
        this.spinDrawToLayer.Adjustment.PageIncrement = 10;
        this.spinDrawToLayer.ClimbRate = 1;
        this.spinDrawToLayer.Numeric = true;
        this.spinDrawToLayer.Value = 1;
        this.table4.Add(this.spinDrawToLayer);
        Gtk.Table.TableChild w27 = ((Gtk.Table.TableChild)(this.table4[this.spinDrawToLayer]));
        w27.LeftAttach = ((uint)(1));
        w27.RightAttach = ((uint)(2));
        w27.XOptions = ((Gtk.AttachOptions)(4));
        w27.YOptions = ((Gtk.AttachOptions)(4));
        this.vbox6.Add(this.table4);
        Gtk.Box.BoxChild w28 = ((Gtk.Box.BoxChild)(this.vbox6[this.table4]));
        w28.Position = 1;
        this.GtkAlignment3.Add(this.vbox6);
        this.frame4.Add(this.GtkAlignment3);
        this.GtkLabel7 = new Gtk.Label();
        this.GtkLabel7.Name = "GtkLabel7";
        this.GtkLabel7.LabelProp = Mono.Unix.Catalog.GetString("<b>Drawing</b>");
        this.GtkLabel7.UseMarkup = true;
        this.frame4.LabelWidget = this.GtkLabel7;
        this.main_vbox.Add(this.frame4);
        Gtk.Box.BoxChild w31 = ((Gtk.Box.BoxChild)(this.main_vbox[this.frame4]));
        w31.Position = 4;
        this.Add(this.main_vbox);
        if ((this.Child != null)) {
            this.Child.ShowAll();
        }
        this.DefaultWidth = 359;
        this.DefaultHeight = 447;
        this.Show();
        this.DeleteEvent += new Gtk.DeleteEventHandler(this.OnDeleteEvent);
    }
}
